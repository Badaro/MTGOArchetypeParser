using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_05
{
    public class Deck08_hugofreitas1_GiftsStorm_URG : ISampleDeck
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
            new SampleCard(4, "Gifts Ungiven"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(2, "Opt"),
            new SampleCard(4, "Pyretic Ritual"),
            new SampleCard(3, "Remand"),
            new SampleCard(1, "Repeal"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(2, "Flooded Strand"),
            new SampleCard(1, "Island"),
            new SampleCard(1, "Mountain"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(1, "Snow-Covered Island"),
            new SampleCard(4, "Spirebluff Canal"),
            new SampleCard(3, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Pieces of the Puzzle"),
            new SampleCard(2, "Aria of Flame"),
            new SampleCard(2, "Empty the Warrens"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Shattering Spree"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}