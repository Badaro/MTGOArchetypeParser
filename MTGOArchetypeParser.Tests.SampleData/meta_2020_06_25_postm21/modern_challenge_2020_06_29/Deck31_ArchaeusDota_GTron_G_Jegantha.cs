using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_challenge_2020_06_29
{
    public class Deck31_ArchaeusDota_GTron_G_Jegantha : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Karn Liberated"),
            new SampleCard(2, "Ugin, the Spirit Dragon"),
            new SampleCard(2, "Conduit of Ruin"),
            new SampleCard(1, "Emrakul, the Promised End"),
            new SampleCard(1, "Kozilek, Butcher of Truth"),
            new SampleCard(4, "Thought-Knot Seer"),
            new SampleCard(1, "Ulamog, the Ceaseless Hunger"),
            new SampleCard(1, "World Breaker"),
            new SampleCard(4, "Wurmcoil Engine"),
            new SampleCard(1, "All Is Dust"),
            new SampleCard(4, "Ancient Stirrings"),
            new SampleCard(4, "Sylvan Scrying"),
            new SampleCard(4, "Chromatic Sphere"),
            new SampleCard(4, "Chromatic Star"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(1, "Bonders' Enclave"),
            new SampleCard(2, "Forest"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(1, "Sanctum of Ugin"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(4, "Urza's Mine"),
            new SampleCard(4, "Urza's Power Plant"),
            new SampleCard(4, "Urza's Tower") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(2, "Dismember"),
            new SampleCard(4, "Grafdigger's Cage"),
            new SampleCard(1, "Jegantha, the Wellspring"),
            new SampleCard(3, "Leyline of Sanctity"),
            new SampleCard(1, "Veil of Summer"),
            new SampleCard(3, "Wilt") 
        };
    }
}