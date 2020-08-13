using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_05
{
    public class Deck13_SvenSvenSven_IzzetControl_UR : ISampleDeck
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
            new SampleCard(1, "Deprive"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(1, "Magmatic Sinkhole"),
            new SampleCard(4, "Opt"),
            new SampleCard(3, "Remand"),
            new SampleCard(2, "Spell Pierce"),
            new SampleCard(1, "Cascade Bluffs"),
            new SampleCard(8, "Island"),
            new SampleCard(1, "Mountain"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(3, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Bonecrusher Giant"),
            new SampleCard(1, "Abrade"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(1, "Beacon Bolt"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(3, "Ceremonious Rejection"),
            new SampleCard(1, "Flusterstorm"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(1, "Spell Snare") 
        };
    }
}