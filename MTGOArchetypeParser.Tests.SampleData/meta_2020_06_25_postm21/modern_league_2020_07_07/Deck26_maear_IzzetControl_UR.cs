using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07
{
    public class Deck26_maear_IzzetControl_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Jace, the Mind Sculptor"),
            new SampleCard(1, "Ral, Izzet Viceroy"),
            new SampleCard(1, "Bonecrusher Giant"),
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(1, "Venser, Shaper Savant"),
            new SampleCard(1, "Flame Slash"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(1, "Abrade"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(2, "Deprive"),
            new SampleCard(1, "Electrolyze"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(1, "Magmatic Sinkhole"),
            new SampleCard(1, "Mana Leak"),
            new SampleCard(4, "Remand"),
            new SampleCard(1, "Spell Pierce"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(2, "Blast Zone"),
            new SampleCard(1, "Flooded Strand"),
            new SampleCard(5, "Island"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(3, "Mystic Sanctuary"),
            new SampleCard(1, "Polluted Delta"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(3, "Steam Vents"),
            new SampleCard(3, "Sulfur Falls") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(3, "Ashiok, Dream Render"),
            new SampleCard(3, "Blood Moon"),
            new SampleCard(1, "Ceremonious Rejection"),
            new SampleCard(1, "Chandra, Awakened Inferno"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(3, "Dragon's Claw"),
            new SampleCard(1, "Surgical Extraction") 
        };
    }
}