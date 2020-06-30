using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_23
{
    public class Deck09_Somniloquist_DeathsShadow_SuicideShadow_BRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Death's Shadow"),(2, "Kroxa, Titan of Death's Hunger"),(4, "Monastery Swiftspear"),(4, "Street Wraith"),(4, "Tarmogoyf"),(4, "Thoughtseize"),(2, "Traverse the Ulvenwald"),(2, "Become Immense"),(2, "Dismember"),(4, "Lightning Bolt"),(3, "Mutagenic Growth"),(3, "Temur Battle Rage"),(4, "Mishra's Bauble"),(2, "Blood Crypt"),(4, "Bloodstained Mire"),(1, "Forest"),(1, "Nurturing Peatland"),(2, "Overgrown Tomb"),(1, "Stomping Ground"),(1, "Swamp"),(4, "Verdant Catacombs"),(2, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Ancient Grudge"),(1, "Assassin's Trophy"),(3, "Collective Brutality"),(1, "Duress"),(2, "Fatal Push"),(1, "Kolaghan's Command"),(1, "Liliana of the Veil"),(2, "Nihil Spellbomb"),(3, "Veil of Summer") }; } }
    }
}