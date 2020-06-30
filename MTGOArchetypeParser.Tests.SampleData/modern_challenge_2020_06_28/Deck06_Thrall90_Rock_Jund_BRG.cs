using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_28
{
    public class Deck06_Thrall90_Rock_Jund_BRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Wrenn and Six"),(4, "Bloodbraid Elf"),(1, "Dark Confidant"),(2, "Scavenging Ooze"),(4, "Tarmogoyf"),(4, "Inquisition of Kozilek"),(2, "Thoughtseize"),(2, "Fatal Push"),(2, "Kolaghan's Command"),(4, "Lightning Bolt"),(3, "Terminate"),(4, "Mishra's Bauble"),(3, "Blackcleave Cliffs"),(1, "Blood Crypt"),(4, "Bloodstained Mire"),(3, "Nurturing Peatland"),(1, "Overgrown Tomb"),(2, "Raging Ravine"),(1, "Snow-Covered Forest"),(1, "Snow-Covered Mountain"),(2, "Snow-Covered Swamp"),(1, "Stomping Ground"),(4, "Verdant Catacombs"),(2, "Lurrus of the Dream-Den") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Terminate"),(3, "Ashiok, Dream Render"),(3, "Boil"),(3, "Collective Brutality"),(2, "Maelstrom Pulse"),(1, "Nihil Spellbomb"),(2, "Tectonic Edge") }; } }
    }
}