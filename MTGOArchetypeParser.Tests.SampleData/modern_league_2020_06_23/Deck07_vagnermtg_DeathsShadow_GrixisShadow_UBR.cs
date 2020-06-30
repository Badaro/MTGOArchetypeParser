using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_23
{
    public class Deck07_vagnermtg_DeathsShadow_GrixisShadow_UBR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Death's Shadow"),(4, "Gurmag Angler"),(2, "Snapcaster Mage"),(4, "Street Wraith"),(2, "Inquisition of Kozilek"),(4, "Thoughtseize"),(2, "Cling to Dust"),(2, "Dismember"),(2, "Drown in the Loch"),(4, "Fatal Push"),(2, "Kolaghan's Command"),(4, "Stubborn Denial"),(2, "Temur Battle Rage"),(4, "Thought Scour"),(2, "Blood Crypt"),(4, "Bloodstained Mire"),(2, "Flooded Strand"),(1, "Island"),(1, "Marsh Flats"),(4, "Polluted Delta"),(1, "Steam Vents"),(1, "Swamp"),(2, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Drown in the Loch"),(1, "Kolaghan's Command"),(1, "Anger of the Gods"),(3, "Ceremonious Rejection"),(2, "Collective Brutality"),(3, "Disdainful Stroke"),(2, "Lightning Bolt"),(2, "Terminate") }; } }
    }
}