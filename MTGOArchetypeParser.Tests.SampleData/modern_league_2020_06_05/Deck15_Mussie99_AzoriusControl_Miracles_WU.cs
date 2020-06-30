using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05
{
    public class Deck15_Mussie99_AzoriusControl_Miracles_WU : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Jace, the Mind Sculptor"),(2, "Teferi, Time Raveler"),(1, "Entreat the Angels"),(1, "Serum Visions"),(3, "Terminus"),(3, "Archmage's Charm"),(3, "Cryptic Command"),(3, "Force of Negation"),(2, "Logic Knot"),(4, "Opt"),(4, "Path to Exile"),(1, "Spell Snare"),(4, "Counterbalance"),(3, "Omen of the Sea"),(4, "Flooded Strand"),(3, "Hallowed Fountain"),(6, "Island"),(1, "Misty Rainforest"),(3, "Mystic Sanctuary"),(1, "Plains"),(4, "Polluted Delta"),(1, "Prairie Stream") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Aether Gust"),(2, "Ashiok, Dream Render"),(2, "Celestial Purge"),(2, "Ceremonious Rejection"),(2, "Flusterstorm"),(2, "Monastery Mentor"),(1, "Teferi, Hero of Dominaria"),(2, "Timely Reinforcements") }; } }
    }
}