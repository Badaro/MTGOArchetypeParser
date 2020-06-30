using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05
{
    public class Deck16_ilmatagatto_Humans_WUBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Champion of the Parish"),
            new SampleCard(2, "General Kudro of Drannith"),
            new SampleCard(1, "Kessig Malcontents"),
            new SampleCard(3, "Kitesail Freebooter"),
            new SampleCard(4, "Mantis Rider"),
            new SampleCard(4, "Meddling Mage"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(4, "Phantasmal Image"),
            new SampleCard(4, "Reflector Mage"),
            new SampleCard(3, "Thalia, Guardian of Thraben"),
            new SampleCard(4, "Thalia's Lieutenant"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Ancient Ziggurat"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(3, "Horizon Canopy"),
            new SampleCard(1, "Island"),
            new SampleCard(1, "Plains"),
            new SampleCard(1, "Silent Clearing"),
            new SampleCard(4, "Unclaimed Territory"),
            new SampleCard(1, "Waterlogged Grove") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Auriok Champion"),
            new SampleCard(2, "Collector Ouphe"),
            new SampleCard(2, "Deputy of Detention"),
            new SampleCard(1, "Dismember"),
            new SampleCard(1, "Gaddock Teeg"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(2, "Knight of Autumn"),
            new SampleCard(2, "Militia Bugler"),
            new SampleCard(1, "Mirran Crusader") 
        };
    }
}