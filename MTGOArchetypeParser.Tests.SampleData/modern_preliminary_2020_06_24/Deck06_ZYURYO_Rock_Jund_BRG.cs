using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_24
{
    public class Deck06_ZYURYO_Rock_Jund_BRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Liliana of the Veil"),(3, "Wrenn and Six"),(2, "Kroxa, Titan of Death's Hunger"),(2, "Scavenging Ooze"),(4, "Tarmogoyf"),(4, "Inquisition of Kozilek"),(2, "Thoughtseize"),(2, "Assassin's Trophy"),(1, "Fatal Push"),(2, "Kolaghan's Command"),(4, "Lightning Bolt"),(4, "Mishra's Bauble"),(1, "Nihil Spellbomb"),(1, "Seal of Fire"),(3, "Blackcleave Cliffs"),(1, "Blood Crypt"),(4, "Bloodstained Mire"),(1, "Forest"),(1, "Mountain"),(1, "Nurturing Peatland"),(2, "Overgrown Tomb"),(2, "Raging Ravine"),(1, "Stomping Ground"),(2, "Swamp"),(4, "Verdant Catacombs"),(2, "Lurrus of the Dream-Den") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Fatal Push"),(1, "Nihil Spellbomb"),(2, "Ashiok, Dream Render"),(2, "Choke"),(2, "Collective Brutality"),(1, "Klothys, God of Destiny"),(1, "Liliana, the Last Hope"),(1, "Maelstrom Pulse"),(2, "Pillage"),(2, "Plague Engineer") }; } }
    }
}