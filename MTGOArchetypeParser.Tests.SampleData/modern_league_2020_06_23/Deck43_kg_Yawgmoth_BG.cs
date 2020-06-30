using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_23
{
    public class Deck43_kg_Yawgmoth_BG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Birds of Paradise"),(1, "Cavalier of Night"),(1, "Elves of Deep Shadow"),(4, "Geralf's Messenger"),(1, "Noble Hierarch"),(1, "Scavenging Ooze"),(4, "Strangleroot Geist"),(4, "Wall of Roots"),(4, "Yawgmoth, Thran Physician"),(4, "Young Wolf"),(1, "Zulaport Cutthroat"),(4, "Eldritch Evolution"),(4, "Chord of Calling"),(4, "Blooming Marsh"),(1, "Dryad Arbor"),(1, "Khalni Garden"),(2, "Nurturing Peatland"),(2, "Overgrown Tomb"),(1, "Pendelhaven"),(2, "Snow-Covered Forest"),(1, "Snow-Covered Swamp"),(4, "Twilight Mire"),(1, "Urborg, Tomb of Yawgmoth"),(4, "Verdant Catacombs") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Abrupt Decay"),(1, "Ashiok, Dream Render"),(1, "Damping Sphere"),(1, "Fatal Push"),(1, "Kitchen Finks"),(1, "Leyline of the Void"),(1, "Obstinate Baloth"),(1, "Phyrexian Revoker"),(1, "Plague Engineer"),(1, "Reclamation Sage"),(1, "Thoughtseize"),(1, "Thrashing Brontodon"),(3, "Veil of Summer") }; } }
    }
}