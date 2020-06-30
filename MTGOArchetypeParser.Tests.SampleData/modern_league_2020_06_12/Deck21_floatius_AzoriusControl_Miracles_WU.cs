using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12
{
    public class Deck21_floatius_AzoriusControl_Miracles_WU : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Jace, the Mind Sculptor"),(2, "Teferi, Time Raveler"),(3, "Snapcaster Mage"),(4, "Stoneforge Mystic"),(4, "Terminus"),(3, "Archmage's Charm"),(4, "Cryptic Command"),(2, "Mana Leak"),(4, "Opt"),(4, "Path to Exile"),(1, "Batterskull"),(1, "Sword of Feast and Famine"),(4, "Celestial Colonnade"),(4, "Flooded Strand"),(2, "Hallowed Fountain"),(3, "Mystic Sanctuary"),(3, "Polluted Delta"),(3, "Scalding Tarn"),(5, "Snow-Covered Island"),(1, "Snow-Covered Plains") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (4, "Aether Gust"),(4, "Mystical Dispute"),(3, "Oust"),(4, "Timely Reinforcements") }; } }
    }
}