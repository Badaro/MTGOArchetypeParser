using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck15_Madwolf87_DeathsShadow_SuicideShadow_BRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Death's Shadow"),(1, "Kroxa, Titan of Death's Hunger"),(4, "Monastery Swiftspear"),(4, "Tarmogoyf"),(1, "Crash Through"),(2, "Inquisition of Kozilek"),(4, "Thoughtseize"),(1, "Unearth"),(2, "Dismember"),(1, "Fatal Push"),(1, "Kolaghan's Command"),(4, "Lightning Bolt"),(3, "Mutagenic Growth"),(3, "Temur Battle Rage"),(4, "Mishra's Bauble"),(2, "Seal of Fire"),(2, "Blood Crypt"),(4, "Bloodstained Mire"),(1, "Forest"),(1, "Nurturing Peatland"),(2, "Overgrown Tomb"),(1, "Stomping Ground"),(1, "Swamp"),(4, "Verdant Catacombs"),(3, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Abrupt Decay"),(3, "Assassin's Trophy"),(2, "Boil"),(3, "Collective Brutality"),(2, "Kiln Fiend"),(2, "Surgical Extraction"),(2, "Veil of Summer") }; } }
    }
}