using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05
{
    public class Deck19_Lcario_DeathsShadow_MarduShadow_WBR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Death's Shadow"),(1, "Gurmag Angler"),(1, "Hex Parasite"),(4, "Ranger-Captain of Eos"),(4, "Street Wraith"),(4, "Tidehollow Sculler"),(2, "Inquisition of Kozilek"),(4, "Thoughtseize"),(2, "Unearth"),(2, "Dismember"),(2, "Fatal Push"),(2, "Kolaghan's Command"),(3, "Path to Exile"),(2, "Temur Battle Rage"),(4, "Mishra's Bauble"),(2, "Arid Mesa"),(1, "Blood Crypt"),(3, "Bloodstained Mire"),(2, "Godless Shrine"),(4, "Marsh Flats"),(1, "Plains"),(1, "Sacred Foundry"),(4, "Silent Clearing"),(1, "Swamp") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Fatal Push"),(1, "Kolaghan's Command"),(2, "Ashiok, Dream Render"),(1, "Collective Brutality"),(2, "Damping Sphere"),(1, "Duress"),(2, "Gideon, Ally of Zendikar"),(2, "Kaya's Guile"),(1, "Plague Engineer"),(2, "Rest in Peace") }; } }
    }
}