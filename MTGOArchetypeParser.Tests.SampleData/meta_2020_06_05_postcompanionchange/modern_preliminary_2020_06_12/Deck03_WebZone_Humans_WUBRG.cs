using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_preliminary_2020_06_12
{
    public class Deck03_WebZone_Humans_WUBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Champion of the Parish"),
            new SampleCard(3, "General Kudro of Drannith"),
            new SampleCard(3, "Kitesail Freebooter"),
            new SampleCard(4, "Mantis Rider"),
            new SampleCard(4, "Meddling Mage"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(3, "Phantasmal Image"),
            new SampleCard(4, "Reflector Mage"),
            new SampleCard(4, "Thalia, Guardian of Thraben"),
            new SampleCard(4, "Thalia's Lieutenant"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Ancient Ziggurat"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(4, "Horizon Canopy"),
            new SampleCard(1, "Island"),
            new SampleCard(1, "Plains"),
            new SampleCard(1, "Silent Clearing"),
            new SampleCard(3, "Unclaimed Territory"),
            new SampleCard(1, "Waterlogged Grove") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Auriok Champion"),
            new SampleCard(2, "Collector Ouphe"),
            new SampleCard(2, "Deputy of Detention"),
            new SampleCard(2, "Dismember"),
            new SampleCard(2, "Gaddock Teeg"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(2, "Selfless Spirit") 
        };
    }
}