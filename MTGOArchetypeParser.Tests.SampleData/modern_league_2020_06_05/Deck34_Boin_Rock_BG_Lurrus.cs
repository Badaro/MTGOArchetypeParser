using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05
{
    public class Deck34_Boin_Rock_BG_Lurrus : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Grim Flayer"),(2, "Hexdrinker"),(2, "Scavenging Ooze"),(4, "Tarmogoyf"),(4, "Inquisition of Kozilek"),(1, "Maelstrom Pulse"),(2, "Thoughtseize"),(2, "Unearth"),(4, "Assassin's Trophy"),(2, "Cling to Dust"),(4, "Fatal Push"),(4, "Mishra's Bauble"),(1, "Nihil Spellbomb"),(2, "Dead Weight"),(4, "Blooming Marsh"),(4, "Field of Ruin"),(2, "Nurturing Peatland"),(2, "Overgrown Tomb"),(2, "Snow-Covered Forest"),(4, "Snow-Covered Swamp"),(4, "Verdant Catacombs") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Cling to Dust"),(2, "Dead Weight"),(1, "Nihil Spellbomb"),(1, "Chevill, Bane of Monsters"),(2, "Collective Brutality"),(2, "Damping Sphere"),(2, "Engineered Explosives"),(1, "Executioner's Capsule"),(1, "Lurrus of the Dream Den"),(2, "Veil of Summer") }; } }
    }
}