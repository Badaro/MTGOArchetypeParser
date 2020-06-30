using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_19
{
    public class Deck18_Heibing_PrimevalTitan_BRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Arboreal Grazer"),(4, "Dryad of the Ilysian Grove"),(2, "Golos, Tireless Pilgrim"),(4, "Primeval Titan"),(4, "Sakura-Tribe Elder"),(4, "Explore"),(4, "Assassin's Trophy"),(4, "Summoner's Pact"),(1, "Blast Zone"),(1, "Bojuka Bog"),(1, "Cascading Cataracts"),(4, "Castle Garenbrig"),(3, "Cavern of Souls"),(2, "Field of the Dead"),(2, "Forest"),(1, "Ghost Quarter"),(3, "Golgari Rot Farm"),(1, "Overgrown Tomb"),(1, "Radiant Fountain"),(2, "Snow-Covered Forest"),(1, "Snow-Covered Swamp"),(1, "Swamp"),(2, "Valakut, the Molten Pinnacle"),(4, "Verdant Catacombs"),(1, "Vesuva") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Radiant Fountain"),(1, "Beast Within"),(2, "Choke"),(3, "Fatal Push"),(4, "Memoricide"),(3, "Veil of Summer") }; } }
    }
}