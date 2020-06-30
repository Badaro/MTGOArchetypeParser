using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_23
{
    public class Deck42_yutya_SnowControl_SnowTitan_WUG_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(1, "Teferi, Hero of Dominaria"),
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(2, "Primeval Titan"),
            new SampleCard(4, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Supreme Verdict"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(4, "Growth Spiral"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(2, "Remand"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(3, "Abundant Growth"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(2, "Field of Ruin"),
            new SampleCard(3, "Field of the Dead"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Glacial Fortress"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(1, "Hinterland Harbor"),
            new SampleCard(1, "Island"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(3, "Mystic Sanctuary"),
            new SampleCard(2, "Polluted Delta"),
            new SampleCard(1, "Prairie Stream"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(4, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(1, "Temple Garden") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(1, "Celestial Purge"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(2, "Spreading Seas"),
            new SampleCard(2, "Timely Reinforcements"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(2, "Weather the Storm"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}