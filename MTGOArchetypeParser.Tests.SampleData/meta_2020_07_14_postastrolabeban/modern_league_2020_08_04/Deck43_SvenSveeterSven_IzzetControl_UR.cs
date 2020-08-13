using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_04
{
    public class Deck43_SvenSveeterSven_IzzetControl_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "The Royal Scions"),
            new SampleCard(2, "Bonecrusher Giant"),
            new SampleCard(4, "Brazen Borrower"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Frantic Inventory"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(1, "Magmatic Sinkhole"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Remand"),
            new SampleCard(2, "Spell Pierce"),
            new SampleCard(2, "Shark Typhoon"),
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
            new SampleCard(1, "Abrade"),
            new SampleCard(3, "Aether Gust"),
            new SampleCard(1, "Anger of the Gods"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(1, "Flame Slash"),
            new SampleCard(1, "Flame Sweep"),
            new SampleCard(1, "Flusterstorm"),
            new SampleCard(2, "Surgical Extraction") 
        };
    }
}