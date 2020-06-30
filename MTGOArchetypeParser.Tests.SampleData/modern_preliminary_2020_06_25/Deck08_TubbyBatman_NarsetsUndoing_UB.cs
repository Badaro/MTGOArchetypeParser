using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_25
{
    public class Deck08_TubbyBatman_NarsetsUndoing_UB : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Narset, Parter of Veils"),(3, "Notion Thief"),(4, "Thing in the Ice"),(2, "Vendilion Clique"),(1, "Commit // Memory"),(4, "Day's Undoing"),(2, "Commandeer"),(4, "Disrupting Shoal"),(1, "Drown in the Loch"),(1, "Engulf the Shore"),(2, "Force of Negation"),(2, "Remand"),(2, "Snapback"),(3, "Spell Pierce"),(2, "Spell Snare"),(1, "Vapor Snag"),(4, "Mistvein Borderpost"),(2, "Geier Reach Sanitarium"),(1, "Mikokoro, Center of the Sea"),(4, "Polluted Delta"),(9, "Snow-Covered Island"),(2, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Commandeer"),(2, "Ashiok, Dream Render"),(2, "Blast Zone"),(2, "Dead of Winter"),(2, "Field of Ruin"),(2, "Tyrant's Scorn"),(3, "Unmoored Ego") }; } }
    }
}