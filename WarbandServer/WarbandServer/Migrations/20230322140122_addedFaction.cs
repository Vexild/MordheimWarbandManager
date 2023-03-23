using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarbandServer.Migrations
{
    /// <inheritdoc />
    public partial class addedFaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SkillRule",
                table: "Skill",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(600)",
                oldMaxLength: 600);

            migrationBuilder.AlterColumn<string>(
                name: "SkillName",
                table: "Skill",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "SkillCategory",
                table: "Skill",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Faction",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MaximumWarriors",
                table: "Faction",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MinimumWarriors",
                table: "Faction",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SpecialRule",
                table: "Faction",
                type: "character varying(600)",
                maxLength: 600,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "StartingGold",
                table: "Faction",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Faction",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "MaximumWarriors", "MinimumWarriors", "Name", "SpecialRule", "StartingGold" },
                values: new object[] { "Reikland lies at the heart of the Empire and its greatest city is Altdorf, home of the Grand Theogonist and seat of the Temple of Sigmar. Reiklanders are devout followers of Sigmar, the founder, first Emperor, and patron god of the Empire. The Grand Prince of Reikland (as Siegfried, the ruler of Reikland, styles himself) is supported in his claim to the throne by the Grand Theogonist and opposed most strongly by the Count of Middenheim and the Priests of Ulric. Throughout the Empire Reiklanders are commonly supposed to embody the discipline and loyalty of the professional warrior. Brave and well-versed in the arts of war, Reiklanders disdain fashionable clothing in favour of well-made and practical wargear. In battle they often wear coloured ribbons as marks of identification or authority. They are justly proud of their dynamic and ambitious Grand Prince and contemptuous of other claimants to the throne, especially the Count of Middenheim, Mannfred Todbringer, whom they sneeringly call the ‘lap-dog of Ulric’.", 15, 3, "Reikland", "Reikland Mercenaries are accustomed to the demands of military discipline and have a strongly developed loyalty between officers and men. To represent this, fighters may use their Captain’s Leadership if within 12\" rather than the usual 6\".\nA strong tradition of martial training is also responsible for the high standards of archery amongst the people of Reikland. All Marksmen therefore add +1 to their Ballistic Skill, whether they are recruited when the warband is first formed or added later.", 500 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Joined",
                value: new DateTime(2023, 3, 22, 14, 1, 22, 14, DateTimeKind.Utc).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "Joined",
                value: new DateTime(2023, 3, 22, 14, 1, 22, 14, DateTimeKind.Utc).AddTicks(3661));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Faction");

            migrationBuilder.DropColumn(
                name: "MaximumWarriors",
                table: "Faction");

            migrationBuilder.DropColumn(
                name: "MinimumWarriors",
                table: "Faction");

            migrationBuilder.DropColumn(
                name: "SpecialRule",
                table: "Faction");

            migrationBuilder.DropColumn(
                name: "StartingGold",
                table: "Faction");

            migrationBuilder.AlterColumn<string>(
                name: "SkillRule",
                table: "Skill",
                type: "character varying(600)",
                maxLength: 600,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "SkillName",
                table: "Skill",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "SkillCategory",
                table: "Skill",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "Faction",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Averland");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Joined",
                value: new DateTime(2023, 3, 22, 13, 9, 45, 105, DateTimeKind.Utc).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "Joined",
                value: new DateTime(2023, 3, 22, 13, 9, 45, 105, DateTimeKind.Utc).AddTicks(5117));
        }
    }
}
