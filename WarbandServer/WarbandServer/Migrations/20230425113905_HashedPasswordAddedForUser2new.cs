using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarbandServer.Migrations
{
    /// <inheritdoc />
    public partial class HashedPasswordAddedForUser2new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Joined",
                value: new DateTime(2023, 4, 25, 11, 39, 5, 128, DateTimeKind.Utc).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Joined", "Pass" },
                values: new object[] { new DateTime(2023, 4, 25, 11, 39, 5, 128, DateTimeKind.Utc).AddTicks(8208), "$2a$11$LGCaScS6YtxBQfielNrpQ.2dr/knhugCB46Po.IqXppjlypwxuKwy" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Joined",
                value: new DateTime(2023, 4, 25, 11, 23, 35, 120, DateTimeKind.Utc).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Joined", "Pass" },
                values: new object[] { new DateTime(2023, 4, 25, 11, 23, 35, 120, DateTimeKind.Utc).AddTicks(705), "$2a$11$fhkoRG.3v0tMpcomQwnbTOALS3UnLHtfWC106R1osaNZukK5LfLcK" });
        }
    }
}
