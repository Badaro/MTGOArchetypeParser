using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck13_Busterbrown52_Elementals_WUBRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Flamekin Harbinger"),(2, "Flickerwisp"),(4, "Lightning Skelemental"),(1, "Omnath, Locus of the Roil"),(4, "Phantasmal Image"),(4, "Risen Reef"),(1, "Shriekmaw"),(1, "Smokebraider"),(1, "Spitebellows"),(4, "Thunderkin Awakener"),(4, "Unsettled Mariner"),(2, "Vesperlark"),(4, "Voice of Resurgence"),(4, "Aether Vial"),(4, "Ancient Ziggurat"),(4, "Cavern of Souls"),(1, "Fiery Islet"),(1, "Mountain"),(4, "Primal Beyond"),(2, "Sunbaked Canyon"),(4, "Unclaimed Territory") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Shriekmaw"),(2, "Collector Ouphe"),(2, "Damping Sphere"),(3, "Dismember"),(1, "Fulminator Mage"),(3, "Healer of the Glade"),(1, "Ingot Chewer"),(2, "Soul-Guide Lantern") }; } }
    }
}