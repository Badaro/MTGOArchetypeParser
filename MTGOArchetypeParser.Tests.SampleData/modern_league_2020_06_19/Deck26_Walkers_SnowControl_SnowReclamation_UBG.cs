using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_19
{
    public class Deck26_Walkers_SnowControl_SnowReclamation_UBG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Jace, the Mind Sculptor"),(3, "Ice-Fang Coatl"),(3, "Uro, Titan of Nature's Wrath"),(2, "Dead of Winter"),(1, "Abrupt Decay"),(3, "Archmage's Charm"),(3, "Cryptic Command"),(1, "Drown in the Loch"),(3, "Fact or Fiction"),(3, "Fatal Push"),(2, "Force of Negation"),(1, "Nexus of Fate"),(3, "Remand"),(4, "Arcum's Astrolabe"),(2, "Wilderness Reclamation"),(1, "Breeding Pool"),(3, "Flooded Strand"),(4, "Misty Rainforest"),(3, "Mystic Sanctuary"),(3, "Polluted Delta"),(2, "Snow-Covered Forest"),(7, "Snow-Covered Island"),(1, "Watery Grave"),(1, "Zagoth Triome") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Aether Gust"),(2, "Ashiok, Dream Render"),(2, "Collective Brutality"),(2, "Engineered Explosives"),(1, "Pithing Needle"),(3, "Veil of Summer"),(2, "Weather the Storm") }; } }
    }
}