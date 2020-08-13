using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_challenge_2020_08_12_0
{
    public class Deck26_anamika_Elementals_WUBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Flamekin Harbinger"),
            new SampleCard(1, "Fulminator Mage"),
            new SampleCard(1, "Incandescent Soulstoke"),
            new SampleCard(4, "Lightning Skelemental"),
            new SampleCard(1, "Omnath, Locus of the Roil"),
            new SampleCard(3, "Phantasmal Image"),
            new SampleCard(4, "Risen Reef"),
            new SampleCard(1, "Shriekmaw"),
            new SampleCard(2, "Smokebraider"),
            new SampleCard(1, "Spitebellows"),
            new SampleCard(4, "Thunderkin Awakener"),
            new SampleCard(3, "Unsettled Mariner"),
            new SampleCard(2, "Vesperlark"),
            new SampleCard(3, "Voice of Resurgence"),
            new SampleCard(1, "Dismember"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Ancient Ziggurat"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(3, "Fiery Islet"),
            new SampleCard(1, "Mountain"),
            new SampleCard(4, "Primal Beyond"),
            new SampleCard(2, "Sunbaked Canyon"),
            new SampleCard(3, "Unclaimed Territory") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Fulminator Mage"),
            new SampleCard(1, "Shriekmaw"),
            new SampleCard(1, "Spitebellows"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(3, "Healer of the Glade"),
            new SampleCard(1, "Ingot Chewer"),
            new SampleCard(3, "Leyline of the Void"),
            new SampleCard(1, "Surgical Extraction"),
            new SampleCard(1, "Wispmare") 
        };
    }
}