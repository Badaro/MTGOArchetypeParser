using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05
{
    public class Deck26_timewalkinonsunshine_SnowControl_SnowTurns_URG_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Chandra, Torch of Defiance"),
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(4, "Wrenn and Six"),
            new SampleCard(3, "Ice-Fang Coatl"),
            new SampleCard(2, "Snapcaster Mage"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Exhaustion"),
            new SampleCard(4, "Time Warp"),
            new SampleCard(1, "Walk the Aeons"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Growth Spiral"),
            new SampleCard(2, "Lightning Bolt"),
            new SampleCard(4, "Opt"),
            new SampleCard(3, "Remand"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(2, "Gemstone Caverns"),
            new SampleCard(2, "Ketria Triome"),
            new SampleCard(2, "Lonely Sandbar"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(4, "Mystic Sanctuary"),
            new SampleCard(3, "Polluted Delta"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(3, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(2, "Steam Vents"),
            new SampleCard(1, "Tranquil Thicket") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(3, "Anger of the Gods"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(3, "Bonecrusher Giant"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(2, "Weather the Storm"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}