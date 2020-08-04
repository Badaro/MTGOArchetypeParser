using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_04
{
    public class Deck73_ilton_DimirControl_UB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(2, "Archmage's Charm"),
            new SampleCard(2, "Cling to Dust"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(3, "Drown in the Loch"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Frantic Inventory"),
            new SampleCard(3, "Mana Leak"),
            new SampleCard(2, "Shadow of Doubt"),
            new SampleCard(2, "Spell Snare"),
            new SampleCard(3, "Shark Typhoon"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(6, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(3, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(3, "Ceremonious Rejection"),
            new SampleCard(2, "Damnation"),
            new SampleCard(2, "Eliminate"),
            new SampleCard(1, "Spell Pierce"),
            new SampleCard(2, "Surgical Extraction") 
        };
    }
}