using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck49_Girolamo1996_Humans_WUBRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Champion of the Parish"),(1, "Deputy of Detention"),(1, "Kessig Malcontents"),(4, "Kitesail Freebooter"),(4, "Mantis Rider"),(4, "Meddling Mage"),(4, "Noble Hierarch"),(4, "Phantasmal Image"),(4, "Reflector Mage"),(3, "Thalia, Guardian of Thraben"),(4, "Thalia's Lieutenant"),(4, "Aether Vial"),(4, "Ancient Ziggurat"),(4, "Cavern of Souls"),(4, "Horizon Canopy"),(1, "Island"),(1, "Plains"),(1, "Seachrome Coast"),(4, "Unclaimed Territory") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Deputy of Detention"),(2, "Auriok Champion"),(2, "Dismember"),(1, "Gaddock Teeg"),(2, "Grafdigger's Cage"),(1, "Izzet Staticaster"),(1, "Kambal, Consul of Allocation"),(1, "Knight of Autumn"),(2, "Mirran Crusader"),(2, "Sin Collector") }; } }
    }
}