using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck13_SvenSveeterSven_IzzetControl_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "The Royal Scions"),
            new SampleCard(2, "Bonecrusher Giant"),
            new SampleCard(3, "Brazen Borrower"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(4, "Archmage's Charm"),
            new SampleCard(2, "Fire Prophecy"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Magmatic Sinkhole"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Remand"),
            new SampleCard(2, "Spell Pierce"),
            new SampleCard(3, "Shark Typhoon"),
            new SampleCard(2, "Cascade Bluffs"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(8, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(2, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Brazen Borrower"),
            new SampleCard(3, "Aether Gust"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(3, "Ceremonious Rejection"),
            new SampleCard(1, "Flusterstorm"),
            new SampleCard(1, "Pyroclasm"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(2, "Surgical Extraction") 
        };
    }
}