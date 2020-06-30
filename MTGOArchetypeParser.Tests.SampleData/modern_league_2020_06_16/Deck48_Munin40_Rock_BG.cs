using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck48_Munin40_Rock_BG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Liliana of the Veil"),(1, "Liliana, the Last Hope"),(4, "Grim Flayer"),(4, "Hexdrinker"),(2, "Lurrus of the Dream Den"),(2, "Scavenging Ooze"),(4, "Tarmogoyf"),(4, "Inquisition of Kozilek"),(1, "Maelstrom Pulse"),(3, "Thoughtseize"),(4, "Assassin's Trophy"),(4, "Fatal Push"),(4, "Mishra's Bauble"),(2, "Bloodstained Mire"),(4, "Blooming Marsh"),(2, "Forest"),(2, "Nurturing Peatland"),(2, "Overgrown Tomb"),(3, "Swamp"),(1, "Twilight Mire"),(4, "Verdant Catacombs") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Ashiok, Dream Render"),(2, "Choke"),(2, "Collective Brutality"),(2, "Collector Ouphe"),(2, "Damping Sphere"),(1, "Dead Weight"),(1, "Engineered Explosives"),(1, "Grafdigger's Cage"),(2, "Nihil Spellbomb") }; } }
    }
}