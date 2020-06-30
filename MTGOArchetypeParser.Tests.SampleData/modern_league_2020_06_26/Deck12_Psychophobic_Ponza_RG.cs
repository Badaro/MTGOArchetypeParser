using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26
{
    public class Deck12_Psychophobic_Ponza_RG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Domri, Anarch of Bolas"),(2, "Kiora, Behemoth Beckoner"),(4, "Arbor Elf"),(1, "Birds of Paradise"),(4, "Bloodbraid Elf"),(4, "Bonecrusher Giant"),(2, "Glorybringer"),(2, "Klothys, God of Destiny"),(4, "Magus of the Moon"),(2, "Ox of Agonas"),(1, "Questing Beast"),(4, "Seasoned Pyromancer"),(4, "Vengevine"),(4, "Utopia Sprawl"),(8, "Forest"),(1, "Kessig Wolf Run"),(1, "Mountain"),(3, "Stomping Ground"),(4, "Windswept Heath"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Cindervines"),(2, "Collector Ouphe"),(1, "Fracturing Gust"),(2, "Obstinate Baloth"),(1, "Ruric Thar, the Unbowed"),(2, "Slagstorm"),(2, "Trinisphere"),(3, "Wheel of Sun and Moon") }; } }
    }
}