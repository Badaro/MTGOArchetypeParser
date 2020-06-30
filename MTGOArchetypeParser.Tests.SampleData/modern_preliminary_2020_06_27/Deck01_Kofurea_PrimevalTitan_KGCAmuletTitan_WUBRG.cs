using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_27
{
    public class Deck01_Kofurea_PrimevalTitan_KGCAmuletTitan_WUBRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Karn, the Great Creator"),(1, "Azusa, Lost but Seeking"),(4, "Dryad of the Ilysian Grove"),(1, "Golos, Tireless Pilgrim"),(4, "Primeval Titan"),(4, "Sakura-Tribe Scout"),(4, "Ancient Stirrings"),(4, "Summoner's Pact"),(4, "Amulet of Vigor"),(1, "Engineered Explosives"),(1, "Bojuka Bog"),(1, "Boros Garrison"),(1, "Breeding Pool"),(3, "Castle Garenbrig"),(1, "Cavern of Souls"),(1, "Field of the Dead"),(2, "Forest"),(1, "Ghost Quarter"),(1, "Golgari Rot Farm"),(1, "Gruul Turf"),(1, "Misty Rainforest"),(1, "Radiant Fountain"),(1, "Selesnya Sanctuary"),(4, "Simic Growth Chamber"),(1, "Slayers' Stronghold"),(2, "Snow-Covered Forest"),(1, "Sunhome, Fortress of the Legion"),(3, "Tolaria West"),(1, "Valakut, the Molten Pinnacle"),(1, "Verdant Catacombs"),(1, "Vesuva") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Golos, Tireless Pilgrim"),(2, "Engineered Explosives"),(2, "Dismember"),(2, "Force of Vigor"),(1, "Grafdigger's Cage"),(1, "Liquimetal Coating"),(1, "Pithing Needle"),(1, "Reclamation Sage"),(2, "Uro, Titan of Nature's Wrath"),(1, "Walking Ballista"),(1, "Wurmcoil Engine") }; } }
    }
}