using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_09
{
    public class Deck05_Teston_GiftsStorm_UR_Jegantha : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Baral, Chief of Compliance"),
            new SampleCard(4, "Goblin Electromancer"),
            new SampleCard(2, "Grapeshot"),
            new SampleCard(2, "Past in Flames"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(1, "Sleight of Hand"),
            new SampleCard(4, "Desperate Ritual"),
            new SampleCard(4, "Gifts Ungiven"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(4, "Opt"),
            new SampleCard(1, "Peer Through Depths"),
            new SampleCard(4, "Pyretic Ritual"),
            new SampleCard(3, "Remand"),
            new SampleCard(1, "Repeal"),
            new SampleCard(1, "Fiery Islet"),
            new SampleCard(1, "Island"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(1, "Polluted Delta"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(4, "Spirebluff Canal"),
            new SampleCard(3, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Abrade"),
            new SampleCard(2, "Aria of Flame"),
            new SampleCard(3, "Blood Moon"),
            new SampleCard(1, "Echoing Truth"),
            new SampleCard(2, "Empty the Warrens"),
            new SampleCard(1, "Jegantha, the Wellspring"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(2, "Pieces of the Puzzle"),
            new SampleCard(1, "Shattering Spree") 
        };
    }
}