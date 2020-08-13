using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_28
{
    public class Deck12_Galanator_IzzetControl_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Bonecrusher Giant"),
            new SampleCard(2, "Brazen Borrower"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(3, "Serum Visions"),
            new SampleCard(4, "Archmage's Charm"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(1, "Magmatic Sinkhole"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Remand"),
            new SampleCard(2, "Spell Snare"),
            new SampleCard(3, "Shark Typhoon"),
            new SampleCard(2, "Flooded Strand"),
            new SampleCard(7, "Island"),
            new SampleCard(2, "Misty Rainforest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(3, "Mystic Sanctuary"),
            new SampleCard(1, "Polluted Delta"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(3, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(3, "Ceremonious Rejection"),
            new SampleCard(1, "Deprive"),
            new SampleCard(3, "Flame Sweep"),
            new SampleCard(3, "Madcap Experiment"),
            new SampleCard(2, "Platinum Emperion") 
        };
    }
}