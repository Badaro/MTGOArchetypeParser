using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck51_TheCodyHope_Elementals_WUBRG_Kaheera : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Flamekin Harbinger"),
            new SampleCard(2, "Flickerwisp"),
            new SampleCard(1, "Fulminator Mage"),
            new SampleCard(3, "Incandescent Soulstoke"),
            new SampleCard(4, "Lightning Skelemental"),
            new SampleCard(1, "Mulldrifter"),
            new SampleCard(1, "Omnath, Locus of the Roil"),
            new SampleCard(4, "Risen Reef"),
            new SampleCard(1, "Shriekmaw"),
            new SampleCard(2, "Smokebraider"),
            new SampleCard(1, "Spitebellows"),
            new SampleCard(4, "Thunderkin Awakener"),
            new SampleCard(4, "Unsettled Mariner"),
            new SampleCard(3, "Voice of Resurgence"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Ancient Ziggurat"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(1, "Mountain"),
            new SampleCard(4, "Primal Beyond"),
            new SampleCard(4, "Sunbaked Canyon"),
            new SampleCard(4, "Unclaimed Territory") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Shriekmaw"),
            new SampleCard(1, "Spitebellows"),
            new SampleCard(3, "Chalice of the Void"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(3, "Dismember"),
            new SampleCard(1, "Ingot Chewer"),
            new SampleCard(1, "Kaheera, the Orphanguard"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(1, "Wispmare") 
        };
    }
}