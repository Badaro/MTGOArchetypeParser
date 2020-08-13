using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_04
{
    public class Deck50_erose199423_Crabvine_UBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Bloodghast"),
            new SampleCard(3, "Carrion Feeder"),
            new SampleCard(4, "Gravecrawler"),
            new SampleCard(4, "Hedron Crab"),
            new SampleCard(3, "Narcomoeba"),
            new SampleCard(4, "Prized Amalgam"),
            new SampleCard(4, "Satyr Wayfinder"),
            new SampleCard(4, "Stitcher's Supplier"),
            new SampleCard(4, "Vengevine"),
            new SampleCard(3, "Collective Brutality"),
            new SampleCard(3, "Glimpse the Unthinkable"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(1, "Gemstone Caverns"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(2, "Swamp"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(3, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Abrupt Decay"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(3, "Leyline of the Void"),
            new SampleCard(2, "Nature's Claim"),
            new SampleCard(3, "Thoughtseize") 
        };
    }
}