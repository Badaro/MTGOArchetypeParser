using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14
{
    public class Deck18_rafp_Humans_WUBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Champion of the Parish"),
            new SampleCard(4, "Kitesail Freebooter"),
            new SampleCard(4, "Mantis Rider"),
            new SampleCard(4, "Meddling Mage"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(4, "Phantasmal Image"),
            new SampleCard(4, "Reflector Mage"),
            new SampleCard(3, "Thalia, Guardian of Thraben"),
            new SampleCard(4, "Thalia's Lieutenant"),
            new SampleCard(2, "Unsettled Mariner"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Ancient Ziggurat"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(4, "Horizon Canopy"),
            new SampleCard(1, "Island"),
            new SampleCard(1, "Plains"),
            new SampleCard(4, "Unclaimed Territory"),
            new SampleCard(1, "Waterlogged Grove") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Auriok Champion"),
            new SampleCard(1, "Collector Ouphe"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(2, "Deputy of Detention"),
            new SampleCard(2, "Dismember"),
            new SampleCard(2, "Gaddock Teeg"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Plague Engineer"),
            new SampleCard(1, "Sin Collector") 
        };
    }
}