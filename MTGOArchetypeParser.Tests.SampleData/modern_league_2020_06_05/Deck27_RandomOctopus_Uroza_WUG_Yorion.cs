using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05
{
    public class Deck27_RandomOctopus_Uroza_WUG_Yorion : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Emry, Lurker of the Loch"),(4, "Gilded Goose"),(4, "Ice-Fang Coatl"),(4, "Thraben Inspector"),(3, "Uro, Titan of Nature's Wrath"),(4, "Urza, Lord High Artificer"),(3, "Wall of Blossoms"),(4, "Cryptic Command"),(3, "Ephemerate"),(4, "Metallic Rebuke"),(3, "Path to Exile"),(4, "Arcum's Astrolabe"),(2, "Engineered Explosives"),(4, "Mishra's Bauble"),(2, "Soul-Guide Lantern"),(2, "Breeding Pool"),(4, "Flooded Strand"),(1, "Hallowed Fountain"),(4, "Misty Rainforest"),(4, "Mystic Sanctuary"),(4, "Polluted Delta"),(1, "Snow-Covered Forest"),(7, "Snow-Covered Island"),(1, "Snow-Covered Plains") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Aether Gust"),(2, "Ashiok, Dream Render"),(2, "Celestial Purge"),(2, "Ceremonious Rejection"),(2, "Damping Sphere"),(1, "Supreme Verdict"),(2, "Teferi, Time Raveler"),(1, "Yorion, Sky Nomad") }; } }
    }
}