using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12
{
    public class Deck41_Boland_DeathsShadow_GrixisShadow_UBR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Death's Shadow"),(4, "Gurmag Angler"),(3, "Snapcaster Mage"),(4, "Street Wraith"),(2, "Inquisition of Kozilek"),(4, "Thoughtseize"),(2, "Dismember"),(1, "Drown in the Loch"),(2, "Fatal Push"),(1, "Kolaghan's Command"),(1, "Lightning Bolt"),(1, "Opt"),(4, "Stubborn Denial"),(2, "Temur Battle Rage"),(4, "Thought Scour"),(4, "Mishra's Bauble"),(1, "Blood Crypt"),(4, "Bloodstained Mire"),(4, "Polluted Delta"),(3, "Scalding Tarn"),(1, "Snow-Covered Island"),(1, "Snow-Covered Swamp"),(1, "Steam Vents"),(2, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Kolaghan's Command"),(1, "Aether Gust"),(1, "Ceremonious Rejection"),(1, "Cling to Dust"),(4, "Collective Brutality"),(2, "Disdainful Stroke"),(1, "Leyline of the Void"),(2, "Mystical Dispute"),(2, "Plague Engineer") }; } }
    }
}