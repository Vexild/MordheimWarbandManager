using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarbandServer.Migrations
{
    /// <inheritdoc />
    public partial class HashedPasswordAddedForUser2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Joined", "Pass" },
                values: new object[] { new DateTime(2023, 4, 25, 11, 23, 35, 120, DateTimeKind.Utc).AddTicks(700), "Non-hashed-password" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Joined", "Pass" },
                values: new object[] { new DateTime(2023, 4, 25, 11, 23, 35, 120, DateTimeKind.Utc).AddTicks(705), "$2a$11$fhkoRG.3v0tMpcomQwnbTOALS3UnLHtfWC106R1osaNZukK5LfLcK" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Joined", "Pass" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 37, 8, 705, DateTimeKind.Utc).AddTicks(4104), "Non-hashed-password1" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Joined", "Pass" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 37, 8, 705, DateTimeKind.Utc).AddTicks(4106), "Non-hashed-password2" });
        }
    }
}
