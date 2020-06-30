using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26
{
    public class Deck06_StreexIT_Spirits_WU : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Teferi, Time Raveler"),(2, "Brazen Borrower"),(4, "Drogskol Captain"),(4, "Mausoleum Wanderer"),(4, "Rattlechains"),(4, "Selfless Spirit"),(4, "Spell Queller"),(4, "Supreme Phantom"),(3, "Path to Exile"),(2, "Remand"),(4, "Aether Vial"),(2, "Smuggler's Copter"),(1, "Cavern of Souls"),(4, "Flooded Strand"),(2, "Hallowed Fountain"),(3, "Island"),(2, "Moorland Haunt"),(2, "Mutavault"),(1, "Plains"),(4, "Seachrome Coast"),(1, "Silent Clearing") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Damping Sphere"),(1, "Favorable Winds"),(2, "Force of Negation"),(1, "Kira, Great Glass-Spinner"),(2, "Mana Leak"),(2, "Rest in Peace"),(2, "Shadow of Doubt"),(1, "Stony Silence"),(1, "Sword of Fire and Ice"),(1, "Worship") }; } }
    }
}