using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck63_marcofabrizi_SnowControl_SnowTurns_URG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Jace, the Mind Sculptor"),(3, "Tamiyo, Collector of Tales"),(3, "Wrenn and Six"),(4, "Arbor Elf"),(4, "Ice-Fang Coatl"),(3, "Uro, Titan of Nature's Wrath"),(1, "Entrancing Melody"),(4, "Time Warp"),(3, "Lightning Bolt"),(4, "Remand"),(3, "Arcum's Astrolabe"),(4, "Utopia Sprawl"),(1, "Breeding Pool"),(4, "Misty Rainforest"),(4, "Prismatic Vista"),(3, "Snow-Covered Forest"),(3, "Snow-Covered Island"),(1, "Snow-Covered Mountain"),(1, "Steam Vents"),(1, "Stomping Ground"),(3, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Entrancing Melody"),(1, "Lightning Bolt"),(2, "Aether Gust"),(2, "Ashiok, Dream Render"),(1, "Blood Moon"),(1, "Force of Vigor"),(3, "Veil of Summer"),(2, "Voracious Hydra"),(1, "Weather the Storm"),(1, "Wilt") }; } }
    }
}