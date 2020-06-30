using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12
{
    public class Deck20_B1gDan_DeathsShadow_MarduShadow_WBR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Dark Confidant"),(4, "Death's Shadow"),(2, "Giver of Runes"),(4, "Ranger-Captain of Eos"),(4, "Street Wraith"),(4, "Tidehollow Sculler"),(4, "Inquisition of Kozilek"),(4, "Thoughtseize"),(1, "Anguished Unmaking"),(2, "Dismember"),(3, "Fatal Push"),(2, "Kolaghan's Command"),(2, "Lightning Bolt"),(2, "Temur Battle Rage"),(2, "Arid Mesa"),(2, "Blood Crypt"),(4, "Bloodstained Mire"),(3, "Godless Shrine"),(4, "Marsh Flats"),(1, "Plains"),(1, "Sacred Foundry"),(2, "Silent Clearing"),(1, "Swamp") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Boil"),(1, "Celestial Purge"),(3, "Fulminator Mage"),(1, "Kaya, Orzhov Usurper"),(3, "Kaya's Guile"),(1, "Plague Engineer"),(3, "Surgical Extraction"),(1, "Wear // Tear") }; } }
    }
}