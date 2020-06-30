using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_19
{
    public class Deck14_erose199423_ThopterUrza_WUR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Emry, Lurker of the Loch"),
            new SampleCard(2, "Goblin Engineer"),
            new SampleCard(4, "Urza, Lord High Artificer"),
            new SampleCard(2, "Archmage's Charm"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(2, "Metallic Rebuke"),
            new SampleCard(2, "Whir of Invention"),
            new SampleCard(1, "Aether Spellbomb"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(2, "Engineered Explosives"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(1, "Mox Amber"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(1, "Pyrite Spellbomb"),
            new SampleCard(1, "Soul-Guide Lantern"),
            new SampleCard(2, "Sword of the Meek"),
            new SampleCard(3, "Thopter Foundry"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(1, "Inventors' Fair"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "Prairie Stream"),
            new SampleCard(6, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(1, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(2, "Galvanic Blast"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(2, "Timely Reinforcements"),
            new SampleCard(1, "Wear // Tear") 
        };
    }
}