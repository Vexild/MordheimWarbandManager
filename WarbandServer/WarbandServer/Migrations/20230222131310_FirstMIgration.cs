using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WarbandServer.Migrations
{
    /// <inheritdoc />
    public partial class FirstMIgration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Pass = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Mail = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    PrivateUser = table.Column<bool>(type: "boolean", nullable: false),
                    Joined = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Joined", "Mail", "Name", "Pass", "PrivateUser" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 22, 13, 13, 10, 355, DateTimeKind.Utc).AddTicks(7687), "testmail1.com", "Test User 1", "Non-hashed-password1", false },
                    { 2, new DateTime(2023, 2, 22, 13, 13, 10, 355, DateTimeKind.Utc).AddTicks(7690), "testmail2.com", "Test User 2", "Non-hashed-password2", false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
