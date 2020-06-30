using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05
{
    public class Deck20_wambocombo2020_JundSmallpox_BRG_Lurrus : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Wrenn and Six"),(2, "Chevill, Bane of Monsters"),(3, "Kroxa, Titan of Death's Hunger"),(4, "Crack the Earth"),(4, "Inquisition of Kozilek"),(4, "Smallpox"),(1, "Thoughtseize"),(2, "Unearth"),(4, "Fatal Push"),(4, "Arcum's Astrolabe"),(4, "Mishra's Bauble"),(1, "Nihil Spellbomb"),(3, "Seal of Fire"),(1, "Barren Moor"),(2, "Blood Crypt"),(4, "Bloodstained Mire"),(1, "Overgrown Tomb"),(2, "Prismatic Vista"),(1, "Snow-Covered Forest"),(1, "Snow-Covered Mountain"),(1, "Snow-Covered Swamp"),(1, "Stomping Ground"),(4, "Verdant Catacombs"),(3, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Nihil Spellbomb"),(2, "Boil"),(1, "Cindervines"),(3, "Collective Brutality"),(2, "Engineered Explosives"),(1, "Lurrus of the Dream Den"),(3, "Pillage"),(1, "Veil of Summer"),(1, "Weather the Storm") }; } }
    }
}