using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_11
{
    public class Deck18_MRZ_Rock_Sultai_UBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(3, "Liliana of the Veil"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(1, "Tireless Tracker"),
            new SampleCard(4, "Uro, Titan of Nature's Wrath"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(1, "Maelstrom Pulse"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(2, "Assassin's Trophy"),
            new SampleCard(2, "Drown in the Loch"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(1, "Pulse of Murasa"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(2, "Creeping Tar Pit"),
            new SampleCard(1, "Forest"),
            new SampleCard(2, "Island"),
            new SampleCard(2, "Misty Rainforest"),
            new SampleCard(1, "Nurturing Peatland"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(2, "Swamp"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(1, "Waterlogged Grove"),
            new SampleCard(2, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(3, "Ashiok, Dream Render"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(1, "Damnation"),
            new SampleCard(3, "Fulminator Mage"),
            new SampleCard(2, "Nihil Spellbomb") 
        };
    }
}