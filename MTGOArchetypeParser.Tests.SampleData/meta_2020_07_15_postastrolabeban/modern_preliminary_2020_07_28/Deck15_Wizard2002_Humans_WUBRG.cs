using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_28
{
    public class Deck15_Wizard2002_Humans_WUBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Champion of the Parish"),
            new SampleCard(2, "Deputy of Detention"),
            new SampleCard(2, "General Kudro of Drannith"),
            new SampleCard(1, "Kessig Malcontents"),
            new SampleCard(2, "Kitesail Freebooter"),
            new SampleCard(4, "Mantis Rider"),
            new SampleCard(4, "Meddling Mage"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(4, "Phantasmal Image"),
            new SampleCard(4, "Reflector Mage"),
            new SampleCard(3, "Thalia, Guardian of Thraben"),
            new SampleCard(4, "Thalia's Lieutenant"),
            new SampleCard(3, "Aether Vial"),
            new SampleCard(4, "Ancient Ziggurat"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(3, "Horizon Canopy"),
            new SampleCard(1, "Island"),
            new SampleCard(1, "Plains"),
            new SampleCard(4, "Unclaimed Territory"),
            new SampleCard(2, "Waterlogged Grove") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Deputy of Detention"),
            new SampleCard(4, "Auriok Champion"),
            new SampleCard(2, "Collector Ouphe"),
            new SampleCard(2, "Dismember"),
            new SampleCard(1, "Gaddock Teeg"),
            new SampleCard(1, "Kambal, Consul of Allocation"),
            new SampleCard(2, "Militia Bugler"),
            new SampleCard(2, "Plague Engineer") 
        };
    }
}