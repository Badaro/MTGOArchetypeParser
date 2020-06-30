using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05
{
    public class Deck33_liu123_Bogles_WG_Lurrus : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Gladecover Scout"),(4, "Kor Spiritdancer"),(4, "Slippery Bogle"),(1, "Path to Exile"),(4, "Daybreak Coronet"),(4, "Ethereal Armor"),(2, "Gryff's Boon"),(4, "Hyena Umbra"),(4, "Rancor"),(2, "Sentinel's Eyes"),(3, "Spider Umbra"),(2, "Spirit Link"),(2, "Spirit Mantle"),(1, "Dryad Arbor"),(1, "Forest"),(4, "Horizon Canopy"),(2, "Plains"),(4, "Razorverge Thicket"),(4, "Temple Garden"),(4, "Windswept Heath") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Path to Exile"),(2, "Deafening Silence"),(3, "Force of Vigor"),(3, "Gaddock Teeg"),(1, "Lurrus of the Dream Den"),(2, "Suppression Field"),(2, "Tormod's Crypt") }; } }
    }
}