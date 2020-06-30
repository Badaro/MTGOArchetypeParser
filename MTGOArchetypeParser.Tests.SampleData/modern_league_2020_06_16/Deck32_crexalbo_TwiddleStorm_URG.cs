using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck32_crexalbo_TwiddleStorm_URG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Grapeshot"),(4, "Ideas Unbound"),(2, "Merchant Scroll"),(2, "Past in Flames"),(4, "Serum Visions"),(4, "Sleight of Hand"),(2, "Sylvan Scrying"),(4, "Dream's Grip"),(1, "Echoing Truth"),(1, "Izzet Charm"),(4, "Peer Through Depths"),(4, "Psychic Puppetry"),(4, "Reach Through Mists"),(3, "Twiddle"),(2, "Breeding Pool"),(4, "Flooded Strand"),(4, "Island"),(2, "Lonely Sandbar"),(4, "Lotus Field"),(3, "Polluted Delta"),(1, "Steam Vents") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Echoing Truth"),(1, "Ad Nauseam"),(3, "Aria of Flame"),(2, "Lightning Bolt"),(1, "Pyroclasm"),(1, "Swan Song"),(3, "Thing in the Ice"),(3, "Veil of Summer") }; } }
    }
}