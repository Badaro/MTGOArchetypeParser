using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12
{
    public class Deck27_lovealienzzz_SnowControl_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Wrenn and Six"),
            new SampleCard(2, "Brazen Borrower"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(2, "Snapcaster Mage"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Archmage's Charm"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(2, "Spell Snare"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(2, "Flooded Strand"),
            new SampleCard(1, "Ketria Triome"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(4, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Stomping Ground") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Abrade"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(1, "Pulse of Murasa"),
            new SampleCard(1, "Soul-Guide Lantern"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(1, "Weather the Storm") 
        };
    }
}