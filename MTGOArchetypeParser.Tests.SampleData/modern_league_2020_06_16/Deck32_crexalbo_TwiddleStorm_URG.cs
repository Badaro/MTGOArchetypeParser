using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck32_crexalbo_TwiddleStorm_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Grapeshot"),
            new SampleCard(4, "Ideas Unbound"),
            new SampleCard(2, "Merchant Scroll"),
            new SampleCard(2, "Past in Flames"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(4, "Sleight of Hand"),
            new SampleCard(2, "Sylvan Scrying"),
            new SampleCard(4, "Dream's Grip"),
            new SampleCard(1, "Echoing Truth"),
            new SampleCard(1, "Izzet Charm"),
            new SampleCard(4, "Peer Through Depths"),
            new SampleCard(4, "Psychic Puppetry"),
            new SampleCard(4, "Reach Through Mists"),
            new SampleCard(3, "Twiddle"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(4, "Island"),
            new SampleCard(2, "Lonely Sandbar"),
            new SampleCard(4, "Lotus Field"),
            new SampleCard(3, "Polluted Delta"),
            new SampleCard(1, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Echoing Truth"),
            new SampleCard(1, "Ad Nauseam"),
            new SampleCard(3, "Aria of Flame"),
            new SampleCard(2, "Lightning Bolt"),
            new SampleCard(1, "Pyroclasm"),
            new SampleCard(1, "Swan Song"),
            new SampleCard(3, "Thing in the Ice"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}