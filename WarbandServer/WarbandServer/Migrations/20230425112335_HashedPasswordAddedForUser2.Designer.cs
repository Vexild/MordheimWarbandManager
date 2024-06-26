﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WarbandServer.Services;

#nullable disable

namespace WarbandServer.Migrations
{
    [DbContext(typeof(WarbandContext))]
    [Migration("20230425112335_HashedPasswordAddedForUser2")]
    partial class HashedPasswordAddedForUser2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WarbandServer.Models.Common.Faction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Legality")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)");

                    b.Property<int>("MaximumWarriors")
                        .HasColumnType("integer");

                    b.Property<int>("MinimumWarriors")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)");

                    b.Property<string>("SpecialRule")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("character varying(600)");

                    b.Property<int>("StartingGold")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Faction");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Reikland lies at the heart of the Empire and its greatest city is Altdorf, home of the Grand Theogonist and seat of the Temple of Sigmar. \r\n                        Reiklanders are devout followers of Sigmar, the founder, first Emperor, and patron god of the Empire. The Grand Prince of Reikland \r\n                        (as Siegfried, the ruler of Reikland, styles himself) is supported in his claim to the throne by the Grand Theogonist and opposed most strongly \r\n                        by the Count of Middenheim and the Priests of Ulric. Throughout the Empire Reiklanders are commonly supposed to embody the discipline and loyalty of \r\n                        the professional warrior. Brave and well-versed in the arts of war, Reiklanders disdain fashionable clothing in favour of well-made and practical wargear. \r\n                        In battle they often wear coloured ribbons as marks of identification or authority. They are justly proud of their dynamic and ambitious Grand Prince \r\n                        and contemptuous of other claimants to the throne, especially the Count of Middenheim, Mannfred Todbringer, whom they sneeringly call the ‘lap-dog of Ulric’.",
                            Legality = "A1",
                            MaximumWarriors = 15,
                            MinimumWarriors = 3,
                            Name = "Reikland",
                            SpecialRule = "Reikland Mercenaries are accustomed to the demands of military discipline and have a strongly developed loyalty between officers and men. \r\n                        To represent this, fighters may use their Captain’s Leadership if within 12\" rather than the usual 6\". A strong tradition of martial training is \r\n                        also responsible for the high standards of archery amongst the people of Reikland. All Marksmen therefore add +1 to their Ballistic Skill, \r\n                        whether they are recruited when the warband is first formed or added later.",
                            StartingGold = 500
                        },
                        new
                        {
                            Id = 2,
                            Description = "Middenheim stands on a mountain pinnacle surrounded by dark forest in the centre of Middenland, and is also known as the City of the White Wolf \r\n                        after Ulric, the old god of wolves and winter. The Priesthood of Ulric is still strong in Middenheim where Ulric is venerated as the patron of the city. \r\n                        The tradition of rivalry between Middenheim and Reikland goes back hundreds of years, and the Count of Middenheim, Mannfred Todbringer, is one of the \r\n                        chief contenders for the Emperor’s throne. As a result there has always been a great deal of friction between Middenheimers and the Temple of Sigmar.\\n\r\n                        Middenheimers are typically large, strongly built men with a well deserved reputation for ferocity. Many wear wolf pelts which custom decrees to be the \r\n                        mark of those who have slain a wolf with their own hands. These grim warriors are famously contemptuous of danger. They frequently go into battle bare-headed, \r\n                        scoffing at those who choose, for reasons of good sense, to wear helmets. As Middenheimers favour long hair and beards their lack of headgear makes them \r\n                        look especially fierce when they charge upon their enemies howling their brutal battle-cries. ",
                            Legality = "A1",
                            MaximumWarriors = 15,
                            MinimumWarriors = 3,
                            Name = "Middenheim",
                            SpecialRule = "The men of Middenheim are famous for their physical prowess. To represent their advantage in size and bulk, the Champions and Captains of a \r\n                        Middenheim warband start with Strength 4 instead of Strength 3.",
                            StartingGold = 500
                        });
                });

            modelBuilder.Entity("WarbandServer.Models.Common.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("SkillCategory")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SkillName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SkillRule")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Skill");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            SkillCategory = "Combat",
                            SkillName = "Strike to Injure",
                            SkillRule = "The warrior can land his blows with uncanny accuracy. Add +1 to all injury rolls caused by the model in hand-to-hand combat."
                        },
                        new
                        {
                            Id = 2,
                            SkillCategory = "Combat",
                            SkillName = "Combat Master",
                            SkillRule = "The warrior is able to take on several opponents at once. If he fights against more than one enemy at a time, he gains an extra Attack in each hand-to-hand combat phase as long as he is fighting two or more enemy models. In addition, the warrior is immune to ‘All Alone’ tests.."
                        },
                        new
                        {
                            Id = 3,
                            SkillCategory = "Combat",
                            SkillName = "Weapons Training",
                            SkillRule = "A warrior with this skill is adept at using many different weapons. He may use any hand-to-hand combat weapon he comes across, not just those in his equipment options."
                        },
                        new
                        {
                            Id = 4,
                            SkillCategory = "Combat",
                            SkillName = "Web of Steel",
                            SkillRule = " Few can match the ability of this warrior. He fights with great skill, weaving a web of steel around him. The model gains +1 to all his rolls on Critical Hit tables in hand-to-hand combat."
                        },
                        new
                        {
                            Id = 5,
                            SkillCategory = "Combat",
                            SkillName = "Expert Swordsman",
                            SkillRule = "This warrior has been expertly taught in the art of swordsmanship. He may re-roll all missed attacks if he is using a sword in the hand-tohand phase of the turn that he charges. Note that this only applies when they are armed with normal swords or weeping blades, and not with doublehanded swords or any other weapons. "
                        },
                        new
                        {
                            Id = 6,
                            SkillCategory = "Combat",
                            SkillName = "Step Aside",
                            SkillRule = "The warrior has a natural ability to avoid injury in combat. Each time he suffers a wound in close combat he may make an additional saving throw of 5+. This save is never modified and is taken after all other armour saves."
                        },
                        new
                        {
                            Id = 7,
                            SkillCategory = "Shooting",
                            SkillName = "Quick Shot",
                            SkillRule = "The warrior may shoot twice per turn with a bow or crossbow (but not a crossbow pistol)."
                        },
                        new
                        {
                            Id = 8,
                            SkillCategory = "Shooting",
                            SkillName = "Pistolier",
                            SkillRule = "The warrior is an expert at using all kinds of pistols. If he is equipped with a brace of pistols of any type (including crossbow pistols), he may fire twice in the Shooting phase (though note that normal reloading rules apply). If he has a single pistol then he may fire it in the same turn it was reloaded. "
                        },
                        new
                        {
                            Id = 9,
                            SkillCategory = "Shooting",
                            SkillName = "Eagle Eyes",
                            SkillRule = "The warrior’s sight is exceptionally keen. He adds +6\" to the range of any missile weapon he is using."
                        },
                        new
                        {
                            Id = 10,
                            SkillCategory = "Shooting",
                            SkillName = "Weapons Expert",
                            SkillRule = "The warrior has been trained to use some of the more unusual weapons of the known world. He may use any missile weapon he comes across, not just the weapons available from his warband’s list."
                        },
                        new
                        {
                            Id = 11,
                            SkillCategory = "Shooting",
                            SkillName = "Nimble",
                            SkillRule = "The warrior may move and fire with weapons that are normally only used if the firer has not moved. Note that this skill cannot be combined with the Quick Shot skill"
                        },
                        new
                        {
                            Id = 12,
                            SkillCategory = "Shooting",
                            SkillName = "Trick Shooter",
                            SkillRule = "The warrior can shoot through the tiniest gap without it affecting his aim. He ignores all modifiers for cover when using missile weapons."
                        },
                        new
                        {
                            Id = 13,
                            SkillCategory = "Academic",
                            SkillName = "Hunter",
                            SkillRule = "The warrior is an expert at getting his weapon loaded and ready. He may fire each turn with a handgun or Hochland long rifle."
                        },
                        new
                        {
                            Id = 14,
                            SkillCategory = "Academic",
                            SkillName = "Knife-Fighter",
                            SkillRule = "The warrior is an unrivalled expert at using throwing knives and throwing stars. He can throw a maximum of three of these missiles in his shooting phase and may divide his shots between any targets within range as he wishes. Note that this skill cannot be combined with the Quick Shot skill."
                        },
                        new
                        {
                            Id = 15,
                            SkillCategory = "Academic",
                            SkillName = "Battle Tongue",
                            SkillRule = "This skill may only be chosen by a leader. The warrior has drilled his warband to follow short barked commands. This increases the range of his Leader ability by 6\". Note that Undead leaders may not use this skill."
                        },
                        new
                        {
                            Id = 16,
                            SkillCategory = "Academic",
                            SkillName = "Sorcery",
                            SkillRule = "This skill may only be taken by Heroes capable of casting spells. A warrior with this skill gains +1 to his rolls to see whether he can cast spells successfully or not. Note that Sisters of Sigmar and Warrior-Priests may not use this skill."
                        },
                        new
                        {
                            Id = 17,
                            SkillCategory = "Academic",
                            SkillName = "Streetwise",
                            SkillRule = "A warrior with this skill has good contacts and knows where to purchase rare items. He may add +2 to the roll that determines his chances of finding such items (see the Trading section)."
                        },
                        new
                        {
                            Id = 18,
                            SkillCategory = "Academic",
                            SkillName = "Haggle",
                            SkillRule = "The warrior knows all the tricks of bargaining and haggling. He may deduct 2D6 gold crowns from the price of any single item (to a minimum cost of 1gc) once per post battle sequence."
                        },
                        new
                        {
                            Id = 19,
                            SkillCategory = "Academic",
                            SkillName = "Arcane Lore",
                            SkillRule = "Witch Hunters, Sisters of Sigmar and Warrior-Priests may not have this skill. Any warrior with this skill may learn Lesser Magic if he owns a Tome of Magic."
                        },
                        new
                        {
                            Id = 20,
                            SkillCategory = "Academic",
                            SkillName = "Wyrdstone Hunter",
                            SkillRule = "The warrior has an uncanny ability to find hidden shards of wyrdstone. If a Hero with this skill is searching the ruins in the exploration phase you may re-roll one dice when rolling on the Exploration chart. The second result stands."
                        },
                        new
                        {
                            Id = 21,
                            SkillCategory = "Academic",
                            SkillName = "Warrior Wizard",
                            SkillRule = "This skill may only be taken by spellcasters. The mental powers of the wizard allow him to wear armour and cast spells."
                        },
                        new
                        {
                            Id = 22,
                            SkillCategory = "Strength",
                            SkillName = "Mighty Blow",
                            SkillRule = "The warrior knows how to use his strength to maximum effect and has a +1 Strength bonus in close combat (excluding pistols). As his Strength is used for close combat weapons, the bonus applies to all such weapons."
                        },
                        new
                        {
                            Id = 23,
                            SkillCategory = "Strength",
                            SkillName = "Pit Fighter",
                            SkillRule = "The warrior has learned how to fight in enclosed spaces from his time in the dangerous fighting pits of the Empire. He is an expert at fighting in confined areas and adds +1 to his WS and +1 to his Attacks if he is fighting inside buildings or ruins. It’s a good idea to define which bits of your terrain collection count as ‘buildings or ruins’ at the start of a battle to avoid confusion later. "
                        },
                        new
                        {
                            Id = 24,
                            SkillCategory = "Strength",
                            SkillName = "Resilient",
                            SkillRule = "The warrior is covered in battle scars. Deduct -1 Strength from all hits against him in close combat. This does not affect armour save modifiers."
                        },
                        new
                        {
                            Id = 25,
                            SkillCategory = "Strength",
                            SkillName = "Fearsome",
                            SkillRule = "Such is the reputation and physique of the model that he causes fear in opposing models."
                        },
                        new
                        {
                            Id = 26,
                            SkillCategory = "Strength",
                            SkillName = "Strongman",
                            SkillRule = "The warrior is capable of great feats of strength. He may use a double-handed weapon without the usual penalty of always striking last. Work out order of battle as you would with other weapons"
                        },
                        new
                        {
                            Id = 27,
                            SkillCategory = "Strength",
                            SkillName = "Unstoppable Charge",
                            SkillRule = "When he charges, the warrior is almost impossible to halt. He adds +1 to his Weapon Skill when charging."
                        },
                        new
                        {
                            Id = 28,
                            SkillCategory = "Speed",
                            SkillName = "Leap",
                            SkillRule = "The warrior may leap D6\" in the movement phase in addition to his normal movement. He may move and leap, run and leap, or charge and leap, but he can only leap once per turn. A leaping warrior may jump over opposing man-sized models, including enemies, and obstacles 1\" high, without penalty. The leap may also be used to leap over gaps, but in this case you must commit the warrior to making the leap before rolling the dice to see how far he jumps. If he fails to make it all the way across, he falls through the gap."
                        },
                        new
                        {
                            Id = 29,
                            SkillCategory = "Speed",
                            SkillName = "Sprint",
                            SkillRule = "The warrior may triple his Movement rate when he runs or charges, rather than doubling it as normal."
                        },
                        new
                        {
                            Id = 30,
                            SkillCategory = "Speed",
                            SkillName = "Acrobat",
                            SkillRule = "The warrior is incredibly supple and agile. He may fall or jump from a height of up to 12\" without taking any damage if he passes a single Initiative test, and can re-roll failed Diving Charge rolls. He can still only make a diving charge from a height of up to 6\"."
                        },
                        new
                        {
                            Id = 31,
                            SkillCategory = "Speed",
                            SkillName = "Lightning Reflexes",
                            SkillRule = "If the warrior is charged he will ‘strike first’ against those that charged that turn. As the charger(s) will also normally ‘strike first’ (for charging), the order of attack between the charger(s) and the warrior with this skill will be determined by comparing Initiative values."
                        },
                        new
                        {
                            Id = 32,
                            SkillCategory = "Speed",
                            SkillName = "Jump Up",
                            SkillRule = "The warrior can regain his footing in an instant, springing to his feet immediately if he is knocked down. The warrior may ignore knocked down results when rolling for injuries, unless he is knocked down because of a successful save from wearing a helmet or because he has the No Pain special rule."
                        },
                        new
                        {
                            Id = 33,
                            SkillCategory = "Speed",
                            SkillName = "Dodge",
                            SkillRule = "A warrior with this skill is nimble and as fast as quicksilver. He can avoid any hits from a missile weapon on a D6 roll of 5+. Note that this roll is taken against missiles as soon as a hit is scored to see whether the warrior dodges it or not, before rolling to wound, and before any effects from other skills or equipment (such as lucky charms)."
                        },
                        new
                        {
                            Id = 34,
                            SkillCategory = "Speed",
                            SkillName = "Scale Sheer Surfaces",
                            SkillRule = "A warrior with this skill can scale even the highest wall or fence with ease. He can climb up or down a height equal to twice his normal Movement, and does not need to make Initiative tests when doing so."
                        });
                });

            modelBuilder.Entity("WarbandServer.Models.Common.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("AcademicSkill")
                        .HasColumnType("boolean");

                    b.Property<int>("Attacks")
                        .HasColumnType("integer");

                    b.Property<int>("BSkill")
                        .HasColumnType("integer");

                    b.Property<bool>("CombatSkill")
                        .HasColumnType("boolean");

                    b.Property<int>("Cost")
                        .HasColumnType("integer");

                    b.Property<int>("CostNotes")
                        .HasColumnType("integer");

                    b.Property<int>("FactionId")
                        .HasColumnType("integer");

                    b.Property<bool>("HiredSword")
                        .HasColumnType("boolean");

                    b.Property<int>("Initiative")
                        .HasColumnType("integer");

                    b.Property<int>("LeaderShip")
                        .HasColumnType("integer");

                    b.Property<int>("MaxAttacks")
                        .HasColumnType("integer");

                    b.Property<int>("MaxBSkill")
                        .HasColumnType("integer");

                    b.Property<int>("MaxGroupSize")
                        .HasColumnType("integer");

                    b.Property<int>("MaxInitiative")
                        .HasColumnType("integer");

                    b.Property<int>("MaxLeaderShip")
                        .HasColumnType("integer");

                    b.Property<int>("MaxMovement")
                        .HasColumnType("integer");

                    b.Property<int>("MaxStrength")
                        .HasColumnType("integer");

                    b.Property<int>("MaxToughness")
                        .HasColumnType("integer");

                    b.Property<int>("MaxWSkill")
                        .HasColumnType("integer");

                    b.Property<int>("MaxWounds")
                        .HasColumnType("integer");

                    b.Property<int>("Movement")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("ShootingSkill")
                        .HasColumnType("boolean");

                    b.Property<bool>("SpeedSkill")
                        .HasColumnType("boolean");

                    b.Property<int>("StartingExp")
                        .HasColumnType("integer");

                    b.Property<int>("Strength")
                        .HasColumnType("integer");

                    b.Property<bool>("StrengthSkill")
                        .HasColumnType("boolean");

                    b.Property<int>("Toughness")
                        .HasColumnType("integer");

                    b.Property<int>("UnitLimit")
                        .HasColumnType("integer");

                    b.Property<int>("WSkill")
                        .HasColumnType("integer");

                    b.Property<int>("Wounds")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Unit");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AcademicSkill = true,
                            Attacks = 1,
                            BSkill = 4,
                            CombatSkill = true,
                            Cost = 60,
                            CostNotes = 0,
                            FactionId = 1,
                            HiredSword = false,
                            Initiative = 4,
                            LeaderShip = 8,
                            MaxAttacks = 4,
                            MaxBSkill = 6,
                            MaxGroupSize = 1,
                            MaxInitiative = 6,
                            MaxLeaderShip = 9,
                            MaxMovement = 4,
                            MaxStrength = 4,
                            MaxToughness = 4,
                            MaxWSkill = 6,
                            MaxWounds = 3,
                            Movement = 4,
                            Name = "Captain",
                            ShootingSkill = true,
                            SpeedSkill = true,
                            StartingExp = 20,
                            Strength = 3,
                            StrengthSkill = true,
                            Toughness = 3,
                            UnitLimit = 1,
                            WSkill = 4,
                            Wounds = 1
                        });
                });

            modelBuilder.Entity("WarbandServer.Models.User.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Joined")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Pass")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<bool>("PrivateUser")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Joined = new DateTime(2023, 4, 25, 11, 23, 35, 120, DateTimeKind.Utc).AddTicks(700),
                            Mail = "testmail1.com",
                            Name = "Test User 1",
                            Pass = "Non-hashed-password",
                            PrivateUser = false
                        },
                        new
                        {
                            Id = 2,
                            Joined = new DateTime(2023, 4, 25, 11, 23, 35, 120, DateTimeKind.Utc).AddTicks(705),
                            Mail = "testmail2.com",
                            Name = "Test User 2",
                            Pass = "$2a$11$fhkoRG.3v0tMpcomQwnbTOALS3UnLHtfWC106R1osaNZukK5LfLcK",
                            PrivateUser = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
