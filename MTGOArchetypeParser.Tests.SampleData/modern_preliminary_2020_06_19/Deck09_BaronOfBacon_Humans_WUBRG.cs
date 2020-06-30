using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_19
{
    public class Deck09_BaronOfBacon_Humans_WUBRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Champion of the Parish"),(2, "General Kudro of Drannith"),(3, "Kitesail Freebooter"),(4, "Mantis Rider"),(4, "Meddling Mage"),(4, "Noble Hierarch"),(4, "Phantasmal Image"),(4, "Reflector Mage"),(4, "Thalia, Guardian of Thraben"),(4, "Thalia's Lieutenant"),(4, "Aether Vial"),(3, "Ancient Ziggurat"),(4, "Cavern of Souls"),(1, "Gemstone Mine"),(4, "Horizon Canopy"),(1, "Island"),(1, "Plains"),(4, "Unclaimed Territory"),(1, "Waterlogged Grove") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Auriok Champion"),(2, "Dire Fleet Daredevil"),(2, "Dismember"),(2, "Grafdigger's Cage"),(2, "Knight of Autumn"),(2, "Mirran Crusader"),(2, "Sin Collector") }; } }
    }
}