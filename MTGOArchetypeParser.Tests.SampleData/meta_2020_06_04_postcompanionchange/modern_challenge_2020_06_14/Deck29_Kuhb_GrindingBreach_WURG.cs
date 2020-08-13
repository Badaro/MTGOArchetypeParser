using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_challenge_2020_06_14
{
    public class Deck29_Kuhb_GrindingBreach_WURG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Teferi, Time Raveler"),
            new SampleCard(4, "Emry, Lurker of the Loch"),
            new SampleCard(1, "Thassa's Oracle"),
            new SampleCard(2, "Urza, Lord High Artificer"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(3, "Metallic Rebuke"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(4, "Engineered Explosives"),
            new SampleCard(4, "Grinding Station"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(2, "Mox Amber"),
            new SampleCard(4, "Underworld Breach"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Fiery Islet"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Hall of Heliod's Generosity"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(4, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(1, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(1, "Ceremonious Rejection"),
            new SampleCard(1, "Echoing Truth"),
            new SampleCard(3, "Galvanic Blast"),
            new SampleCard(2, "Monastery Mentor"),
            new SampleCard(1, "Tormod's Crypt"),
            new SampleCard(3, "Veil of Summer"),
            new SampleCard(2, "Wear // Tear") 
        };
    }
}