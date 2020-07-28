using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_28
{
    public class Deck53_Busterbrown52_Elementals_WUBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Flamekin Harbinger"),
            new SampleCard(1, "Flickerwisp"),
            new SampleCard(2, "Incandescent Soulstoke"),
            new SampleCard(4, "Lightning Skelemental"),
            new SampleCard(1, "Omnath, Locus of the Roil"),
            new SampleCard(4, "Phantasmal Image"),
            new SampleCard(4, "Risen Reef"),
            new SampleCard(1, "Shriekmaw"),
            new SampleCard(1, "Smokebraider"),
            new SampleCard(1, "Spitebellows"),
            new SampleCard(3, "Thunderkin Awakener"),
            new SampleCard(4, "Unsettled Mariner"),
            new SampleCard(2, "Vesperlark"),
            new SampleCard(4, "Voice of Resurgence"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Ancient Ziggurat"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(1, "Mountain"),
            new SampleCard(4, "Primal Beyond"),
            new SampleCard(3, "Sunbaked Canyon"),
            new SampleCard(4, "Unclaimed Territory") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Chalice of the Void"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(3, "Dismember"),
            new SampleCard(1, "Fulminator Mage"),
            new SampleCard(2, "Healer of the Glade"),
            new SampleCard(1, "Ingot Chewer"),
            new SampleCard(2, "Soul-Guide Lantern") 
        };
    }
}