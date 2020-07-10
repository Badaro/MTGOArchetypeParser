using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10
{
    public class Deck34_Loreington_GiftsStorm_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Baral, Chief of Compliance"),
            new SampleCard(3, "Goblin Electromancer"),
            new SampleCard(2, "Grapeshot"),
            new SampleCard(2, "Past in Flames"),
            new SampleCard(1, "Pieces of the Puzzle"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(4, "Sleight of Hand"),
            new SampleCard(4, "Desperate Ritual"),
            new SampleCard(1, "Echoing Truth"),
            new SampleCard(4, "Gifts Ungiven"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(1, "Peer Through Depths"),
            new SampleCard(4, "Pyretic Ritual"),
            new SampleCard(3, "Remand"),
            new SampleCard(1, "Repeal"),
            new SampleCard(4, "Island"),
            new SampleCard(2, "Mountain"),
            new SampleCard(4, "Shivan Reef"),
            new SampleCard(4, "Spirebluff Canal"),
            new SampleCard(4, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Pieces of the Puzzle"),
            new SampleCard(1, "Abrade"),
            new SampleCard(2, "Aria of Flame"),
            new SampleCard(3, "Empty the Warrens"),
            new SampleCard(1, "Ignite Memories"),
            new SampleCard(3, "Lightning Bolt"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(1, "Shenanigans") 
        };
    }
}