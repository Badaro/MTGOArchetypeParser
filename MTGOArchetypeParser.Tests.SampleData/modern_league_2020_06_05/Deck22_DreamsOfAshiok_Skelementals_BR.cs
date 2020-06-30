using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05
{
    public class Deck22_DreamsOfAshiok_Skelementals_BR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Liliana of the Veil"),(3, "Dark Confidant"),(2, "Kroxa, Titan of Death's Hunger"),(4, "Lightning Skelemental"),(4, "Seasoned Pyromancer"),(1, "Dreadbore"),(4, "Inquisition of Kozilek"),(4, "Ransack the Lab"),(2, "Thoughtseize"),(3, "Unearth"),(2, "Cling to Dust"),(2, "Fatal Push"),(1, "Kolaghan's Command"),(4, "Lightning Bolt"),(4, "Blackcleave Cliffs"),(2, "Blood Crypt"),(4, "Bloodstained Mire"),(1, "Castle Embereth"),(1, "Castle Locthwain"),(1, "Lavaclaw Reaches"),(3, "Marsh Flats"),(2, "Mountain"),(2, "Prismatic Vista"),(2, "Swamp") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Ashiok, Dream Render"),(1, "Blood Moon"),(2, "Boil"),(2, "Collective Brutality"),(1, "Extinction Event"),(2, "Fulminator Mage"),(1, "Kalitas, Traitor of Ghet"),(2, "Legion's End"),(2, "Nihil Spellbomb") }; } }
    }
}