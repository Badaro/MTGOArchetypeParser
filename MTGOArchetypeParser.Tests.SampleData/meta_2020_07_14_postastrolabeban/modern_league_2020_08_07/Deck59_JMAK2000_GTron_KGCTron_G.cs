using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07
{
    public class Deck59_JMAK2000_GTron_KGCTron_G : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Karn Liberated"),
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(1, "Ugin, the Ineffable"),
            new SampleCard(2, "Ugin, the Spirit Dragon"),
            new SampleCard(1, "Kozilek, Butcher of Truth"),
            new SampleCard(1, "Ulamog, the Ceaseless Hunger"),
            new SampleCard(2, "Walking Ballista"),
            new SampleCard(4, "Ancient Stirrings"),
            new SampleCard(4, "Sylvan Scrying"),
            new SampleCard(2, "Pulse of Murasa"),
            new SampleCard(2, "Weather the Storm"),
            new SampleCard(4, "Chromatic Sphere"),
            new SampleCard(4, "Chromatic Star"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(4, "Oblivion Stone"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(3, "Forest"),
            new SampleCard(1, "Sanctum of Ugin"),
            new SampleCard(4, "Urza's Mine"),
            new SampleCard(4, "Urza's Power Plant"),
            new SampleCard(4, "Urza's Tower") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(1, "Crucible of Worlds"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(1, "Relic of Progenitus"),
            new SampleCard(1, "Torpor Orb"),
            new SampleCard(1, "Trinisphere"),
            new SampleCard(3, "Warping Wail"),
            new SampleCard(3, "Wilt"),
            new SampleCard(1, "Wurmcoil Engine") 
        };
    }
}