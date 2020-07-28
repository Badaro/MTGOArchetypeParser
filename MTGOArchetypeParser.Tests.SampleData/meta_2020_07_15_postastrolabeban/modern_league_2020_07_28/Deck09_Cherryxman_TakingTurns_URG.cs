using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_28
{
    public class Deck09_Cherryxman_TakingTurns_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Chandra, Torch of Defiance"),
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(4, "Wrenn and Six"),
            new SampleCard(1, "Brazen Borrower"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(4, "Time Warp"),
            new SampleCard(1, "Walk the Aeons"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(1, "Force of Negation"),
            new SampleCard(4, "Growth Spiral"),
            new SampleCard(3, "Lightning Bolt"),
            new SampleCard(2, "Temur Charm"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Flooded Strand"),
            new SampleCard(2, "Gemstone Caverns"),
            new SampleCard(2, "Ketria Triome"),
            new SampleCard(2, "Lonely Sandbar"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(4, "Mystic Sanctuary"),
            new SampleCard(1, "Polluted Delta"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(2, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(2, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Lightning Bolt"),
            new SampleCard(1, "Abrade"),
            new SampleCard(3, "Aether Gust"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(3, "Bonecrusher Giant"),
            new SampleCard(1, "Veil of Summer"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}