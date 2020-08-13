using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_preliminary_2020_06_25
{
    public class Deck08_TubbyBatman_NarsetsUndoing_UB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Narset, Parter of Veils"),
            new SampleCard(3, "Notion Thief"),
            new SampleCard(4, "Thing in the Ice"),
            new SampleCard(2, "Vendilion Clique"),
            new SampleCard(1, "Commit // Memory"),
            new SampleCard(4, "Day's Undoing"),
            new SampleCard(2, "Commandeer"),
            new SampleCard(4, "Disrupting Shoal"),
            new SampleCard(1, "Drown in the Loch"),
            new SampleCard(1, "Engulf the Shore"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(2, "Remand"),
            new SampleCard(2, "Snapback"),
            new SampleCard(3, "Spell Pierce"),
            new SampleCard(2, "Spell Snare"),
            new SampleCard(1, "Vapor Snag"),
            new SampleCard(4, "Mistvein Borderpost"),
            new SampleCard(2, "Geier Reach Sanitarium"),
            new SampleCard(1, "Mikokoro, Center of the Sea"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(9, "Snow-Covered Island"),
            new SampleCard(2, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Commandeer"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Blast Zone"),
            new SampleCard(2, "Dead of Winter"),
            new SampleCard(2, "Field of Ruin"),
            new SampleCard(2, "Tyrant's Scorn"),
            new SampleCard(3, "Unmoored Ego") 
        };
    }
}