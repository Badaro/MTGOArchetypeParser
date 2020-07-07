using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_07
{
    public class Deck31_MegaMollt_GiftsStorm_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Baral, Chief of Compliance"),
            new SampleCard(3, "Goblin Electromancer"),
            new SampleCard(2, "Grapeshot"),
            new SampleCard(2, "Past in Flames"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(3, "Sleight of Hand"),
            new SampleCard(4, "Desperate Ritual"),
            new SampleCard(4, "Gifts Ungiven"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Pyretic Ritual"),
            new SampleCard(3, "Remand"),
            new SampleCard(1, "Repeal"),
            new SampleCard(1, "Fiery Islet"),
            new SampleCard(2, "Island"),
            new SampleCard(1, "Mountain"),
            new SampleCard(4, "Shivan Reef"),
            new SampleCard(2, "Snow-Covered Island"),
            new SampleCard(4, "Spirebluff Canal"),
            new SampleCard(4, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Abrade"),
            new SampleCard(3, "Aria of Flame"),
            new SampleCard(1, "Dismember"),
            new SampleCard(1, "Empty the Warrens"),
            new SampleCard(3, "Lightning Bolt"),
            new SampleCard(3, "Mystical Dispute"),
            new SampleCard(2, "Pieces of the Puzzle"),
            new SampleCard(1, "Shenanigans") 
        };
    }
}