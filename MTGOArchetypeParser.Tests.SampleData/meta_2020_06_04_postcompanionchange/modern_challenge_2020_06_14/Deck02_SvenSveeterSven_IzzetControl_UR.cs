using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_challenge_2020_06_14
{
    public class Deck02_SvenSveeterSven_IzzetControl_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "The Royal Scions"),
            new SampleCard(2, "Bonecrusher Giant"),
            new SampleCard(2, "Brazen Borrower"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(3, "Thing in the Ice"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(4, "Archmage's Charm"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(1, "Magmatic Sinkhole"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Remand"),
            new SampleCard(2, "Spell Pierce"),
            new SampleCard(1, "Cascade Bluffs"),
            new SampleCard(1, "Fiery Islet"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(8, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(2, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Bonecrusher Giant"),
            new SampleCard(1, "Brazen Borrower"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(2, "Flusterstorm"),
            new SampleCard(1, "Forked Bolt"),
            new SampleCard(1, "Improbable Alliance"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(2, "Surgical Extraction") 
        };
    }
}