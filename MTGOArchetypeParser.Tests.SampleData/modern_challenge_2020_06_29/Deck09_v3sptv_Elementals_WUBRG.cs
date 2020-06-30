using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_29
{
    public class Deck09_v3sptv_Elementals_WUBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Flamekin Harbinger"),
            new SampleCard(1, "Fulminator Mage"),
            new SampleCard(1, "Healer of the Glade"),
            new SampleCard(4, "Insolent Neonate"),
            new SampleCard(4, "Lightning Skelemental"),
            new SampleCard(1, "Omnath, Locus of the Roil"),
            new SampleCard(2, "Phantasmal Image"),
            new SampleCard(4, "Risen Reef"),
            new SampleCard(1, "Shriekmaw"),
            new SampleCard(3, "Simian Spirit Guide"),
            new SampleCard(1, "Smokebraider"),
            new SampleCard(4, "Thunderkin Awakener"),
            new SampleCard(4, "Vesperlark"),
            new SampleCard(1, "Voice of Resurgence"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Ancient Ziggurat"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(4, "Fiery Islet"),
            new SampleCard(2, "Snow-Covered Mountain"),
            new SampleCard(3, "Sunbaked Canyon"),
            new SampleCard(4, "Unclaimed Territory") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Fulminator Mage"),
            new SampleCard(1, "Healer of the Glade"),
            new SampleCard(2, "Voice of Resurgence"),
            new SampleCard(1, "Ingot Chewer"),
            new SampleCard(2, "Lightning Bolt"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(1, "Spitebellows"),
            new SampleCard(2, "Tormod's Crypt"),
            new SampleCard(2, "Unsettled Mariner"),
            new SampleCard(1, "Wispmare") 
        };
    }
}