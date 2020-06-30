using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_11
{
    public class Deck06_Lirek154_AzoriusControl_WU : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Jace, the Mind Sculptor"),(1, "Narset, Parter of Veils"),(2, "Teferi, Time Raveler"),(3, "Snapcaster Mage"),(3, "Spell Queller"),(4, "Stoneforge Mystic"),(1, "Timely Reinforcements"),(2, "Cryptic Command"),(4, "Force of Negation"),(2, "Mana Leak"),(4, "Opt"),(4, "Path to Exile"),(2, "Spell Snare"),(1, "Batterskull"),(1, "Sword of Feast and Famine"),(2, "Celestial Colonnade"),(4, "Field of Ruin"),(4, "Flooded Strand"),(1, "Glacial Fortress"),(3, "Hallowed Fountain"),(5, "Island"),(1, "Mystic Sanctuary"),(2, "Plains"),(1, "Polluted Delta"),(1, "Seachrome Coast") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Timely Reinforcements"),(1, "Aether Gust"),(2, "Ashiok, Dream Render"),(2, "Celestial Purge"),(1, "Ceremonious Rejection"),(1, "Disdainful Stroke"),(1, "Disenchant"),(1, "Dovin's Veto"),(1, "Grafdigger's Cage"),(1, "Mystical Dispute"),(1, "Rest in Peace"),(1, "Supreme Verdict"),(1, "Sword of Fire and Ice") }; } }
    }
}