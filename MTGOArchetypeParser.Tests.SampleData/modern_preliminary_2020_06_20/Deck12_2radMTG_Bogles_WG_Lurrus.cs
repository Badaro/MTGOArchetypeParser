using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_20
{
    public class Deck12_2radMTG_Bogles_WG_Lurrus : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Gladecover Scout"),(4, "Kor Spiritdancer"),(4, "Slippery Bogle"),(4, "Daybreak Coronet"),(4, "Ethereal Armor"),(2, "Gryff's Boon"),(4, "Hyena Umbra"),(3, "Leyline of Sanctity"),(4, "Rancor"),(3, "Spider Umbra"),(1, "Spirit Link"),(2, "Spirit Mantle"),(1, "Dryad Arbor"),(2, "Forest"),(4, "Horizon Canopy"),(2, "Plains"),(4, "Razorverge Thicket"),(4, "Temple Garden"),(4, "Windswept Heath") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Damping Sphere"),(2, "Force of Vigor"),(2, "Gaddock Teeg"),(1, "Lurrus of the Dream Den"),(2, "Path to Exile"),(3, "Pithing Needle"),(3, "Suppression Field") }; } }
    }
}