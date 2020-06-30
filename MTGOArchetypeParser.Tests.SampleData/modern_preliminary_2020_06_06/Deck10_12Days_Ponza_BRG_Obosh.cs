using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_06
{
    public class Deck10_12Days_Ponza_BRG_Obosh : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Lukka, Coppercoat Outcast"),(4, "Arbor Elf"),(3, "Bonecrusher Giant"),(1, "Emrakul, the Aeons Torn"),(3, "Klothys, God of Destiny"),(4, "Magus of the Moon"),(3, "Planebound Accomplice"),(4, "Seasoned Pyromancer"),(3, "Unearth"),(2, "Kolaghan's Command"),(4, "Lightning Bolt"),(4, "Utopia Sprawl"),(1, "Blood Crypt"),(6, "Forest"),(1, "Overgrown Tomb"),(3, "Stomping Ground"),(3, "Verdant Catacombs"),(3, "Windswept Heath"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Anger of the Gods"),(2, "Natural State"),(1, "Obosh, the Preypiercer"),(2, "Pillage"),(2, "Relic of Progenitus"),(2, "Thoughtseize"),(2, "Veil of Summer"),(2, "Weather the Storm") }; } }
    }
}