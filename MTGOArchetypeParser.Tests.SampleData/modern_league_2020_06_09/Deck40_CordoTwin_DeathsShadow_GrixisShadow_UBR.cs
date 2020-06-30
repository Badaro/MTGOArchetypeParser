using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck40_CordoTwin_DeathsShadow_GrixisShadow_UBR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Death's Shadow"),(4, "Gurmag Angler"),(1, "Kroxa, Titan of Death's Hunger"),(2, "Snapcaster Mage"),(4, "Street Wraith"),(2, "Inquisition of Kozilek"),(4, "Thoughtseize"),(2, "Cling to Dust"),(2, "Dismember"),(1, "Drown in the Loch"),(3, "Fatal Push"),(4, "Stubborn Denial"),(2, "Temur Battle Rage"),(4, "Thought Scour"),(4, "Mishra's Bauble"),(2, "Blood Crypt"),(4, "Bloodstained Mire"),(1, "Island"),(4, "Polluted Delta"),(2, "Scalding Tarn"),(1, "Steam Vents"),(1, "Swamp"),(2, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Drown in the Loch"),(2, "Aether Gust"),(2, "Collective Brutality"),(3, "Disdainful Stroke"),(2, "Kolaghan's Command"),(1, "Lightning Bolt"),(2, "Mystical Dispute"),(1, "Nihil Spellbomb"),(1, "The Royal Scions") }; } }
    }
}