using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_29
{
    public class Deck14_Voltzwagon_Ponza_RG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Chandra, Torch of Defiance"),(3, "Wrenn and Six"),(4, "Arbor Elf"),(4, "Bloodbraid Elf"),(2, "Bonecrusher Giant"),(4, "Glorybringer"),(3, "Klothys, God of Destiny"),(4, "Magus of the Moon"),(2, "Scavenging Ooze"),(4, "Seasoned Pyromancer"),(4, "Lightning Bolt"),(4, "Utopia Sprawl"),(5, "Forest"),(1, "Misty Rainforest"),(1, "Mountain"),(4, "Stomping Ground"),(1, "Tranquil Thicket"),(1, "Verdant Catacombs"),(3, "Windswept Heath"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Abrade"),(2, "Boil"),(1, "Chandra's Defeat"),(1, "Grafdigger's Cage"),(1, "Obstinate Baloth"),(3, "Pillage"),(3, "Relic of Progenitus"),(2, "Tireless Tracker") }; } }
    }
}