using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck45_martindoktor_AzoriusControl_Miracles_WU : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Jace, the Mind Sculptor"),(1, "Narset, Parter of Veils"),(1, "Teferi, Hero of Dominaria"),(2, "Teferi, Time Raveler"),(4, "Snapcaster Mage"),(1, "Entreat the Angels"),(4, "Terminus"),(1, "Archmage's Charm"),(3, "Cryptic Command"),(1, "Deprive"),(2, "Force of Negation"),(1, "Logic Knot"),(1, "Mana Leak"),(4, "Opt"),(4, "Path to Exile"),(1, "Spell Snare"),(1, "Detention Sphere"),(1, "Omen of the Sea"),(1, "Search for Azcanta"),(4, "Field of Ruin"),(4, "Flooded Strand"),(3, "Hallowed Fountain"),(2, "Mystic Sanctuary"),(3, "Polluted Delta"),(6, "Snow-Covered Island"),(2, "Snow-Covered Plains") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Aether Gust"),(2, "Ashiok, Dream Render"),(1, "Celestial Purge"),(1, "Ceremonious Rejection"),(1, "Disdainful Stroke"),(1, "Dovin's Veto"),(1, "Monastery Mentor"),(1, "Mystical Dispute"),(1, "Rest in Peace"),(1, "Stony Silence"),(1, "Supreme Verdict"),(3, "Timely Reinforcements") }; } }
    }
}