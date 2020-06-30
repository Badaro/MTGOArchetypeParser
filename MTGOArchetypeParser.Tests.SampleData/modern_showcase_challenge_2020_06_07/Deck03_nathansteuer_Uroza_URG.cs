using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_showcase_challenge_2020_06_07
{
    public class Deck03_nathansteuer_Uroza_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Wrenn and Six"),
            new SampleCard(4, "Emry, Lurker of the Loch"),
            new SampleCard(4, "Gilded Goose"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(4, "Urza, Lord High Artificer"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(3, "Galvanic Blast"),
            new SampleCard(3, "Metallic Rebuke"),
            new SampleCard(1, "Aether Spellbomb"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(3, "Engineered Explosives"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(5, "Snow-Covered Island"),
            new SampleCard(1, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(3, "Ceremonious Rejection"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(2, "Lightning Bolt"),
            new SampleCard(2, "Tireless Tracker"),
            new SampleCard(2, "Tormod's Crypt"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}