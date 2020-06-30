using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_23
{
    public class Deck43_kg_Yawgmoth_BG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Birds of Paradise"),
            new SampleCard(1, "Cavalier of Night"),
            new SampleCard(1, "Elves of Deep Shadow"),
            new SampleCard(4, "Geralf's Messenger"),
            new SampleCard(1, "Noble Hierarch"),
            new SampleCard(1, "Scavenging Ooze"),
            new SampleCard(4, "Strangleroot Geist"),
            new SampleCard(4, "Wall of Roots"),
            new SampleCard(4, "Yawgmoth, Thran Physician"),
            new SampleCard(4, "Young Wolf"),
            new SampleCard(1, "Zulaport Cutthroat"),
            new SampleCard(4, "Eldritch Evolution"),
            new SampleCard(4, "Chord of Calling"),
            new SampleCard(4, "Blooming Marsh"),
            new SampleCard(1, "Dryad Arbor"),
            new SampleCard(1, "Khalni Garden"),
            new SampleCard(2, "Nurturing Peatland"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(1, "Pendelhaven"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(4, "Twilight Mire"),
            new SampleCard(1, "Urborg, Tomb of Yawgmoth"),
            new SampleCard(4, "Verdant Catacombs") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(1, "Fatal Push"),
            new SampleCard(1, "Kitchen Finks"),
            new SampleCard(1, "Leyline of the Void"),
            new SampleCard(1, "Obstinate Baloth"),
            new SampleCard(1, "Phyrexian Revoker"),
            new SampleCard(1, "Plague Engineer"),
            new SampleCard(1, "Reclamation Sage"),
            new SampleCard(1, "Thoughtseize"),
            new SampleCard(1, "Thrashing Brontodon"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}