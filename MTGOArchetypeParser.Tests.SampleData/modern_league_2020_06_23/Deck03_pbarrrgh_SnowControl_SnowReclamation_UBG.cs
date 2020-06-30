using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_23
{
    public class Deck03_pbarrrgh_SnowControl_SnowReclamation_UBG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Ice-Fang Coatl"),(3, "Uro, Titan of Nature's Wrath"),(1, "Dead of Winter"),(1, "Abrupt Decay"),(3, "Archmage's Charm"),(3, "Cryptic Command"),(3, "Fact or Fiction"),(3, "Fatal Push"),(3, "Force of Negation"),(1, "Nexus of Fate"),(4, "Remand"),(4, "Arcum's Astrolabe"),(2, "Wilderness Reclamation"),(2, "Breeding Pool"),(4, "Misty Rainforest"),(3, "Mystic Sanctuary"),(4, "Polluted Delta"),(2, "Snow-Covered Forest"),(7, "Snow-Covered Island"),(1, "Snow-Covered Swamp"),(1, "Watery Grave"),(1, "Zagoth Triome") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Dead of Winter"),(4, "Aether Gust"),(1, "Ashiok, Dream Render"),(2, "Ceremonious Rejection"),(2, "Collective Brutality"),(3, "Veil of Summer"),(1, "Weather the Storm") }; } }
    }
}