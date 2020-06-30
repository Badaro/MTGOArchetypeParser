using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05
{
    public class Deck32_HypnoticaL_Prowess_RakdosProwess_BR_Lurrus : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Abbot of Keral Keep"),(2, "Kiln Fiend"),(4, "Monastery Swiftspear"),(4, "Soul-Scar Mage"),(2, "Inquisition of Kozilek"),(2, "Thoughtseize"),(4, "Cling to Dust"),(2, "Fatal Push"),(1, "Kolaghan's Command"),(2, "Lava Dart"),(4, "Lightning Bolt"),(4, "Manamorphose"),(4, "Mishra's Bauble"),(2, "Seal of Fire"),(4, "Blackcleave Cliffs"),(2, "Blood Crypt"),(4, "Bloodstained Mire"),(3, "Mountain"),(2, "Sunbaked Canyon"),(1, "Swamp"),(3, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Fatal Push"),(1, "Kolaghan's Command"),(3, "Collective Brutality"),(1, "Lurrus of the Dream Den"),(3, "Molten Rain"),(2, "Nihil Spellbomb"),(2, "Smash to Smithereens"),(1, "Unearth") }; } }
    }
}