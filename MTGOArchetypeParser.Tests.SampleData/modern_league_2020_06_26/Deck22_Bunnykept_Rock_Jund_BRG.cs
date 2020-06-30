using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26
{
    public class Deck22_Bunnykept_Rock_Jund_BRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Liliana of the Veil"),(3, "Wrenn and Six"),(4, "Bloodbraid Elf"),(1, "Dark Confidant"),(2, "Kroxa, Titan of Death's Hunger"),(2, "Scavenging Ooze"),(4, "Tarmogoyf"),(4, "Inquisition of Kozilek"),(1, "Maelstrom Pulse"),(2, "Thoughtseize"),(1, "Abrupt Decay"),(2, "Fatal Push"),(2, "Kolaghan's Command"),(4, "Lightning Bolt"),(1, "Terminate"),(2, "Barren Moor"),(3, "Blackcleave Cliffs"),(1, "Blood Crypt"),(3, "Bloodstained Mire"),(1, "Forest"),(1, "Mountain"),(1, "Nurturing Peatland"),(2, "Overgrown Tomb"),(1, "Raging Ravine"),(1, "Stomping Ground"),(2, "Swamp"),(4, "Verdant Catacombs"),(1, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Fatal Push"),(2, "Alpine Moon"),(1, "Ashiok, Dream Render"),(2, "Boil"),(1, "Choke"),(1, "Fulminator Mage"),(1, "Grafdigger's Cage"),(1, "Huntmaster of the Fells"),(1, "Klothys, God of Destiny"),(1, "Pillage"),(1, "Plague Engineer"),(2, "Weather the Storm") }; } }
    }
}