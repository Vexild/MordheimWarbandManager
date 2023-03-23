using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarbandServer.Migrations
{
    /// <inheritdoc />
    public partial class addedFaction2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Faction",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "SpecialRule" },
                values: new object[] { "Reikland lies at the heart of the Empire and its greatest city is Altdorf, home of the Grand Theogonist and seat of the Temple of Sigmar. \r\n                        Reiklanders are devout followers of Sigmar, the founder, first Emperor, and patron god of the Empire. The Grand Prince of Reikland \r\n                        (as Siegfried, the ruler of Reikland, styles himself) is supported in his claim to the throne by the Grand Theogonist and opposed most strongly \r\n                        by the Count of Middenheim and the Priests of Ulric. Throughout the Empire Reiklanders are commonly supposed to embody the discipline and loyalty of \r\n                        the professional warrior. Brave and well-versed in the arts of war, Reiklanders disdain fashionable clothing in favour of well-made and practical wargear. \r\n                        In battle they often wear coloured ribbons as marks of identification or authority. They are justly proud of their dynamic and ambitious Grand Prince \r\n                        and contemptuous of other claimants to the throne, especially the Count of Middenheim, Mannfred Todbringer, whom they sneeringly call the ‘lap-dog of Ulric’.", "Reikland Mercenaries are accustomed to the demands of military discipline and have a strongly developed loyalty between officers and men. \r\n                        To represent this, fighters may use their Captain’s Leadership if within 12\" rather than the usual 6\". A strong tradition of martial training is \r\n                        also responsible for the high standards of archery amongst the people of Reikland. All Marksmen therefore add +1 to their Ballistic Skill, \r\n                        whether they are recruited when the warband is first formed or added later." });

            migrationBuilder.InsertData(
                table: "Faction",
                columns: new[] { "Id", "Description", "Legality", "MaximumWarriors", "MinimumWarriors", "Name", "SpecialRule", "StartingGold" },
                values: new object[] { 2, "Middenheim stands on a mountain pinnacle surrounded by dark forest in the centre of Middenland, and is also known as the City of the White Wolf \r\n                        after Ulric, the old god of wolves and winter. The Priesthood of Ulric is still strong in Middenheim where Ulric is venerated as the patron of the city. \r\n                        The tradition of rivalry between Middenheim and Reikland goes back hundreds of years, and the Count of Middenheim, Mannfred Todbringer, is one of the \r\n                        chief contenders for the Emperor’s throne. As a result there has always been a great deal of friction between Middenheimers and the Temple of Sigmar.\\n\r\n                        Middenheimers are typically large, strongly built men with a well deserved reputation for ferocity. Many wear wolf pelts which custom decrees to be the \r\n                        mark of those who have slain a wolf with their own hands. These grim warriors are famously contemptuous of danger. They frequently go into battle bare-headed, \r\n                        scoffing at those who choose, for reasons of good sense, to wear helmets. As Middenheimers favour long hair and beards their lack of headgear makes them \r\n                        look especially fierce when they charge upon their enemies howling their brutal battle-cries. ", "A1", 15, 3, "Middenheim", "The men of Middenheim are famous for their physical prowess. To represent their advantage in size and bulk, the Champions and Captains of a \r\n                        Middenheim warband start with Strength 4 instead of Strength 3.", 500 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Joined",
                value: new DateTime(2023, 3, 22, 14, 14, 46, 257, DateTimeKind.Utc).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "Joined",
                value: new DateTime(2023, 3, 22, 14, 14, 46, 257, DateTimeKind.Utc).AddTicks(8145));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Faction",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Faction",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "SpecialRule" },
                values: new object[] { "Reikland lies at the heart of the Empire and its greatest city is Altdorf, home of the Grand Theogonist and seat of the Temple of Sigmar. Reiklanders are devout followers of Sigmar, the founder, first Emperor, and patron god of the Empire. The Grand Prince of Reikland (as Siegfried, the ruler of Reikland, styles himself) is supported in his claim to the throne by the Grand Theogonist and opposed most strongly by the Count of Middenheim and the Priests of Ulric. Throughout the Empire Reiklanders are commonly supposed to embody the discipline and loyalty of the professional warrior. Brave and well-versed in the arts of war, Reiklanders disdain fashionable clothing in favour of well-made and practical wargear. In battle they often wear coloured ribbons as marks of identification or authority. They are justly proud of their dynamic and ambitious Grand Prince and contemptuous of other claimants to the throne, especially the Count of Middenheim, Mannfred Todbringer, whom they sneeringly call the ‘lap-dog of Ulric’.", "Reikland Mercenaries are accustomed to the demands of military discipline and have a strongly developed loyalty between officers and men. To represent this, fighters may use their Captain’s Leadership if within 12\" rather than the usual 6\".\nA strong tradition of martial training is also responsible for the high standards of archery amongst the people of Reikland. All Marksmen therefore add +1 to their Ballistic Skill, whether they are recruited when the warband is first formed or added later." });

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
    }
}
