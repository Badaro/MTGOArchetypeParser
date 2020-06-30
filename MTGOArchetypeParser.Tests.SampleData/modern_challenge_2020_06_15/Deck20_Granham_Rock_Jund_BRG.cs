using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15
{
    public class Deck20_Granham_Rock_Jund_BRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Liliana of the Veil"),(1, "Liliana, the Last Hope"),(3, "Wrenn and Six"),(4, "Bloodbraid Elf"),(1, "Huntmaster of the Fells"),(1, "Klothys, God of Destiny"),(2, "Scavenging Ooze"),(4, "Tarmogoyf"),(1, "Tireless Tracker"),(4, "Inquisition of Kozilek"),(1, "Maelstrom Pulse"),(2, "Thoughtseize"),(1, "Abrupt Decay"),(2, "Assassin's Trophy"),(2, "Fatal Push"),(1, "Kolaghan's Command"),(4, "Lightning Bolt"),(1, "Barren Moor"),(3, "Blackcleave Cliffs"),(1, "Blood Crypt"),(2, "Bloodstained Mire"),(1, "Blooming Marsh"),(1, "Forest"),(1, "Mountain"),(1, "Nurturing Peatland"),(2, "Overgrown Tomb"),(2, "Raging Ravine"),(1, "Stomping Ground"),(2, "Swamp"),(4, "Verdant Catacombs"),(1, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Ashiok, Dream Render"),(1, "Boil"),(1, "Choke"),(1, "Collector Ouphe"),(3, "Damping Sphere"),(2, "Grafdigger's Cage"),(1, "Kalitas, Traitor of Ghet"),(1, "Kitchen Finks"),(1, "Nissa, Vital Force"),(2, "Plague Engineer") }; } }
    }
}