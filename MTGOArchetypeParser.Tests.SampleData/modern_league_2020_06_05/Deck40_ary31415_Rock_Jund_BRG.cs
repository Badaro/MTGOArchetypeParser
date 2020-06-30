using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05
{
    public class Deck40_ary31415_Rock_Jund_BRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Liliana of the Veil"),(3, "Wrenn and Six"),(4, "Bloodbraid Elf"),(2, "Kroxa, Titan of Death's Hunger"),(2, "Scavenging Ooze"),(4, "Tarmogoyf"),(4, "Inquisition of Kozilek"),(1, "Maelstrom Pulse"),(2, "Thoughtseize"),(1, "Abrupt Decay"),(2, "Assassin's Trophy"),(2, "Fatal Push"),(2, "Kolaghan's Command"),(4, "Lightning Bolt"),(1, "Barren Moor"),(4, "Blackcleave Cliffs"),(1, "Blood Crypt"),(3, "Bloodstained Mire"),(1, "Forest"),(1, "Mountain"),(1, "Nurturing Peatland"),(2, "Overgrown Tomb"),(2, "Raging Ravine"),(1, "Stomping Ground"),(2, "Swamp"),(4, "Verdant Catacombs"),(1, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Ashiok, Dream Render"),(2, "Collective Brutality"),(2, "Fulminator Mage"),(2, "Grafdigger's Cage"),(1, "Huntmaster of the Fells"),(2, "Pillage"),(2, "Plague Engineer"),(2, "Weather the Storm") }; } }
    }
}