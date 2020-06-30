using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_20
{
    public class Deck11_Logic_DeathsShadow_BR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Liliana of the Veil"),(4, "Death's Shadow"),(3, "Dreadhorde Arcanist"),(2, "Kroxa, Titan of Death's Hunger"),(4, "Lightning Skelemental"),(4, "Street Wraith"),(4, "Inquisition of Kozilek"),(4, "Thoughtseize"),(2, "Unearth"),(2, "Cling to Dust"),(2, "Dismember"),(2, "Fatal Push"),(2, "Kolaghan's Command"),(3, "Lightning Bolt"),(2, "Arid Mesa"),(4, "Blood Crypt"),(4, "Bloodstained Mire"),(1, "Castle Locthwain"),(4, "Marsh Flats"),(1, "Mountain"),(2, "Sulfurous Springs"),(2, "Swamp") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Blood Moon"),(2, "Collective Brutality"),(2, "Fulminator Mage"),(2, "Liliana, the Last Hope"),(3, "Nihil Spellbomb"),(2, "Plague Engineer"),(2, "Temur Battle Rage") }; } }
    }
}