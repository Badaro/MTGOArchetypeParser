using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_28
{
    public class Deck32_GoldenKid24K_GTron_KGCTron_G : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Karn Liberated"),
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(2, "Ugin, the Spirit Dragon"),
            new SampleCard(2, "Ulamog, the Ceaseless Hunger"),
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(4, "Wurmcoil Engine"),
            new SampleCard(4, "Ancient Stirrings"),
            new SampleCard(4, "Sylvan Scrying"),
            new SampleCard(4, "Chromatic Sphere"),
            new SampleCard(4, "Chromatic Star"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(1, "Mazemind Tome"),
            new SampleCard(4, "Oblivion Stone"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(4, "Forest"),
            new SampleCard(1, "Sanctum of Ugin"),
            new SampleCard(4, "Urza's Mine"),
            new SampleCard(4, "Urza's Power Plant"),
            new SampleCard(4, "Urza's Tower") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Emrakul, the Promised End"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(3, "Grafdigger's Cage"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(1, "Sundering Titan"),
            new SampleCard(3, "Veil of Summer"),
            new SampleCard(3, "Weather the Storm") 
        };
    }
}