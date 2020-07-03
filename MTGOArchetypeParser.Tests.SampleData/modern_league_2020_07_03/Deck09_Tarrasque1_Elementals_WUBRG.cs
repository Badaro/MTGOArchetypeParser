using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03
{
    public class Deck09_Tarrasque1_Elementals_WUBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Flamekin Harbinger"),
            new SampleCard(3, "Fulminator Mage"),
            new SampleCard(4, "Lightning Skelemental"),
            new SampleCard(3, "Master of Waves"),
            new SampleCard(1, "Mulldrifter"),
            new SampleCard(1, "Omnath, Locus of the Roil"),
            new SampleCard(3, "Phantasmal Image"),
            new SampleCard(4, "Risen Reef"),
            new SampleCard(1, "Shriekmaw"),
            new SampleCard(3, "Smokebraider"),
            new SampleCard(4, "Thunderkin Awakener"),
            new SampleCard(4, "Unsettled Mariner"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Ancient Ziggurat"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(4, "Fiery Islet"),
            new SampleCard(1, "Mountain"),
            new SampleCard(2, "Primal Beyond"),
            new SampleCard(2, "Reflecting Pool"),
            new SampleCard(4, "Unclaimed Territory") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Mulldrifter"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Dismember"),
            new SampleCard(3, "Healer of the Glade"),
            new SampleCard(1, "Ingot Chewer"),
            new SampleCard(4, "Leyline of the Void"),
            new SampleCard(1, "Spitebellows"),
            new SampleCard(1, "Voice of Resurgence") 
        };
    }
}