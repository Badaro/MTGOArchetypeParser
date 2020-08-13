using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_07_23
{
    public class Deck19_grahams_Crabvine_UBRG : ISampleDeck
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
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(1, "City of Brass"),
            new SampleCard(1, "Darkslick Shores"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Verdant Catacombs"),
            new SampleCard(3, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Abrupt Decay"),
            new SampleCard(3, "Ancient Grudge"),
            new SampleCard(2, "Assassin's Trophy"),
            new SampleCard(3, "Collective Brutality"),
            new SampleCard(2, "Surgical Extraction"),
            new SampleCard(3, "Thoughtseize") 
        };
    }
}