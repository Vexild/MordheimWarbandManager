using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WarbandServer.Migrations
{
    /// <inheritdoc />
    public partial class newMig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Faction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: false),
                    Legality = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SkillName = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    SkillCategory = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    SkillRule = table.Column<string>(type: "character varying(600)", maxLength: 600, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FactionId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    StartingExp = table.Column<int>(type: "integer", nullable: false),
                    CombatSkill = table.Column<bool>(type: "boolean", nullable: false),
                    ShootingSkill = table.Column<bool>(type: "boolean", nullable: false),
                    AcademicSkill = table.Column<bool>(type: "boolean", nullable: false),
                    StrengthSkill = table.Column<bool>(type: "boolean", nullable: false),
                    SpeedSkill = table.Column<bool>(type: "boolean", nullable: false),
                    Cost = table.Column<int>(type: "integer", nullable: false),
                    CostNotes = table.Column<int>(type: "integer", nullable: false),
                    MaxGroupSize = table.Column<int>(type: "integer", nullable: false),
                    UnitLimit = table.Column<int>(type: "integer", nullable: false),
                    HiredSword = table.Column<bool>(type: "boolean", nullable: false),
                    Movement = table.Column<int>(type: "integer", nullable: false),
                    WSkill = table.Column<int>(type: "integer", nullable: false),
                    BSkill = table.Column<int>(type: "integer", nullable: false),
                    Strength = table.Column<int>(type: "integer", nullable: false),
                    Toughness = table.Column<int>(type: "integer", nullable: false),
                    Wounds = table.Column<int>(type: "integer", nullable: false),
                    Initiative = table.Column<int>(type: "integer", nullable: false),
                    Attacks = table.Column<int>(type: "integer", nullable: false),
                    LeaderShip = table.Column<int>(type: "integer", nullable: false),
                    MaxMovement = table.Column<int>(type: "integer", nullable: false),
                    MaxWSkill = table.Column<int>(type: "integer", nullable: false),
                    MaxBSkill = table.Column<int>(type: "integer", nullable: false),
                    MaxStrength = table.Column<int>(type: "integer", nullable: false),
                    MaxToughness = table.Column<int>(type: "integer", nullable: false),
                    MaxWounds = table.Column<int>(type: "integer", nullable: false),
                    MaxInitiative = table.Column<int>(type: "integer", nullable: false),
                    MaxAttacks = table.Column<int>(type: "integer", nullable: false),
                    MaxLeaderShip = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit", x => x.Id);
                });

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
                table: "Faction",
                columns: new[] { "Id", "Legality", "Name" },
                values: new object[] { 1, "A1", "Averland" });

            migrationBuilder.InsertData(
                table: "Skill",
                columns: new[] { "Id", "SkillCategory", "SkillName", "SkillRule" },
                values: new object[,]
                {
                    { 1, "Combat", "Strike to Injure", "The warrior can land his blows with uncanny accuracy. Add +1 to all injury rolls caused by the model in hand-to-hand combat." },
                    { 2, "Combat", "Combat Master", "The warrior is able to take on several opponents at once. If he fights against more than one enemy at a time, he gains an extra Attack in each hand-to-hand combat phase as long as he is fighting two or more enemy models. In addition, the warrior is immune to ‘All Alone’ tests.." },
                    { 3, "Combat", "Weapons Training", "A warrior with this skill is adept at using many different weapons. He may use any hand-to-hand combat weapon he comes across, not just those in his equipment options." },
                    { 4, "Combat", "Web of Steel", " Few can match the ability of this warrior. He fights with great skill, weaving a web of steel around him. The model gains +1 to all his rolls on Critical Hit tables in hand-to-hand combat." },
                    { 5, "Combat", "Expert Swordsman", "This warrior has been expertly taught in the art of swordsmanship. He may re-roll all missed attacks if he is using a sword in the hand-tohand phase of the turn that he charges. Note that this only applies when they are armed with normal swords or weeping blades, and not with doublehanded swords or any other weapons. " },
                    { 6, "Combat", "Step Aside", "The warrior has a natural ability to avoid injury in combat. Each time he suffers a wound in close combat he may make an additional saving throw of 5+. This save is never modified and is taken after all other armour saves." },
                    { 7, "Shooting", "Quick Shot", "The warrior may shoot twice per turn with a bow or crossbow (but not a crossbow pistol)." },
                    { 8, "Shooting", "Pistolier", "The warrior is an expert at using all kinds of pistols. If he is equipped with a brace of pistols of any type (including crossbow pistols), he may fire twice in the Shooting phase (though note that normal reloading rules apply). If he has a single pistol then he may fire it in the same turn it was reloaded. " },
                    { 9, "Shooting", "Eagle Eyes", "The warrior’s sight is exceptionally keen. He adds +6\" to the range of any missile weapon he is using." },
                    { 10, "Shooting", "Weapons Expert", "The warrior has been trained to use some of the more unusual weapons of the known world. He may use any missile weapon he comes across, not just the weapons available from his warband’s list." },
                    { 11, "Shooting", "Nimble", "The warrior may move and fire with weapons that are normally only used if the firer has not moved. Note that this skill cannot be combined with the Quick Shot skill" },
                    { 12, "Shooting", "Trick Shooter", "The warrior can shoot through the tiniest gap without it affecting his aim. He ignores all modifiers for cover when using missile weapons." },
                    { 13, "Academic", "Hunter", "The warrior is an expert at getting his weapon loaded and ready. He may fire each turn with a handgun or Hochland long rifle." },
                    { 14, "Academic", "Knife-Fighter", "The warrior is an unrivalled expert at using throwing knives and throwing stars. He can throw a maximum of three of these missiles in his shooting phase and may divide his shots between any targets within range as he wishes. Note that this skill cannot be combined with the Quick Shot skill." },
                    { 15, "Academic", "Battle Tongue", "This skill may only be chosen by a leader. The warrior has drilled his warband to follow short barked commands. This increases the range of his Leader ability by 6\". Note that Undead leaders may not use this skill." },
                    { 16, "Academic", "Sorcery", "This skill may only be taken by Heroes capable of casting spells. A warrior with this skill gains +1 to his rolls to see whether he can cast spells successfully or not. Note that Sisters of Sigmar and Warrior-Priests may not use this skill." },
                    { 17, "Academic", "Streetwise", "A warrior with this skill has good contacts and knows where to purchase rare items. He may add +2 to the roll that determines his chances of finding such items (see the Trading section)." },
                    { 18, "Academic", "Haggle", "The warrior knows all the tricks of bargaining and haggling. He may deduct 2D6 gold crowns from the price of any single item (to a minimum cost of 1gc) once per post battle sequence." },
                    { 19, "Academic", "Arcane Lore", "Witch Hunters, Sisters of Sigmar and Warrior-Priests may not have this skill. Any warrior with this skill may learn Lesser Magic if he owns a Tome of Magic." },
                    { 20, "Academic", "Wyrdstone Hunter", "The warrior has an uncanny ability to find hidden shards of wyrdstone. If a Hero with this skill is searching the ruins in the exploration phase you may re-roll one dice when rolling on the Exploration chart. The second result stands." },
                    { 21, "Academic", "Warrior Wizard", "This skill may only be taken by spellcasters. The mental powers of the wizard allow him to wear armour and cast spells." },
                    { 22, "Strength", "Mighty Blow", "The warrior knows how to use his strength to maximum effect and has a +1 Strength bonus in close combat (excluding pistols). As his Strength is used for close combat weapons, the bonus applies to all such weapons." },
                    { 23, "Strength", "Pit Fighter", "The warrior has learned how to fight in enclosed spaces from his time in the dangerous fighting pits of the Empire. He is an expert at fighting in confined areas and adds +1 to his WS and +1 to his Attacks if he is fighting inside buildings or ruins. It’s a good idea to define which bits of your terrain collection count as ‘buildings or ruins’ at the start of a battle to avoid confusion later. " },
                    { 24, "Strength", "Resilient", "The warrior is covered in battle scars. Deduct -1 Strength from all hits against him in close combat. This does not affect armour save modifiers." },
                    { 25, "Strength", "Fearsome", "Such is the reputation and physique of the model that he causes fear in opposing models." },
                    { 26, "Strength", "Strongman", "The warrior is capable of great feats of strength. He may use a double-handed weapon without the usual penalty of always striking last. Work out order of battle as you would with other weapons" },
                    { 27, "Strength", "Unstoppable Charge", "When he charges, the warrior is almost impossible to halt. He adds +1 to his Weapon Skill when charging." },
                    { 28, "Speed", "Leap", "The warrior may leap D6\" in the movement phase in addition to his normal movement. He may move and leap, run and leap, or charge and leap, but he can only leap once per turn. A leaping warrior may jump over opposing man-sized models, including enemies, and obstacles 1\" high, without penalty. The leap may also be used to leap over gaps, but in this case you must commit the warrior to making the leap before rolling the dice to see how far he jumps. If he fails to make it all the way across, he falls through the gap." },
                    { 29, "Speed", "Sprint", "The warrior may triple his Movement rate when he runs or charges, rather than doubling it as normal." },
                    { 30, "Speed", "Acrobat", "The warrior is incredibly supple and agile. He may fall or jump from a height of up to 12\" without taking any damage if he passes a single Initiative test, and can re-roll failed Diving Charge rolls. He can still only make a diving charge from a height of up to 6\"." },
                    { 31, "Speed", "Lightning Reflexes", "If the warrior is charged he will ‘strike first’ against those that charged that turn. As the charger(s) will also normally ‘strike first’ (for charging), the order of attack between the charger(s) and the warrior with this skill will be determined by comparing Initiative values." },
                    { 32, "Speed", "Jump Up", "The warrior can regain his footing in an instant, springing to his feet immediately if he is knocked down. The warrior may ignore knocked down results when rolling for injuries, unless he is knocked down because of a successful save from wearing a helmet or because he has the No Pain special rule." },
                    { 33, "Speed", "Dodge", "A warrior with this skill is nimble and as fast as quicksilver. He can avoid any hits from a missile weapon on a D6 roll of 5+. Note that this roll is taken against missiles as soon as a hit is scored to see whether the warrior dodges it or not, before rolling to wound, and before any effects from other skills or equipment (such as lucky charms)." },
                    { 34, "Speed", "Scale Sheer Surfaces", "A warrior with this skill can scale even the highest wall or fence with ease. He can climb up or down a height equal to twice his normal Movement, and does not need to make Initiative tests when doing so." }
                });

            migrationBuilder.InsertData(
                table: "Unit",
                columns: new[] { "Id", "AcademicSkill", "Attacks", "BSkill", "CombatSkill", "Cost", "CostNotes", "FactionId", "HiredSword", "Initiative", "LeaderShip", "MaxAttacks", "MaxBSkill", "MaxGroupSize", "MaxInitiative", "MaxLeaderShip", "MaxMovement", "MaxStrength", "MaxToughness", "MaxWSkill", "MaxWounds", "Movement", "Name", "ShootingSkill", "SpeedSkill", "StartingExp", "Strength", "StrengthSkill", "Toughness", "UnitLimit", "WSkill", "Wounds" },
                values: new object[] { 1, true, 1, 4, true, 60, 0, 1, false, 4, 8, 4, 6, 1, 6, 9, 4, 4, 4, 6, 3, 4, "Captain", true, true, 20, 3, true, 3, 1, 4, 1 });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Joined", "Mail", "Name", "Pass", "PrivateUser" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 22, 13, 9, 45, 105, DateTimeKind.Utc).AddTicks(5115), "testmail1.com", "Test User 1", "Non-hashed-password1", false },
                    { 2, new DateTime(2023, 3, 22, 13, 9, 45, 105, DateTimeKind.Utc).AddTicks(5117), "testmail2.com", "Test User 2", "Non-hashed-password2", false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Faction");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "Unit");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
