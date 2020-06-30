using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck13_Simarisu_DeathsShadow_MarduShadow_WB : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Death's Shadow"),(1, "Giver of Runes"),(1, "Gurmag Angler"),(4, "Ranger-Captain of Eos"),(3, "Stoneforge Mystic"),(4, "Street Wraith"),(4, "Tidehollow Sculler"),(1, "Collective Brutality"),(4, "Inquisition of Kozilek"),(4, "Thoughtseize"),(1, "Unearth"),(1, "Anguished Unmaking"),(1, "Dismember"),(4, "Fatal Push"),(1, "Sword of Feast and Famine"),(1, "Sword of Fire and Ice"),(3, "Arid Mesa"),(3, "Bloodstained Mire"),(4, "Godless Shrine"),(4, "Marsh Flats"),(1, "Plains"),(4, "Silent Clearing"),(2, "Swamp") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Collective Brutality"),(1, "Batterskull"),(1, "Burrenton Forge-Tender"),(2, "Celestial Purge"),(2, "Damping Sphere"),(1, "Kaya, Orzhov Usurper"),(2, "Kaya's Guile"),(1, "Liliana, the Last Hope"),(1, "Plague Engineer"),(3, "Rest in Peace") }; } }
    }
}