using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_20
{
    public class Deck19_grahams_Mill_UB : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Hedron Crab"),(4, "Jace's Phantasm"),(4, "Glimpse the Unthinkable"),(3, "Inquisition of Kozilek"),(4, "Archive Trap"),(3, "Drown in the Loch"),(4, "Fatal Push"),(1, "Mission Briefing"),(3, "Surgical Extraction"),(4, "Visions of Beyond"),(4, "Mesmeric Orb"),(2, "Darkslick Shores"),(3, "Field of Ruin"),(4, "Flooded Strand"),(3, "Island"),(1, "Oboro, Palace in the Clouds"),(4, "Polluted Delta"),(1, "Shelldock Isle"),(2, "Swamp"),(2, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Drown in the Loch"),(1, "Surgical Extraction"),(2, "Collective Brutality"),(2, "Crypt Incursion"),(1, "Damnation"),(2, "Echoing Truth"),(2, "Force of Negation"),(3, "Profane Memento"),(1, "Torpor Orb") }; } }
    }
}