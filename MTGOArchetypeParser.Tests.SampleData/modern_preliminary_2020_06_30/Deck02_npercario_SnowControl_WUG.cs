using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_30
{
    public class Deck02_npercario_SnowControl_WUG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Jace, the Mind Sculptor"),(2, "Teferi, Hero of Dominaria"),(2, "Teferi, Time Raveler"),(4, "Ice-Fang Coatl"),(2, "Snapcaster Mage"),(3, "Uro, Titan of Nature's Wrath"),(2, "Supreme Verdict"),(2, "Archmage's Charm"),(2, "Cryptic Command"),(3, "Force of Negation"),(3, "Mana Leak"),(4, "Path to Exile"),(4, "Arcum's Astrolabe"),(1, "Shark Typhoon"),(1, "Breeding Pool"),(4, "Field of Ruin"),(4, "Flooded Strand"),(1, "Hallowed Fountain"),(4, "Misty Rainforest"),(2, "Mystic Sanctuary"),(1, "Snow-Covered Forest"),(5, "Snow-Covered Island"),(1, "Snow-Covered Plains"),(1, "Temple Garden") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Shark Typhoon"),(2, "Aether Gust"),(3, "Ashiok, Dream Render"),(1, "Dovin's Veto"),(1, "Monastery Mentor"),(1, "Mystical Dispute"),(2, "Timely Reinforcements"),(3, "Veil of Summer") }; } }
    }
}