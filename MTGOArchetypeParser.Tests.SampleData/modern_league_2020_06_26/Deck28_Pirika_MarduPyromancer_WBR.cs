using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26
{
    public class Deck28_Pirika_MarduPyromancer_WBR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Kaya, Orzhov Usurper"),(4, "Seasoned Pyromancer"),(4, "Young Pyromancer"),(3, "Inquisition of Kozilek"),(4, "Lingering Souls"),(2, "Ransack the Lab"),(4, "Smallpox"),(4, "Thoughtseize"),(4, "Cling to Dust"),(2, "Kaya's Guile"),(2, "Kolaghan's Command"),(4, "Lightning Bolt"),(4, "Blackcleave Cliffs"),(2, "Blood Crypt"),(4, "Bloodstained Mire"),(1, "Castle Locthwain"),(1, "Godless Shrine"),(4, "Marsh Flats"),(1, "Plains"),(1, "Sacred Foundry"),(1, "Swamp"),(1, "Urborg, Tomb of Yawgmoth") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Ashiok, Dream Render"),(2, "Bedevil"),(3, "Damping Sphere"),(3, "Ensnaring Bridge"),(3, "Fatal Push"),(2, "Nihil Spellbomb") }; } }
    }
}