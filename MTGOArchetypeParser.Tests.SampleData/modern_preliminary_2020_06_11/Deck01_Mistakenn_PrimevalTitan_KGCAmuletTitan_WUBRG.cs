using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_11
{
    public class Deck01_Mistakenn_PrimevalTitan_KGCAmuletTitan_WUBRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Karn, the Great Creator"),(2, "Azusa, Lost but Seeking"),(4, "Dryad of the Ilysian Grove"),(4, "Primeval Titan"),(4, "Sakura-Tribe Scout"),(1, "Tatyova, Benthic Druid"),(3, "Explore"),(1, "Pact of Negation"),(4, "Summoner's Pact"),(4, "Amulet of Vigor"),(1, "Bojuka Bog"),(1, "Boros Garrison"),(1, "Breeding Pool"),(4, "Castle Garenbrig"),(2, "Cavern of Souls"),(1, "Crumbling Vestige"),(1, "Field of the Dead"),(2, "Forest"),(1, "Ghost Quarter"),(1, "Golgari Rot Farm"),(1, "Gruul Turf"),(1, "Misty Rainforest"),(1, "Radiant Fountain"),(1, "Selesnya Sanctuary"),(4, "Simic Growth Chamber"),(1, "Slayers' Stronghold"),(2, "Snow-Covered Forest"),(2, "Tolaria West"),(1, "Valakut, the Molten Pinnacle"),(1, "Vesuva") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Beast Within"),(1, "Crucible of Worlds"),(2, "Dismember"),(1, "Engineered Explosives"),(1, "Force of Vigor"),(1, "Grafdigger's Cage"),(1, "Liquimetal Coating"),(2, "Obstinate Baloth"),(1, "Reclamation Sage"),(1, "Skysovereign, Consul Flagship"),(1, "Tireless Tracker"),(1, "Wurmcoil Engine") }; } }
    }
}