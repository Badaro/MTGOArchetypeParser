using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12
{
    public class Deck34_knightmare21_IzzetControl_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "The Royal Scions"),
            new SampleCard(2, "Bonecrusher Giant"),
            new SampleCard(1, "Brazen Borrower"),
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(3, "Thing in the Ice"),
            new SampleCard(1, "Vendilion Clique"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(1, "Deprive"),
            new SampleCard(1, "Electrolyze"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(1, "Magmatic Sinkhole"),
            new SampleCard(4, "Opt"),
            new SampleCard(3, "Remand"),
            new SampleCard(1, "Spell Pierce"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(7, "Island"),
            new SampleCard(1, "Mountain"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Steam Vents"),
            new SampleCard(2, "Sulfur Falls") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(1, "Ceremonious Rejection"),
            new SampleCard(2, "Dragon's Claw"),
            new SampleCard(2, "Flusterstorm"),
            new SampleCard(2, "Relic of Progenitus") 
        };
    }
}