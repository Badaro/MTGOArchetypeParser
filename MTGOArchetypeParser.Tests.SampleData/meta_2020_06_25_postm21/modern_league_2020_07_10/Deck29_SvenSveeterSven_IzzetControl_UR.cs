using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_10
{
    public class Deck29_SvenSveeterSven_IzzetControl_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "The Royal Scions"),
            new SampleCard(2, "Bonecrusher Giant"),
            new SampleCard(4, "Brazen Borrower"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(4, "Archmage's Charm"),
            new SampleCard(1, "Electrolyze"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Remand"),
            new SampleCard(1, "Spell Pierce"),
            new SampleCard(2, "Spell Snare"),
            new SampleCard(2, "Cascade Bluffs"),
            new SampleCard(8, "Island"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Bonecrusher Giant"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(3, "Blood Moon"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(1, "Flame Sweep"),
            new SampleCard(2, "Flusterstorm"),
            new SampleCard(1, "Glimpse of Freedom"),
            new SampleCard(1, "Mindbreak Trap"),
            new SampleCard(2, "Surgical Extraction") 
        };
    }
}