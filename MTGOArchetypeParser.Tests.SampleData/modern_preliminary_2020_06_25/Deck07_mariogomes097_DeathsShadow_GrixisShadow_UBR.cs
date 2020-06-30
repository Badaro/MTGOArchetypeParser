using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_25
{
    public class Deck07_mariogomes097_DeathsShadow_GrixisShadow_UBR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "The Royal Scions"),(1, "Bonecrusher Giant"),(4, "Death's Shadow"),(4, "Gurmag Angler"),(1, "Snapcaster Mage"),(4, "Street Wraith"),(2, "Inquisition of Kozilek"),(4, "Thoughtseize"),(2, "Cling to Dust"),(2, "Dismember"),(2, "Drown in the Loch"),(3, "Fatal Push"),(1, "Kolaghan's Command"),(1, "Lightning Bolt"),(4, "Stubborn Denial"),(2, "Temur Battle Rage"),(4, "Thought Scour"),(2, "Blood Crypt"),(4, "Bloodstained Mire"),(1, "Island"),(2, "Marsh Flats"),(4, "Polluted Delta"),(1, "Scalding Tarn"),(1, "Steam Vents"),(1, "Swamp"),(2, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Bonecrusher Giant"),(1, "Snapcaster Mage"),(2, "Cling to Dust"),(1, "Fatal Push"),(1, "Kolaghan's Command"),(1, "The Royal Scions"),(2, "Abrade"),(1, "Collective Brutality"),(1, "Duress"),(2, "Mana Leak"),(2, "Nihil Spellbomb") }; } }
    }
}