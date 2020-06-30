using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_23
{
    public class Deck23_abombdiggity_Slivers_WUBRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Cloudshredder Sliver"),(3, "Dregscape Sliver"),(2, "Frenzy Sliver"),(4, "Galerider Sliver"),(1, "Harmonic Sliver"),(4, "Leeching Sliver"),(1, "Opaline Sliver"),(4, "Predatory Sliver"),(2, "Sidewinder Sliver"),(4, "Sinew Sliver"),(2, "Striking Sliver"),(1, "Syphon Sliver"),(4, "Unsettled Mariner"),(4, "Aether Vial"),(4, "Cavern of Souls"),(2, "Fiery Islet"),(3, "Mutavault"),(2, "Silent Clearing"),(4, "Sliver Hive"),(1, "Snow-Covered Plains"),(4, "Unclaimed Territory") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Harmonic Sliver"),(4, "Chalice of the Void"),(3, "Damping Sphere"),(2, "Dismember"),(4, "Leyline of the Void") }; } }
    }
}