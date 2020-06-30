using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_19
{
    public class Deck17_Jositoshekel_Bogles_WG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Gladecover Scout"),(4, "Kor Spiritdancer"),(4, "Slippery Bogle"),(3, "Path to Exile"),(4, "Daybreak Coronet"),(4, "Ethereal Armor"),(2, "Gryff's Boon"),(2, "Hyena Umbra"),(4, "Rancor"),(4, "Spider Umbra"),(3, "Spirit Mantle"),(2, "Unflinching Courage"),(1, "Dryad Arbor"),(1, "Forest"),(4, "Horizon Canopy"),(1, "Plains"),(4, "Razorverge Thicket"),(3, "Temple Garden"),(4, "Windswept Heath"),(2, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Path to Exile"),(2, "Force of Vigor"),(3, "Gaddock Teeg"),(4, "Leyline of Sanctity"),(3, "Rest in Peace"),(2, "Spirit Link") }; } }
    }
}