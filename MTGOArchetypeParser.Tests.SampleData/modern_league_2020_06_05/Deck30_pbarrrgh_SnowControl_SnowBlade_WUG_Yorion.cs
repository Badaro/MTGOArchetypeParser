using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05
{
    public class Deck30_pbarrrgh_SnowControl_SnowBlade_WUG_Yorion : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Teferi, Hero of Dominaria"),(4, "Teferi, Time Raveler"),(4, "Ice-Fang Coatl"),(4, "Stoneforge Mystic"),(4, "Uro, Titan of Nature's Wrath"),(2, "Supreme Verdict"),(2, "Aether Gust"),(1, "Archmage's Charm"),(4, "Cryptic Command"),(4, "Force of Negation"),(2, "Mana Leak"),(4, "Path to Exile"),(4, "Arcum's Astrolabe"),(1, "Batterskull"),(1, "Sword of Feast and Famine"),(1, "Sword of Fire and Ice"),(4, "Abundant Growth"),(2, "Breeding Pool"),(2, "Field of Ruin"),(4, "Flooded Strand"),(2, "Hallowed Fountain"),(4, "Misty Rainforest"),(3, "Mystic Sanctuary"),(1, "Prismatic Vista"),(2, "Scalding Tarn"),(2, "Snow-Covered Forest"),(5, "Snow-Covered Island"),(2, "Snow-Covered Plains"),(1, "Temple Garden"),(2, "Windswept Heath") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Aether Gust"),(2, "Celestial Purge"),(2, "Dovin's Veto"),(3, "On Thin Ice"),(3, "Timely Reinforcements"),(2, "Veil of Summer"),(1, "Yorion, Sky Nomad") }; } }
    }
}