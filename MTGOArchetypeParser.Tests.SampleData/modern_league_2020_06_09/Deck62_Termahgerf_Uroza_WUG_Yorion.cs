using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck62_Termahgerf_Uroza_WUG_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Emry, Lurker of the Loch"),
            new SampleCard(4, "Gilded Goose"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(4, "Thraben Inspector"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(4, "Urza, Lord High Artificer"),
            new SampleCard(3, "Wall of Blossoms"),
            new SampleCard(1, "Archmage's Charm"),
            new SampleCard(4, "Cryptic Command"),
            new SampleCard(4, "Metallic Rebuke"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(4, "Springleaf Drum"),
            new SampleCard(1, "Witching Well"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(3, "Mystic Sanctuary"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(6, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Soul-Guide Lantern"),
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}