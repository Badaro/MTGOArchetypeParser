using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck31_FabriceK_SnowControl_SnowReclamation_UBG_Yorion : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Ice-Fang Coatl"),(3, "Uro, Titan of Nature's Wrath"),(1, "Dead of Winter"),(1, "Abrupt Decay"),(4, "Archmage's Charm"),(1, "Assassin's Trophy"),(4, "Cryptic Command"),(4, "Fact or Fiction"),(4, "Fatal Push"),(3, "Force of Negation"),(4, "Growth Spiral"),(2, "Nexus of Fate"),(4, "Remand"),(4, "Arcum's Astrolabe"),(1, "Search for Azcanta"),(4, "Wilderness Reclamation"),(2, "Breeding Pool"),(3, "Field of Ruin"),(2, "Flooded Strand"),(3, "Misty Rainforest"),(4, "Mystic Sanctuary"),(3, "Polluted Delta"),(4, "Scalding Tarn"),(2, "Snow-Covered Forest"),(6, "Snow-Covered Island"),(1, "Snow-Covered Swamp"),(1, "Watery Grave"),(1, "Zagoth Triome") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Abrupt Decay"),(2, "Dead of Winter"),(3, "Aether Gust"),(1, "Ceremonious Rejection"),(1, "Flusterstorm"),(1, "Negate"),(3, "Shark Typhoon"),(2, "Veil of Summer"),(1, "Yorion, Sky Nomad") }; } }
    }
}