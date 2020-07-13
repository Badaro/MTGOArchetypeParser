using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_preliminary_2020_06_19
{
    public class Deck15_rn17_ThopterUrza_UBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Emry, Lurker of the Loch"),
            new SampleCard(4, "Goblin Engineer"),
            new SampleCard(4, "Urza, Lord High Artificer"),
            new SampleCard(2, "Whir of Invention"),
            new SampleCard(1, "Aether Spellbomb"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(2, "Engineered Explosives"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(2, "Mox Amber"),
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(2, "Pentad Prism"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(2, "Sword of the Meek"),
            new SampleCard(4, "Thopter Foundry"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Inventors' Fair"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(8, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Sunken Hollow"),
            new SampleCard(1, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(1, "Collective Brutality"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(2, "Galvanic Blast"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(1, "Tezzeret, Agent of Bolas"),
            new SampleCard(3, "Thoughtseize") 
        };
    }
}