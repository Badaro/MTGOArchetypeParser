using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_03
{
    public class Deck02_mechint_DimirControl_UB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(2, "Cling to Dust"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(3, "Drown in the Loch"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Frantic Inventory"),
            new SampleCard(1, "Logic Knot"),
            new SampleCard(1, "Shadow of Doubt"),
            new SampleCard(2, "Spell Snare"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(4, "Shark Typhoon"),
            new SampleCard(1, "Field of Ruin"),
            new SampleCard(6, "Island"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(3, "Mystic Sanctuary"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(1, "Sunken Hollow"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Aether Gust"),
            new SampleCard(2, "Flusterstorm"),
            new SampleCard(1, "Kalitas, Traitor of Ghet"),
            new SampleCard(2, "Narset, Parter of Veils"),
            new SampleCard(3, "Plague Engineer"),
            new SampleCard(3, "Yixlid Jailer") 
        };
    }
}