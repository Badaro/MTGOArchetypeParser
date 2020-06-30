using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05
{
    public class Deck41_JouNick_DeathsShadow_SuicideShadow_BRG_Lurrus : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Death's Shadow"),(4, "Monastery Swiftspear"),(4, "Tarmogoyf"),(2, "Crash Through"),(1, "Inquisition of Kozilek"),(4, "Thoughtseize"),(1, "Unearth"),(3, "Cling to Dust"),(2, "Dismember"),(1, "Fatal Push"),(4, "Lightning Bolt"),(3, "Mutagenic Growth"),(2, "Temur Battle Rage"),(4, "Mishra's Bauble"),(2, "Seal of Fire"),(2, "Blood Crypt"),(4, "Bloodstained Mire"),(1, "Forest"),(1, "Nurturing Peatland"),(2, "Overgrown Tomb"),(1, "Stomping Ground"),(1, "Swamp"),(4, "Verdant Catacombs"),(3, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Temur Battle Rage"),(1, "Unearth"),(3, "Assassin's Trophy"),(3, "Collective Brutality"),(3, "Kiln Fiend"),(1, "Lurrus of the Dream Den"),(2, "Nihil Spellbomb"),(1, "Veil of Summer") }; } }
    }
}