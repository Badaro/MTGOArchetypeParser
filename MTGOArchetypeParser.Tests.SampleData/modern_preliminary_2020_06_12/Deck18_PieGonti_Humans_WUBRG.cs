using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_12
{
    public class Deck18_PieGonti_Humans_WUBRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Champion of the Parish"),(1, "Dark Confidant"),(3, "General Kudro of Drannith"),(3, "Kitesail Freebooter"),(4, "Mantis Rider"),(4, "Meddling Mage"),(4, "Noble Hierarch"),(3, "Phantasmal Image"),(4, "Reflector Mage"),(3, "Thalia, Guardian of Thraben"),(4, "Thalia's Lieutenant"),(4, "Aether Vial"),(3, "Ancient Ziggurat"),(1, "Botanical Sanctum"),(4, "Cavern of Souls"),(3, "Horizon Canopy"),(1, "Plains"),(1, "Seachrome Coast"),(1, "Silent Clearing"),(4, "Unclaimed Territory"),(1, "Waterlogged Grove") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Auriok Champion"),(2, "Choke"),(1, "Collector Ouphe"),(2, "Deputy of Detention"),(2, "Dismember"),(2, "Gaddock Teeg"),(2, "Grafdigger's Cage"),(2, "Militia Bugler") }; } }
    }
}