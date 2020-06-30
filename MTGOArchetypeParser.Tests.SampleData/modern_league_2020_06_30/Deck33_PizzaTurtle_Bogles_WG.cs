using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck33_PizzaTurtle_Bogles_WG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Gladecover Scout"),(4, "Kor Spiritdancer"),(4, "Slippery Bogle"),(2, "All That Glitters"),(4, "Daybreak Coronet"),(4, "Ethereal Armor"),(4, "Gryff's Boon"),(2, "Hyena Umbra"),(4, "Rancor"),(4, "Spider Umbra"),(2, "Spirit Link"),(2, "Spirit Mantle"),(4, "Brushland"),(1, "Dryad Arbor"),(1, "Forest"),(2, "Plains"),(4, "Razorverge Thicket"),(2, "Temple Garden"),(4, "Windswept Heath"),(2, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Damping Sphere"),(2, "Gaddock Teeg"),(4, "Kor Firewalker"),(1, "Lurrus of the Dream-Den"),(3, "Seal of Primordium"),(3, "Soul-Guide Lantern") }; } }
    }
}