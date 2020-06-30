using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21
{
    public class Deck08_SvenSveeterSven_BlueMoon_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "The Royal Scions"),
            new SampleCard(2, "Bonecrusher Giant"),
            new SampleCard(2, "Brazen Borrower"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(3, "Thing in the Ice"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(1, "Glimpse of Freedom"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(3, "Opt"),
            new SampleCard(1, "Peek"),
            new SampleCard(4, "Remand"),
            new SampleCard(2, "Spell Snare"),
            new SampleCard(1, "Cascade Bluffs"),
            new SampleCard(8, "Island"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Steam Vents"),
            new SampleCard(1, "Sulfur Falls") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Bonecrusher Giant"),
            new SampleCard(1, "Brazen Borrower"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(1, "Flame Slash"),
            new SampleCard(1, "Flusterstorm"),
            new SampleCard(2, "Mindbreak Trap"),
            new SampleCard(1, "Seasoned Pyromancer"),
            new SampleCard(2, "Surgical Extraction") 
        };
    }
}