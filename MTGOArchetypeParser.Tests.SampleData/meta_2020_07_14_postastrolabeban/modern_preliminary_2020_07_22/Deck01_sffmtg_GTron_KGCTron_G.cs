using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_07_22
{
    public class Deck01_sffmtg_GTron_KGCTron_G : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Karn Liberated"),
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(2, "Thought-Knot Seer"),
            new SampleCard(3, "Ulamog, the Ceaseless Hunger"),
            new SampleCard(2, "Walking Ballista"),
            new SampleCard(4, "Wurmcoil Engine"),
            new SampleCard(1, "All Is Dust"),
            new SampleCard(4, "Ancient Stirrings"),
            new SampleCard(4, "Sylvan Scrying"),
            new SampleCard(4, "Chromatic Sphere"),
            new SampleCard(4, "Chromatic Star"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(2, "Oblivion Stone"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(3, "Forest"),
            new SampleCard(1, "Nurturing Peatland"),
            new SampleCard(1, "Sanctum of Ugin"),
            new SampleCard(4, "Urza's Mine"),
            new SampleCard(4, "Urza's Power Plant"),
            new SampleCard(4, "Urza's Tower") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(2, "Dismember"),
            new SampleCard(1, "Elixir of Immortality"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(3, "Grafdigger's Cage"),
            new SampleCard(2, "Leyline of Sanctity"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(1, "Sorcerous Spyglass"),
            new SampleCard(1, "Sundering Titan"),
            new SampleCard(2, "Wilt") 
        };
    }
}