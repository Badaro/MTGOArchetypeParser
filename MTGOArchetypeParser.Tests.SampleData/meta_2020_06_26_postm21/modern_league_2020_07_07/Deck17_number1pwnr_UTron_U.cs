using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07
{
    public class Deck17_number1pwnr_UTron_U : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ugin, the Ineffable"),
            new SampleCard(2, "Ugin, the Spirit Dragon"),
            new SampleCard(2, "Thought-Knot Seer"),
            new SampleCard(2, "Walking Ballista"),
            new SampleCard(3, "Wurmcoil Engine"),
            new SampleCard(2, "Commit // Memory"),
            new SampleCard(3, "Condescend"),
            new SampleCard(1, "Dismember"),
            new SampleCard(3, "Remand"),
            new SampleCard(2, "Repeal"),
            new SampleCard(1, "Spatial Contortion"),
            new SampleCard(1, "Spell Burst"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(4, "Thirst for Knowledge"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(1, "Mindslaver"),
            new SampleCard(1, "Relic of Progenitus"),
            new SampleCard(1, "Talisman of Dominance"),
            new SampleCard(2, "Omen of the Sea"),
            new SampleCard(1, "Academy Ruins"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(1, "Field of Ruin"),
            new SampleCard(8, "Island"),
            new SampleCard(4, "Urza's Mine"),
            new SampleCard(4, "Urza's Power Plant"),
            new SampleCard(4, "Urza's Tower") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Dismember"),
            new SampleCard(3, "Relic of Progenitus"),
            new SampleCard(1, "Spatial Contortion"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Dispel"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Negate"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(1, "Summary Dismissal"),
            new SampleCard(1, "Torpor Orb") 
        };
    }
}