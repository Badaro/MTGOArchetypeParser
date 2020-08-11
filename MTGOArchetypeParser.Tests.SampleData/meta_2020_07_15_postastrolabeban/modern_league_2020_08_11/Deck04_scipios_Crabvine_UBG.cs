using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_11
{
    public class Deck04_scipios_Crabvine_UBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Gravecrawler"),
            new SampleCard(4, "Hedron Crab"),
            new SampleCard(4, "Merfolk Secretkeeper"),
            new SampleCard(3, "Narcomoeba"),
            new SampleCard(3, "Prized Amalgam"),
            new SampleCard(2, "Satyr Wayfinder"),
            new SampleCard(3, "Silversmote Ghoul"),
            new SampleCard(4, "Stitcher's Supplier"),
            new SampleCard(2, "Uro, Titan of Nature's Wrath"),
            new SampleCard(4, "Vengevine"),
            new SampleCard(4, "Creeping Chill"),
            new SampleCard(4, "Glimpse the Unthinkable"),
            new SampleCard(1, "Bloodstained Mire"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(1, "Island"),
            new SampleCard(2, "Misty Rainforest"),
            new SampleCard(3, "Overgrown Tomb"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "Swamp"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(2, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(3, "Force of Vigor"),
            new SampleCard(2, "Surgical Extraction"),
            new SampleCard(3, "Thoughtseize") 
        };
    }
}