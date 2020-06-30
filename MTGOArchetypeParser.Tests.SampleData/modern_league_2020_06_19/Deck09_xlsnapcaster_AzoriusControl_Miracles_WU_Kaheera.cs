using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_19
{
    public class Deck09_xlsnapcaster_AzoriusControl_Miracles_WU_Kaheera : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Jace, the Mind Sculptor"),(2, "Teferi, Hero of Dominaria"),(1, "Supreme Verdict"),(4, "Terminus"),(2, "Timely Reinforcements"),(4, "Cryptic Command"),(3, "Force of Negation"),(3, "Mana Leak"),(4, "Opt"),(4, "Path to Exile"),(1, "Detention Sphere"),(4, "Omen of the Sea"),(2, "Castle Vantress"),(2, "Celestial Colonnade"),(4, "Field of Ruin"),(4, "Flooded Strand"),(2, "Hallowed Fountain"),(6, "Island"),(3, "Mystic Sanctuary"),(2, "Plains") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Supreme Verdict"),(1, "Timely Reinforcements"),(2, "Aether Gust"),(4, "Ashiok, Dream Render"),(2, "Celestial Purge"),(2, "Dovin's Veto"),(1, "Kaheera, the Orphanguard"),(2, "Narset, Parter of Veils") }; } }
    }
}