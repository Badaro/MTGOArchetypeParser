using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_28
{
    public class Deck45_gabsr_Crabvine_UBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Gravecrawler"),
            new SampleCard(4, "Hedron Crab"),
            new SampleCard(4, "Merfolk Secretkeeper"),
            new SampleCard(4, "Narcomoeba"),
            new SampleCard(4, "Prized Amalgam"),
            new SampleCard(4, "Silversmote Ghoul"),
            new SampleCard(4, "Stitcher's Supplier"),
            new SampleCard(4, "Vengevine"),
            new SampleCard(4, "Creeping Chill"),
            new SampleCard(4, "Glimpse the Unthinkable"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(3, "Darkslick Shores"),
            new SampleCard(3, "Overgrown Tomb"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(2, "Swamp"),
            new SampleCard(3, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Abrupt Decay"),
            new SampleCard(3, "Ancient Grudge"),
            new SampleCard(2, "Assassin's Trophy"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(3, "Leyline of the Void") 
        };
    }
}