using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck47_TheWonderLord_Rock_Jund_BRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Liliana of the Veil"),(3, "Wrenn and Six"),(4, "Bloodbraid Elf"),(2, "Hexdrinker"),(2, "Scavenging Ooze"),(4, "Tarmogoyf"),(3, "Inquisition of Kozilek"),(1, "Maelstrom Pulse"),(3, "Thoughtseize"),(2, "Assassin's Trophy"),(2, "Fatal Push"),(2, "Kolaghan's Command"),(4, "Lightning Bolt"),(2, "Barren Moor"),(4, "Blackcleave Cliffs"),(1, "Blood Crypt"),(2, "Bloodstained Mire"),(2, "Forest"),(1, "Mountain"),(1, "Nurturing Peatland"),(1, "Overgrown Tomb"),(1, "Raging Ravine"),(1, "Stomping Ground"),(2, "Swamp"),(4, "Verdant Catacombs"),(2, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Anger of the Gods"),(2, "Ashiok, Dream Render"),(2, "Boil"),(1, "Choke"),(3, "Collective Brutality"),(2, "Huntmaster of the Fells"),(1, "Klothys, God of Destiny"),(2, "Nihil Spellbomb") }; } }
    }
}