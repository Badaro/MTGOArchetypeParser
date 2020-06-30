using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_05
{
    public class Deck07_Cherryxman_Uroza_WUG_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Emry, Lurker of the Loch"),
            new SampleCard(4, "Gilded Goose"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(4, "Thraben Inspector"),
            new SampleCard(2, "Trinket Mage"),
            new SampleCard(4, "Uro, Titan of Nature's Wrath"),
            new SampleCard(4, "Urza, Lord High Artificer"),
            new SampleCard(4, "Cryptic Command"),
            new SampleCard(4, "Metallic Rebuke"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(3, "Mystic Sanctuary"),
            new SampleCard(4, "Prismatic Vista"),
            new SampleCard(1, "Scalding Tarn"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(5, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(1, "Temple Garden") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Aether Gust"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(3, "Disdainful Stroke"),
            new SampleCard(3, "Dispel"),
            new SampleCard(1, "Soul-Guide Lantern"),
            new SampleCard(1, "Tormod's Crypt"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}