using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_19
{
    public class Deck23_Magric_Skelementals_BR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Liliana of the Veil"),(3, "Dark Confidant"),(1, "Dreadhorde Arcanist"),(2, "Kroxa, Titan of Death's Hunger"),(4, "Lightning Skelemental"),(4, "Seasoned Pyromancer"),(1, "Dreadbore"),(4, "Inquisition of Kozilek"),(2, "Thoughtseize"),(3, "Unearth"),(2, "Cling to Dust"),(2, "Fatal Push"),(3, "Kolaghan's Command"),(4, "Lightning Bolt"),(3, "Blackcleave Cliffs"),(3, "Blood Crypt"),(4, "Bloodstained Mire"),(1, "Castle Embereth"),(1, "Castle Locthwain"),(1, "Ghost Quarter"),(4, "Polluted Delta"),(2, "Snow-Covered Mountain"),(3, "Snow-Covered Swamp") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Anger of the Gods"),(2, "Ashiok, Dream Render"),(1, "Blood Moon"),(2, "Boil"),(2, "Fulminator Mage"),(3, "Nihil Spellbomb"),(2, "Pillage"),(2, "Plague Engineer") }; } }
    }
}