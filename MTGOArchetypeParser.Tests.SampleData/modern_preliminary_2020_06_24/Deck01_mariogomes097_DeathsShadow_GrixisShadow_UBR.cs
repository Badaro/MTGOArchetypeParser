using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_24
{
    public class Deck01_mariogomes097_DeathsShadow_GrixisShadow_UBR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "The Royal Scions"),(4, "Death's Shadow"),(4, "Gurmag Angler"),(2, "Snapcaster Mage"),(1, "Sprite Dragon"),(4, "Street Wraith"),(2, "Inquisition of Kozilek"),(4, "Thoughtseize"),(2, "Cling to Dust"),(2, "Dismember"),(2, "Drown in the Loch"),(2, "Fatal Push"),(1, "Kolaghan's Command"),(2, "Lightning Bolt"),(4, "Stubborn Denial"),(2, "Temur Battle Rage"),(4, "Thought Scour"),(2, "Blood Crypt"),(4, "Bloodstained Mire"),(1, "Island"),(1, "Marsh Flats"),(4, "Polluted Delta"),(1, "Scalding Tarn"),(1, "Steam Vents"),(1, "Swamp"),(2, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Sprite Dragon"),(2, "Cling to Dust"),(1, "Fatal Push"),(1, "The Royal Scions"),(2, "Abrade"),(1, "Collective Brutality"),(2, "Disdainful Stroke"),(1, "Duress"),(2, "Mana Leak"),(2, "Nihil Spellbomb") }; } }
    }
}