using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_19
{
    public class Deck36_salvamala_Rock_Jund_BRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Liliana of the Veil"),(3, "Wrenn and Six"),(4, "Bloodbraid Elf"),(1, "Dark Confidant"),(2, "Scavenging Ooze"),(2, "Seasoned Pyromancer"),(4, "Tarmogoyf"),(4, "Inquisition of Kozilek"),(1, "Maelstrom Pulse"),(2, "Thoughtseize"),(1, "Abrupt Decay"),(2, "Fatal Push"),(2, "Kolaghan's Command"),(3, "Lightning Bolt"),(1, "Terminate"),(1, "Arcum's Astrolabe"),(1, "Nihil Spellbomb"),(4, "Blackcleave Cliffs"),(1, "Blood Crypt"),(3, "Bloodstained Mire"),(2, "Forest"),(1, "Nurturing Peatland"),(2, "Overgrown Tomb"),(1, "Raging Ravine"),(1, "Snow-Covered Mountain"),(2, "Snow-Covered Swamp"),(1, "Stomping Ground"),(4, "Verdant Catacombs"),(1, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Nihil Spellbomb"),(2, "Ashiok, Dream Render"),(2, "Boil"),(1, "Choke"),(3, "Collective Brutality"),(3, "Pillage"),(1, "Weather the Storm") }; } }
    }
}