using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck50_TubbyBatman_Delver_TemurDelver_URG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Delver of Secrets"),(4, "Hooting Mandrills"),(3, "Stormwing Entity"),(3, "Tarmogoyf"),(4, "Serum Visions"),(2, "Force of Negation"),(4, "Lightning Bolt"),(4, "Manamorphose"),(2, "Mutagenic Growth"),(4, "Opt"),(4, "Stubborn Denial"),(4, "Thought Scour"),(1, "Vapor Snag"),(1, "Botanical Sanctum"),(1, "Breeding Pool"),(1, "Forest"),(2, "Island"),(4, "Misty Rainforest"),(4, "Scalding Tarn"),(2, "Spirebluff Canal"),(1, "Steam Vents"),(1, "Stomping Ground") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Aether Gust"),(2, "Alpine Moon"),(2, "Engineered Explosives"),(2, "Feed the Clan"),(3, "Great Sable Stag"),(2, "Surgical Extraction"),(2, "Veil of Summer") }; } }
    }
}