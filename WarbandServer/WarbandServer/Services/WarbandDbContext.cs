using Microsoft.EntityFrameworkCore;
using WarbandServer.Models.Common;
using WarbandServer.Models.User;

namespace WarbandServer.Services
{
    public class WarbandContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<Unit> Unit { get; set; }
        public DbSet<Faction> Faction { get; set; }
        public DbSet<Skill> Skills { get; set; }
       
        public WarbandContext(DbContextOptions<WarbandContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Dummy data
            string hashedPassword = PasswordHasher.HashPassword("Hashed-password");
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Test User 1", Pass = "Non-hashed-password", Mail = "testmail1.com" },
                new User { Id = 2, Name = "Test User 2", Pass = hashedPassword, Mail = "testmail2.com" }
                );

            modelBuilder.Entity<Faction>().HasData(
                new Faction { Id = 1, Name = "Reikland", Legality = "A1", StartingGold = 500, MinimumWarriors = 3, MaximumWarriors = 15, 
                    SpecialRule = @"Reikland Mercenaries are accustomed to the demands of military discipline and have a strongly developed loyalty between officers and men. 
                        To represent this, fighters may use their Captain’s Leadership if within 12"" rather than the usual 6"". A strong tradition of martial training is 
                        also responsible for the high standards of archery amongst the people of Reikland. All Marksmen therefore add +1 to their Ballistic Skill, 
                        whether they are recruited when the warband is first formed or added later.", 
                    Description = @"Reikland lies at the heart of the Empire and its greatest city is Altdorf, home of the Grand Theogonist and seat of the Temple of Sigmar. 
                        Reiklanders are devout followers of Sigmar, the founder, first Emperor, and patron god of the Empire. The Grand Prince of Reikland 
                        (as Siegfried, the ruler of Reikland, styles himself) is supported in his claim to the throne by the Grand Theogonist and opposed most strongly 
                        by the Count of Middenheim and the Priests of Ulric. Throughout the Empire Reiklanders are commonly supposed to embody the discipline and loyalty of 
                        the professional warrior. Brave and well-versed in the arts of war, Reiklanders disdain fashionable clothing in favour of well-made and practical wargear. 
                        In battle they often wear coloured ribbons as marks of identification or authority. They are justly proud of their dynamic and ambitious Grand Prince 
                        and contemptuous of other claimants to the throne, especially the Count of Middenheim, Mannfred Todbringer, whom they sneeringly call the ‘lap-dog of Ulric’." },
                new Faction { Id = 2, Name = "Middenheim", Legality = "A1", StartingGold = 500, MinimumWarriors = 3, MaximumWarriors = 15,
                    SpecialRule = @"The men of Middenheim are famous for their physical prowess. To represent their advantage in size and bulk, the Champions and Captains of a 
                        Middenheim warband start with Strength 4 instead of Strength 3.",
                    Description = @"Middenheim stands on a mountain pinnacle surrounded by dark forest in the centre of Middenland, and is also known as the City of the White Wolf 
                        after Ulric, the old god of wolves and winter. The Priesthood of Ulric is still strong in Middenheim where Ulric is venerated as the patron of the city. 
                        The tradition of rivalry between Middenheim and Reikland goes back hundreds of years, and the Count of Middenheim, Mannfred Todbringer, is one of the 
                        chief contenders for the Emperor’s throne. As a result there has always been a great deal of friction between Middenheimers and the Temple of Sigmar.\n
                        Middenheimers are typically large, strongly built men with a well deserved reputation for ferocity. Many wear wolf pelts which custom decrees to be the 
                        mark of those who have slain a wolf with their own hands. These grim warriors are famously contemptuous of danger. They frequently go into battle bare-headed, 
                        scoffing at those who choose, for reasons of good sense, to wear helmets. As Middenheimers favour long hair and beards their lack of headgear makes them 
                        look especially fierce when they charge upon their enemies howling their brutal battle-cries. "}
                ); ;


            modelBuilder.Entity<Skill>().HasData(
                new Skill { Id = 1, SkillName = "Strike to Injure", SkillCategory = "Combat", SkillRule = "The warrior can land his blows with uncanny accuracy. Add +1 to all injury rolls caused by the model in hand-to-hand combat." },
                new Skill { Id = 2, SkillName = "Combat Master", SkillCategory = "Combat", SkillRule = "The warrior is able to take on several opponents at once. If he fights against more than one enemy at a time, he gains an extra Attack in each hand-to-hand combat phase as long as he is fighting two or more enemy models. In addition, the warrior is immune to ‘All Alone’ tests.." },
                new Skill { Id = 3, SkillName = "Weapons Training", SkillCategory = "Combat", SkillRule = "A warrior with this skill is adept at using many different weapons. He may use any hand-to-hand combat weapon he comes across, not just those in his equipment options." },
                new Skill { Id = 4, SkillName = "Web of Steel", SkillCategory = "Combat", SkillRule = " Few can match the ability of this warrior. He fights with great skill, weaving a web of steel around him. The model gains +1 to all his rolls on Critical Hit tables in hand-to-hand combat." },
                new Skill { Id = 5, SkillName = "Expert Swordsman", SkillCategory = "Combat", SkillRule = "This warrior has been expertly taught in the art of swordsmanship. He may re-roll all missed attacks if he is using a sword in the hand-tohand phase of the turn that he charges. Note that this only applies when they are armed with normal swords or weeping blades, and not with doublehanded swords or any other weapons. " },
                new Skill { Id = 6, SkillName = "Step Aside", SkillCategory = "Combat", SkillRule = "The warrior has a natural ability to avoid injury in combat. Each time he suffers a wound in close combat he may make an additional saving throw of 5+. This save is never modified and is taken after all other armour saves." },

                new Skill { Id = 7,  SkillName = "Quick Shot", SkillCategory = "Shooting", SkillRule = "The warrior may shoot twice per turn with a bow or crossbow (but not a crossbow pistol)." },
                new Skill { Id = 8,  SkillName = "Pistolier", SkillCategory = "Shooting", SkillRule = "The warrior is an expert at using all kinds of pistols. If he is equipped with a brace of pistols of any type (including crossbow pistols), he may fire twice in the Shooting phase (though note that normal reloading rules apply). If he has a single pistol then he may fire it in the same turn it was reloaded. " },
                new Skill { Id = 9,  SkillName = "Eagle Eyes", SkillCategory = "Shooting", SkillRule = "The warrior’s sight is exceptionally keen. He adds +6\" to the range of any missile weapon he is using." },
                new Skill { Id = 10, SkillName = "Weapons Expert", SkillCategory = "Shooting", SkillRule = "The warrior has been trained to use some of the more unusual weapons of the known world. He may use any missile weapon he comes across, not just the weapons available from his warband’s list." },
                new Skill { Id = 11, SkillName = "Nimble", SkillCategory = "Shooting", SkillRule = "The warrior may move and fire with weapons that are normally only used if the firer has not moved. Note that this skill cannot be combined with the Quick Shot skill" },
                new Skill { Id = 12, SkillName = "Trick Shooter", SkillCategory = "Shooting", SkillRule = "The warrior can shoot through the tiniest gap without it affecting his aim. He ignores all modifiers for cover when using missile weapons." },
                new Skill { Id = 13, SkillName = "Hunter", SkillCategory = "Academic", SkillRule = "The warrior is an expert at getting his weapon loaded and ready. He may fire each turn with a handgun or Hochland long rifle." },
                new Skill { Id = 14, SkillName = "Knife-Fighter", SkillCategory = "Academic", SkillRule = "The warrior is an unrivalled expert at using throwing knives and throwing stars. He can throw a maximum of three of these missiles in his shooting phase and may divide his shots between any targets within range as he wishes. Note that this skill cannot be combined with the Quick Shot skill." },

                new Skill { Id = 15, SkillName = "Battle Tongue", SkillCategory = "Academic", SkillRule = "This skill may only be chosen by a leader. The warrior has drilled his warband to follow short barked commands. This increases the range of his Leader ability by 6\". Note that Undead leaders may not use this skill." },
                new Skill { Id = 16, SkillName = "Sorcery", SkillCategory = "Academic", SkillRule = "This skill may only be taken by Heroes capable of casting spells. A warrior with this skill gains +1 to his rolls to see whether he can cast spells successfully or not. Note that Sisters of Sigmar and Warrior-Priests may not use this skill." },
                new Skill { Id = 17, SkillName = "Streetwise", SkillCategory = "Academic", SkillRule = "A warrior with this skill has good contacts and knows where to purchase rare items. He may add +2 to the roll that determines his chances of finding such items (see the Trading section)." },
                new Skill { Id = 18, SkillName = "Haggle", SkillCategory = "Academic", SkillRule = "The warrior knows all the tricks of bargaining and haggling. He may deduct 2D6 gold crowns from the price of any single item (to a minimum cost of 1gc) once per post battle sequence." },
                new Skill { Id = 19, SkillName = "Arcane Lore", SkillCategory = "Academic", SkillRule = "Witch Hunters, Sisters of Sigmar and Warrior-Priests may not have this skill. Any warrior with this skill may learn Lesser Magic if he owns a Tome of Magic." },
                new Skill { Id = 20, SkillName = "Wyrdstone Hunter", SkillCategory = "Academic", SkillRule = "The warrior has an uncanny ability to find hidden shards of wyrdstone. If a Hero with this skill is searching the ruins in the exploration phase you may re-roll one dice when rolling on the Exploration chart. The second result stands." },
                new Skill { Id = 21, SkillName = "Warrior Wizard", SkillCategory = "Academic", SkillRule = "This skill may only be taken by spellcasters. The mental powers of the wizard allow him to wear armour and cast spells." },

                new Skill { Id = 22, SkillName = "Mighty Blow", SkillCategory = "Strength", SkillRule = "The warrior knows how to use his strength to maximum effect and has a +1 Strength bonus in close combat (excluding pistols). As his Strength is used for close combat weapons, the bonus applies to all such weapons." },
                new Skill { Id = 23, SkillName = "Pit Fighter", SkillCategory = "Strength", SkillRule = "The warrior has learned how to fight in enclosed spaces from his time in the dangerous fighting pits of the Empire. He is an expert at fighting in confined areas and adds +1 to his WS and +1 to his Attacks if he is fighting inside buildings or ruins. It’s a good idea to define which bits of your terrain collection count as ‘buildings or ruins’ at the start of a battle to avoid confusion later. " },
                new Skill { Id = 24, SkillName = "Resilient", SkillCategory = "Strength", SkillRule = "The warrior is covered in battle scars. Deduct -1 Strength from all hits against him in close combat. This does not affect armour save modifiers." },
                new Skill { Id = 25, SkillName = "Fearsome", SkillCategory = "Strength", SkillRule = "Such is the reputation and physique of the model that he causes fear in opposing models." },
                new Skill { Id = 26, SkillName = "Strongman", SkillCategory = "Strength", SkillRule = "The warrior is capable of great feats of strength. He may use a double-handed weapon without the usual penalty of always striking last. Work out order of battle as you would with other weapons" },
                new Skill { Id = 27, SkillName = "Unstoppable Charge", SkillCategory = "Strength", SkillRule = "When he charges, the warrior is almost impossible to halt. He adds +1 to his Weapon Skill when charging." },

                new Skill { Id = 28, SkillName = "Leap", SkillCategory = "Speed", SkillRule = "The warrior may leap D6\" in the movement phase in addition to his normal movement. He may move and leap, run and leap, or charge and leap, but he can only leap once per turn. A leaping warrior may jump over opposing man-sized models, including enemies, and obstacles 1\" high, without penalty. The leap may also be used to leap over gaps, but in this case you must commit the warrior to making the leap before rolling the dice to see how far he jumps. If he fails to make it all the way across, he falls through the gap." },
                new Skill { Id = 29, SkillName = "Sprint", SkillCategory = "Speed", SkillRule = "The warrior may triple his Movement rate when he runs or charges, rather than doubling it as normal." },
                new Skill { Id = 30, SkillName = "Acrobat", SkillCategory = "Speed", SkillRule = "The warrior is incredibly supple and agile. He may fall or jump from a height of up to 12\" without taking any damage if he passes a single Initiative test, and can re-roll failed Diving Charge rolls. He can still only make a diving charge from a height of up to 6\"." },
                new Skill { Id = 31, SkillName = "Lightning Reflexes", SkillCategory = "Speed", SkillRule = "If the warrior is charged he will ‘strike first’ against those that charged that turn. As the charger(s) will also normally ‘strike first’ (for charging), the order of attack between the charger(s) and the warrior with this skill will be determined by comparing Initiative values." },
                new Skill { Id = 32, SkillName = "Jump Up", SkillCategory = "Speed", SkillRule = "The warrior can regain his footing in an instant, springing to his feet immediately if he is knocked down. The warrior may ignore knocked down results when rolling for injuries, unless he is knocked down because of a successful save from wearing a helmet or because he has the No Pain special rule." },
                new Skill { Id = 33, SkillName = "Dodge", SkillCategory = "Speed", SkillRule = "A warrior with this skill is nimble and as fast as quicksilver. He can avoid any hits from a missile weapon on a D6 roll of 5+. Note that this roll is taken against missiles as soon as a hit is scored to see whether the warrior dodges it or not, before rolling to wound, and before any effects from other skills or equipment (such as lucky charms)." },
                new Skill { Id = 34, SkillName = "Scale Sheer Surfaces", SkillCategory = "Speed", SkillRule = "A warrior with this skill can scale even the highest wall or fence with ease. He can climb up or down a height equal to twice his normal Movement, and does not need to make Initiative tests when doing so." }
                );


            modelBuilder.Entity<Unit>().HasData(
                new Unit { 
                    Id = 1, 
                    FactionId = 1, 
                    Name = "Captain", 
                    StartingExp = 20,
                    CombatSkill = true,
                    ShootingSkill = true,
                    AcademicSkill = true,
                    StrengthSkill = true,
                    SpeedSkill = true,
                    Cost = 60,
                    MaxGroupSize = 1,
                    UnitLimit = 1,
                    HiredSword = false,
                    Movement = 4,
                    WSkill = 4,
                    BSkill = 4,
                    Strength = 3,
                    Toughness = 3,
                    Wounds = 1,
                    Initiative = 4,
                    Attacks = 1,
                    LeaderShip = 8,
                    MaxMovement = 4,
                    MaxWSkill = 6,
                    MaxBSkill = 6,
                    MaxStrength = 4,
                    MaxToughness = 4,
                    MaxWounds = 3,
                    MaxInitiative = 6,
                    MaxAttacks = 4,
                    MaxLeaderShip = 9});;
            
        }
    }
}
