using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_04
{
    public class Deck20_FakeFrog_Humans_WUBRG : ISampleDeck
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
            new SampleCard(1, "Silent Clearing"),
            new SampleCard(1, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains"),
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
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(2, "Plague Engineer") 
        };
    }
}