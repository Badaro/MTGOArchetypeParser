using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_19
{
    public class Deck27_Darkiundsa_SnowControl_WURG_Yorion : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Jace, the Mind Sculptor"),(2, "Teferi, Hero of Dominaria"),(2, "Teferi, Time Raveler"),(3, "Wrenn and Six"),(4, "Ice-Fang Coatl"),(4, "Uro, Titan of Nature's Wrath"),(2, "Supreme Verdict"),(3, "Archmage's Charm"),(2, "Cryptic Command"),(3, "Force of Negation"),(4, "Lightning Bolt"),(2, "Lightning Helix"),(4, "Path to Exile"),(4, "Arcum's Astrolabe"),(4, "Abundant Growth"),(1, "Elspeth Conquers Death"),(1, "Shark Typhoon"),(1, "Breeding Pool"),(4, "Field of Ruin"),(4, "Flooded Strand"),(1, "Hallowed Fountain"),(4, "Misty Rainforest"),(2, "Mystic Sanctuary"),(4, "Prismatic Vista"),(2, "Snow-Covered Forest"),(6, "Snow-Covered Island"),(1, "Snow-Covered Mountain"),(2, "Snow-Covered Plains"),(1, "Steam Vents"),(1, "Temple Garden") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Ashiok, Dream Render"),(4, "Blood Moon"),(4, "Timely Reinforcements"),(3, "Veil of Summer"),(1, "Yorion, Sky Nomad") }; } }
    }
}