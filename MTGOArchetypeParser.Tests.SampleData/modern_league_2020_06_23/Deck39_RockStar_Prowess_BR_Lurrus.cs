using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_23
{
    public class Deck39_RockStar_Prowess_BR_Lurrus : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Abbot of Keral Keep"),(2, "Kroxa, Titan of Death's Hunger"),(4, "Monastery Swiftspear"),(4, "Soul-Scar Mage"),(1, "Crash Through"),(4, "Light Up the Stage"),(2, "Unearth"),(2, "Cling to Dust"),(3, "Fatal Push"),(4, "Lava Dart"),(4, "Lightning Bolt"),(4, "Mishra's Bauble"),(3, "Seal of Fire"),(1, "Arid Mesa"),(4, "Blackcleave Cliffs"),(2, "Blood Crypt"),(4, "Bloodstained Mire"),(3, "Snow-Covered Mountain"),(1, "Snow-Covered Swamp"),(3, "Sunbaked Canyon"),(1, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Angrath's Rampage"),(3, "Collective Brutality"),(1, "Lurrus of the Dream Den"),(3, "Molten Rain"),(2, "Nihil Spellbomb"),(3, "Thoughtseize") }; } }
    }
}