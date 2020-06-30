using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_25
{
    public class Deck03_FrankEGMTG_Humans_WUBRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Champion of the Parish"),(1, "Deputy of Detention"),(3, "Kitesail Freebooter"),(4, "Mantis Rider"),(4, "Meddling Mage"),(4, "Noble Hierarch"),(4, "Phantasmal Image"),(4, "Reflector Mage"),(3, "Thalia, Guardian of Thraben"),(4, "Thalia's Lieutenant"),(2, "Unsettled Mariner"),(4, "Aether Vial"),(3, "Ancient Ziggurat"),(4, "Cavern of Souls"),(4, "Horizon Canopy"),(1, "Island"),(1, "Plains"),(1, "Seachrome Coast"),(4, "Unclaimed Territory"),(1, "Waterlogged Grove") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Deputy of Detention"),(3, "Auriok Champion"),(2, "Collector Ouphe"),(2, "Damping Sphere"),(3, "Dismember"),(2, "Gaddock Teeg"),(1, "Grafdigger's Cage") }; } }
    }
}