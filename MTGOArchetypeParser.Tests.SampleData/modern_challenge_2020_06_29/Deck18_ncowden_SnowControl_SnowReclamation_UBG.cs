using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_29
{
    public class Deck18_ncowden_SnowControl_SnowReclamation_UBG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Jace, the Mind Sculptor"),(4, "Ice-Fang Coatl"),(3, "Uro, Titan of Nature's Wrath"),(2, "Dead of Winter"),(1, "Abrupt Decay"),(3, "Archmage's Charm"),(3, "Cryptic Command"),(3, "Fact or Fiction"),(3, "Fatal Push"),(2, "Force of Negation"),(1, "Nexus of Fate"),(3, "Remand"),(4, "Arcum's Astrolabe"),(2, "Wilderness Reclamation"),(1, "Breeding Pool"),(3, "Flooded Strand"),(4, "Misty Rainforest"),(3, "Mystic Sanctuary"),(3, "Polluted Delta"),(2, "Snow-Covered Forest"),(7, "Snow-Covered Island"),(1, "Watery Grave"),(1, "Zagoth Triome") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Fatal Push"),(3, "Aether Gust"),(2, "Ashiok, Dream Render"),(1, "Assassin's Trophy"),(2, "Collective Brutality"),(2, "Engineered Explosives"),(1, "Negate"),(1, "Surgical Extraction"),(2, "Veil of Summer") }; } }
    }
}