using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_19
{
    public class Deck14_erose199423_ThopterUrza_WUR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Emry, Lurker of the Loch"),(2, "Goblin Engineer"),(4, "Urza, Lord High Artificer"),(2, "Archmage's Charm"),(2, "Cryptic Command"),(2, "Metallic Rebuke"),(2, "Whir of Invention"),(1, "Aether Spellbomb"),(4, "Arcum's Astrolabe"),(2, "Engineered Explosives"),(4, "Mishra's Bauble"),(1, "Mox Amber"),(1, "Pithing Needle"),(1, "Pyrite Spellbomb"),(1, "Soul-Guide Lantern"),(2, "Sword of the Meek"),(3, "Thopter Foundry"),(4, "Flooded Strand"),(1, "Hallowed Fountain"),(1, "Inventors' Fair"),(1, "Misty Rainforest"),(2, "Mystic Sanctuary"),(4, "Polluted Delta"),(1, "Prairie Stream"),(6, "Snow-Covered Island"),(1, "Snow-Covered Plains"),(1, "Steam Vents") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Aether Gust"),(2, "Ceremonious Rejection"),(1, "Damping Sphere"),(2, "Galvanic Blast"),(2, "Mystical Dispute"),(2, "Path to Exile"),(2, "Timely Reinforcements"),(1, "Wear // Tear") }; } }
    }
}