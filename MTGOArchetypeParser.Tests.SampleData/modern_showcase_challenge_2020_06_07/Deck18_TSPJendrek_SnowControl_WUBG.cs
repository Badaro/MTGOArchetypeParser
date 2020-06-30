using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_showcase_challenge_2020_06_07
{
    public class Deck18_TSPJendrek_SnowControl_WUBG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Jace, the Mind Sculptor"),(3, "Ice-Fang Coatl"),(2, "Snapcaster Mage"),(2, "Uro, Titan of Nature's Wrath"),(2, "Dead of Winter"),(2, "Abrupt Decay"),(4, "Archmage's Charm"),(2, "Cryptic Command"),(1, "Dovin's Veto"),(4, "Fatal Push"),(3, "Force of Negation"),(2, "Kaya's Guile"),(2, "Mana Leak"),(4, "Arcum's Astrolabe"),(1, "Breeding Pool"),(2, "Field of Ruin"),(2, "Flooded Strand"),(1, "Hallowed Fountain"),(4, "Misty Rainforest"),(2, "Mystic Sanctuary"),(1, "Overgrown Tomb"),(4, "Polluted Delta"),(1, "Snow-Covered Forest"),(4, "Snow-Covered Island"),(1, "Snow-Covered Plains"),(1, "Snow-Covered Swamp"),(1, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Aether Gust"),(2, "Ashiok, Dream Render"),(1, "Engineered Explosives"),(1, "Monastery Mentor"),(2, "Mystical Dispute"),(2, "Nihil Spellbomb"),(2, "Notion Thief"),(1, "Timely Reinforcements"),(2, "Veil of Summer") }; } }
    }
}