using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_10
{
    public class Deck03_PanCementJP_Spirits_BantSpirits_WUG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Deputy of Detention"),
            new SampleCard(4, "Drogskol Captain"),
            new SampleCard(1, "Geist of Saint Traft"),
            new SampleCard(4, "Mausoleum Wanderer"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(1, "Phantasmal Image"),
            new SampleCard(3, "Rattlechains"),
            new SampleCard(2, "Selfless Spirit"),
            new SampleCard(4, "Spell Queller"),
            new SampleCard(4, "Supreme Phantom"),
            new SampleCard(4, "Collected Company"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(3, "Aether Vial"),
            new SampleCard(3, "Botanical Sanctum"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(3, "Flooded Strand"),
            new SampleCard(1, "Forest"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(2, "Horizon Canopy"),
            new SampleCard(1, "Island"),
            new SampleCard(1, "Moorland Haunt"),
            new SampleCard(1, "Plains"),
            new SampleCard(2, "Seachrome Coast"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(3, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Geist of Saint Traft"),
            new SampleCard(4, "Auriok Champion"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(1, "Thalia, Guardian of Thraben"),
            new SampleCard(3, "Unified Will") 
        };
    }
}