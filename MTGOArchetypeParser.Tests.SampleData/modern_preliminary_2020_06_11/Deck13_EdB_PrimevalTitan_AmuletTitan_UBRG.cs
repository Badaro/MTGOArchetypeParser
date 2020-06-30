using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_11
{
    public class Deck13_EdB_PrimevalTitan_AmuletTitan_UBRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Arboreal Grazer"),(1, "Azusa, Lost but Seeking"),(4, "Dryad of the Ilysian Grove"),(4, "Primeval Titan"),(4, "Sakura-Tribe Scout"),(1, "Tireless Tracker"),(4, "Ancient Stirrings"),(1, "Pact of Negation"),(4, "Summoner's Pact"),(4, "Amulet of Vigor"),(1, "Bojuka Bog"),(2, "Breeding Pool"),(2, "Castle Garenbrig"),(2, "Cavern of Souls"),(1, "Field of the Dead"),(2, "Forest"),(1, "Ghost Quarter"),(2, "Golgari Rot Farm"),(2, "Gruul Turf"),(1, "Hanweir Battlements"),(1, "Radiant Fountain"),(4, "Simic Growth Chamber"),(2, "Snow-Covered Forest"),(3, "Tolaria West"),(1, "Valakut, the Molten Pinnacle"),(1, "Vesuva"),(1, "Windswept Heath"),(1, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Ghost Quarter"),(1, "Radiant Fountain"),(2, "Tireless Tracker"),(4, "Dismember"),(1, "Engineered Explosives"),(2, "Pithing Needle"),(1, "Ramunap Excavator"),(1, "Reclamation Sage"),(2, "Spellskite") }; } }
    }
}