using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck01_Tarrasque1_Elementals_WUBRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Flamekin Harbinger"),(1, "Flickerwisp"),(1, "Fulminator Mage"),(4, "Lightning Skelemental"),(1, "Mulldrifter"),(1, "Omnath, Locus of the Roil"),(3, "Phantasmal Image"),(4, "Risen Reef"),(1, "Shriekmaw"),(3, "Smokebraider"),(1, "Spitebellows"),(4, "Thunderkin Awakener"),(3, "Unsettled Mariner"),(2, "Vesperlark"),(2, "Voice of Resurgence"),(4, "Aether Vial"),(4, "Ancient Ziggurat"),(4, "Cavern of Souls"),(3, "Fiery Islet"),(1, "Mountain"),(3, "Primal Beyond"),(2, "Sunbaked Canyon"),(4, "Unclaimed Territory") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Fulminator Mage"),(1, "Spitebellows"),(2, "Damping Sphere"),(1, "Dismember"),(3, "Healer of the Glade"),(1, "Ingot Chewer"),(4, "Leyline of the Void"),(1, "Master of Waves") }; } }
    }
}