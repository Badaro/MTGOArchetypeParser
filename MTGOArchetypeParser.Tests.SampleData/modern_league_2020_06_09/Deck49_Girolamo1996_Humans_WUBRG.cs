using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck49_Girolamo1996_Humans_WUBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Champion of the Parish"),
            new SampleCard(1, "Deputy of Detention"),
            new SampleCard(1, "Kessig Malcontents"),
            new SampleCard(4, "Kitesail Freebooter"),
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
            new SampleCard(4, "Horizon Canopy"),
            new SampleCard(1, "Island"),
            new SampleCard(1, "Plains"),
            new SampleCard(1, "Seachrome Coast"),
            new SampleCard(4, "Unclaimed Territory") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Deputy of Detention"),
            new SampleCard(2, "Auriok Champion"),
            new SampleCard(2, "Dismember"),
            new SampleCard(1, "Gaddock Teeg"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(1, "Izzet Staticaster"),
            new SampleCard(1, "Kambal, Consul of Allocation"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(2, "Mirran Crusader"),
            new SampleCard(2, "Sin Collector") 
        };
    }
}