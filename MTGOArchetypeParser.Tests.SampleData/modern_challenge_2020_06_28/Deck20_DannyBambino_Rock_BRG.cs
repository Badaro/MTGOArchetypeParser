using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_28
{
    public class Deck20_DannyBambino_Rock_BRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Liliana of the Veil"),(3, "Wrenn and Six"),(2, "Dark Confidant"),(2, "Kroxa, Titan of Death's Hunger"),(2, "Scavenging Ooze"),(4, "Tarmogoyf"),(4, "Inquisition of Kozilek"),(2, "Thoughtseize"),(2, "Assassin's Trophy"),(3, "Fatal Push"),(2, "Kolaghan's Command"),(4, "Mishra's Bauble"),(2, "Seal of Fire"),(1, "Barren Moor"),(4, "Blackcleave Cliffs"),(1, "Blood Crypt"),(2, "Bloodstained Mire"),(1, "Copperline Gorge"),(1, "Forest"),(1, "Mountain"),(1, "Nurturing Peatland"),(1, "Overgrown Tomb"),(1, "Stomping Ground"),(1, "Swamp"),(1, "Twilight Mire"),(4, "Verdant Catacombs"),(2, "Wooded Foothills"),(3, "Lurrus of the Dream-Den") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Ashiok, Dream Render"),(2, "Boil"),(2, "Collective Brutality"),(2, "Engineered Explosives"),(1, "Klothys, God of Destiny"),(2, "Nihil Spellbomb"),(3, "Pillage"),(1, "Weather the Storm") }; } }
    }
}