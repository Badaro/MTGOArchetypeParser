using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck12_kaikalbuquerque_Bogles_WG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Gladecover Scout"),(4, "Kor Spiritdancer"),(4, "Slippery Bogle"),(2, "Path to Exile"),(1, "All That Glitters"),(4, "Daybreak Coronet"),(4, "Ethereal Armor"),(2, "Gryff's Boon"),(4, "Hyena Umbra"),(4, "Rancor"),(3, "Spider Umbra"),(1, "Spirit Link"),(3, "Spirit Mantle"),(1, "Dryad Arbor"),(1, "Forest"),(4, "Horizon Canopy"),(2, "Plains"),(4, "Razorverge Thicket"),(4, "Temple Garden"),(4, "Windswept Heath") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Damping Sphere"),(3, "Force of Vigor"),(2, "Gaddock Teeg"),(4, "Leyline of Sanctity"),(2, "Rest in Peace"),(1, "Stony Silence") }; } }
    }
}