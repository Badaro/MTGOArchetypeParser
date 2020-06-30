using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck19_Asoen_Skelementals_BR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Liliana of the Veil"),(3, "Dark Confidant"),(3, "Kroxa, Titan of Death's Hunger"),(3, "Lightning Skelemental"),(4, "Seasoned Pyromancer"),(4, "Inquisition of Kozilek"),(4, "Ransack the Lab"),(3, "Thoughtseize"),(3, "Unearth"),(2, "Cling to Dust"),(2, "Fatal Push"),(1, "Kolaghan's Command"),(4, "Lightning Bolt"),(4, "Blackcleave Cliffs"),(2, "Blood Crypt"),(4, "Bloodstained Mire"),(1, "Castle Embereth"),(1, "Castle Locthwain"),(1, "Lavaclaw Reaches"),(2, "Marsh Flats"),(2, "Mountain"),(1, "Prismatic Vista"),(3, "Swamp") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Ashiok, Dream Render"),(2, "Blood Moon"),(2, "Boil"),(2, "Collective Brutality"),(2, "Fulminator Mage"),(1, "Kalitas, Traitor of Ghet"),(2, "Nihil Spellbomb"),(2, "Plague Engineer") }; } }
    }
}