using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_07
{
    public class Deck13_ArchaeusDota_GTron_GreenEldraziTron_G : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Conduit of Ruin"),
            new SampleCard(4, "Endbringer"),
            new SampleCard(4, "Thought-Knot Seer"),
            new SampleCard(2, "Ulamog, the Ceaseless Hunger"),
            new SampleCard(2, "Walking Ballista"),
            new SampleCard(2, "World Breaker"),
            new SampleCard(2, "All Is Dust"),
            new SampleCard(4, "Ancient Stirrings"),
            new SampleCard(4, "Sylvan Scrying"),
            new SampleCard(4, "Chromatic Sphere"),
            new SampleCard(4, "Chromatic Star"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(1, "Bonders' Enclave"),
            new SampleCard(4, "Eldrazi Temple"),
            new SampleCard(1, "Forest"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(4, "Urza's Mine"),
            new SampleCard(4, "Urza's Power Plant"),
            new SampleCard(4, "Urza's Tower"),
            new SampleCard(1, "Wastes") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(2, "Dismember"),
            new SampleCard(1, "Emrakul, the Promised End"),
            new SampleCard(3, "Grafdigger's Cage"),
            new SampleCard(2, "Pithing Needle"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(1, "Veil of Summer"),
            new SampleCard(3, "Wilt") 
        };
    }
}