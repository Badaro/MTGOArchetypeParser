using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck30_NagatoBoran_Rock_Jund_BRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Liliana of the Veil"),(3, "Wrenn and Six"),(4, "Bloodbraid Elf"),(2, "Kroxa, Titan of Death's Hunger"),(2, "Scavenging Ooze"),(4, "Tarmogoyf"),(4, "Inquisition of Kozilek"),(1, "Maelstrom Pulse"),(2, "Thoughtseize"),(2, "Assassin's Trophy"),(2, "Fatal Push"),(2, "Kolaghan's Command"),(4, "Lightning Bolt"),(1, "Barren Moor"),(4, "Blackcleave Cliffs"),(1, "Blood Crypt"),(3, "Bloodstained Mire"),(1, "Forest"),(1, "Mountain"),(1, "Nurturing Peatland"),(2, "Overgrown Tomb"),(2, "Raging Ravine"),(1, "Stomping Ground"),(2, "Swamp"),(4, "Verdant Catacombs"),(1, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Ashiok, Dream Render"),(2, "Boil"),(3, "Collective Brutality"),(1, "Liliana, the Last Hope"),(2, "Nihil Spellbomb"),(3, "Pillage"),(2, "Veil of Summer"),(1, "Weather the Storm") }; } }
    }
}