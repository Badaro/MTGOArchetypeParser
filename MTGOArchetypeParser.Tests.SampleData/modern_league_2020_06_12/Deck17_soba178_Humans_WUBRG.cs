using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12
{
    public class Deck17_soba178_Humans_WUBRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Champion of the Parish"),(2, "General Kudro of Drannith"),(4, "Kitesail Freebooter"),(4, "Mantis Rider"),(4, "Meddling Mage"),(4, "Noble Hierarch"),(4, "Phantasmal Image"),(4, "Reflector Mage"),(3, "Thalia, Guardian of Thraben"),(4, "Thalia's Lieutenant"),(4, "Aether Vial"),(4, "Ancient Ziggurat"),(4, "Cavern of Souls"),(4, "Horizon Canopy"),(1, "Island"),(1, "Plains"),(1, "Silent Clearing"),(4, "Unclaimed Territory") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Auriok Champion"),(2, "Collector Ouphe"),(2, "Damping Sphere"),(2, "Deputy of Detention"),(1, "Dismember"),(2, "Grafdigger's Cage"),(1, "Militia Bugler"),(2, "Mirran Crusader") }; } }
    }
}