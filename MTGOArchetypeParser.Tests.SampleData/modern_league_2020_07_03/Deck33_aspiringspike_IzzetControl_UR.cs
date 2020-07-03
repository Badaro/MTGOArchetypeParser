using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03
{
    public class Deck33_aspiringspike_IzzetControl_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Narset, Parter of Veils"),
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(1, "Flame Slash"),
            new SampleCard(1, "Abrade"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(3, "Mana Leak"),
            new SampleCard(4, "Opt"),
            new SampleCard(2, "Remand"),
            new SampleCard(1, "Shadow of Doubt"),
            new SampleCard(2, "Spell Snare"),
            new SampleCard(4, "Shark Typhoon"),
            new SampleCard(4, "Cascade Bluffs"),
            new SampleCard(2, "Fiery Islet"),
            new SampleCard(1, "Minamo, School at Water's Edge"),
            new SampleCard(2, "Mountain"),
            new SampleCard(1, "Oboro, Palace in the Clouds"),
            new SampleCard(4, "Reflecting Pool"),
            new SampleCard(1, "Shivan Reef"),
            new SampleCard(4, "Spirebluff Canal"),
            new SampleCard(4, "Temple of Epiphany") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Abrade"),
            new SampleCard(4, "Aether Gust"),
            new SampleCard(3, "Boil"),
            new SampleCard(2, "Flusterstorm"),
            new SampleCard(3, "Izzet Staticaster"),
            new SampleCard(2, "Relic of Progenitus") 
        };
    }
}