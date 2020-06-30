using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_29
{
    public class Deck09_v3sptv_Elementals_WUBRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Flamekin Harbinger"),(1, "Fulminator Mage"),(1, "Healer of the Glade"),(4, "Insolent Neonate"),(4, "Lightning Skelemental"),(1, "Omnath, Locus of the Roil"),(2, "Phantasmal Image"),(4, "Risen Reef"),(1, "Shriekmaw"),(3, "Simian Spirit Guide"),(1, "Smokebraider"),(4, "Thunderkin Awakener"),(4, "Vesperlark"),(1, "Voice of Resurgence"),(4, "Aether Vial"),(4, "Ancient Ziggurat"),(4, "Cavern of Souls"),(4, "Fiery Islet"),(2, "Snow-Covered Mountain"),(3, "Sunbaked Canyon"),(4, "Unclaimed Territory") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Fulminator Mage"),(1, "Healer of the Glade"),(2, "Voice of Resurgence"),(1, "Ingot Chewer"),(2, "Lightning Bolt"),(2, "Plague Engineer"),(1, "Spitebellows"),(2, "Tormod's Crypt"),(2, "Unsettled Mariner"),(1, "Wispmare") }; } }
    }
}