using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_23
{
    public class Deck49_Pollu_AdNauseam_WUB : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Teferi, Time Raveler"),(4, "Thassa's Oracle"),(4, "Serum Visions"),(4, "Sleight of Hand"),(4, "Angel's Grace"),(4, "Opt"),(4, "Pact of Negation"),(1, "Slaughter Pact"),(4, "Spoils of the Vault"),(4, "Arcum's Astrolabe"),(4, "Pentad Prism"),(1, "Phyrexian Unlife"),(3, "Flooded Strand"),(1, "Godless Shrine"),(1, "Hallowed Fountain"),(3, "Polluted Delta"),(4, "Prismatic Vista"),(5, "Snow-Covered Island"),(1, "Snow-Covered Plains"),(1, "Snow-Covered Swamp"),(1, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Slaughter Pact"),(3, "Aether Gust"),(3, "Ceremonious Rejection"),(2, "Dead of Winter"),(4, "Leyline of Sanctity"),(2, "Mystical Dispute") }; } }
    }
}