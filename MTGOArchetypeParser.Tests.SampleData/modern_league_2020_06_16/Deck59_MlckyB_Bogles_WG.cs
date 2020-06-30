using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck59_MlckyB_Bogles_WG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Gladecover Scout"),(4, "Kor Spiritdancer"),(4, "Slippery Bogle"),(3, "Savage Swipe"),(4, "Daybreak Coronet"),(4, "Ethereal Armor"),(4, "Gryff's Boon"),(4, "Hyena Umbra"),(4, "Leyline of Sanctity"),(4, "Rancor"),(1, "Sentinel's Eyes"),(1, "Dryad Arbor"),(1, "Forest"),(4, "Horizon Canopy"),(1, "Misty Rainforest"),(2, "Plains"),(4, "Razorverge Thicket"),(3, "Temple Garden"),(4, "Windswept Heath") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Force of Vigor"),(3, "Gaddock Teeg"),(2, "Path to Exile"),(2, "Rest in Peace"),(1, "Stony Silence"),(2, "Suppression Field"),(2, "Torpor Orb") }; } }
    }
}