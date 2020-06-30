using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_showcase_challenge_2020_06_07
{
    public class Deck20_Zebrah_PrimevalTitan_AmuletTitan_WUBRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Azusa, Lost but Seeking"),(4, "Dryad of the Ilysian Grove"),(4, "Primeval Titan"),(4, "Sakura-Tribe Scout"),(1, "Uro, Titan of Nature's Wrath"),(4, "Explore"),(1, "Pact of Negation"),(4, "Summoner's Pact"),(4, "Amulet of Vigor"),(1, "Engineered Explosives"),(1, "Bojuka Bog"),(1, "Boros Garrison"),(2, "Breeding Pool"),(3, "Castle Garenbrig"),(2, "Cavern of Souls"),(1, "Crumbling Vestige"),(1, "Field of the Dead"),(2, "Forest"),(1, "Ghost Quarter"),(1, "Golgari Rot Farm"),(1, "Gruul Turf"),(1, "Radiant Fountain"),(2, "Selesnya Sanctuary"),(4, "Simic Growth Chamber"),(1, "Slayers' Stronghold"),(2, "Snow-Covered Forest"),(2, "Tolaria West"),(1, "Valakut, the Molten Pinnacle"),(1, "Vesuva"),(1, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Beast Within"),(3, "Dismember"),(1, "Force of Vigor"),(1, "Grafdigger's Cage"),(3, "Negate"),(1, "Obstinate Baloth"),(1, "Reclamation Sage"),(2, "Tireless Tracker"),(1, "Veil of Summer") }; } }
    }
}