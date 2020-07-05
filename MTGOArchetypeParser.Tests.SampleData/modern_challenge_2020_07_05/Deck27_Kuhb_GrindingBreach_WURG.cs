using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_05
{
    public class Deck27_Kuhb_GrindingBreach_WURG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Teferi, Time Raveler"),
            new SampleCard(4, "Emry, Lurker of the Loch"),
            new SampleCard(1, "Thassa's Oracle"),
            new SampleCard(2, "Urza, Lord High Artificer"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(2, "Metallic Rebuke"),
            new SampleCard(1, "Aether Spellbomb"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(4, "Engineered Explosives"),
            new SampleCard(4, "Grinding Station"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(2, "Mox Amber"),
            new SampleCard(4, "Underworld Breach"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Fiery Islet"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(2, "Hall of Heliod's Generosity"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(3, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(1, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(1, "Echoing Truth"),
            new SampleCard(1, "Monastery Mentor"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(1, "Pyroclasm"),
            new SampleCard(1, "Timely Reinforcements"),
            new SampleCard(4, "Veil of Summer"),
            new SampleCard(1, "Wear // Tear") 
        };
    }
}