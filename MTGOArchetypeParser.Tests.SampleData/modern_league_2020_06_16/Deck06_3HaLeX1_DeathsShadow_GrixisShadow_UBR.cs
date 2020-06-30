using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck06_3HaLeX1_DeathsShadow_GrixisShadow_UBR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Death's Shadow"),(4, "Gurmag Angler"),(2, "Snapcaster Mage"),(4, "Street Wraith"),(2, "Inquisition of Kozilek"),(4, "Thoughtseize"),(2, "Cling to Dust"),(2, "Dismember"),(1, "Drown in the Loch"),(4, "Fatal Push"),(4, "Stubborn Denial"),(2, "Temur Battle Rage"),(4, "Thought Scour"),(4, "Mishra's Bauble"),(2, "Blood Crypt"),(4, "Bloodstained Mire"),(1, "Island"),(4, "Polluted Delta"),(2, "Scalding Tarn"),(1, "Steam Vents"),(1, "Swamp"),(2, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Drown in the Loch"),(1, "Aether Gust"),(1, "Ceremonious Rejection"),(3, "Collective Brutality"),(2, "Damping Sphere"),(2, "Disdainful Stroke"),(1, "Engineered Explosives"),(1, "Force of Negation"),(2, "Kolaghan's Command"),(1, "Nihil Spellbomb") }; } }
    }
}