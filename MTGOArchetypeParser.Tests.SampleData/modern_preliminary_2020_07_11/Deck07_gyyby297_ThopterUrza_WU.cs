using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_07_11
{
    public class Deck07_gyyby297_ThopterUrza_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Jace, the Mind Sculptor"),
            new SampleCard(3, "Teferi, Time Raveler"),
            new SampleCard(4, "Urza, Lord High Artificer"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(2, "Remand"),
            new SampleCard(2, "Whir of Invention"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(1, "Relic of Progenitus"),
            new SampleCard(1, "Sword of the Meek"),
            new SampleCard(3, "Talisman of Progress"),
            new SampleCard(3, "Thopter Foundry"),
            new SampleCard(1, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(2, "Misty Rainforest"),
            new SampleCard(3, "Mystic Sanctuary"),
            new SampleCard(3, "Polluted Delta"),
            new SampleCard(1, "Prairie Stream"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(5, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(3, "Ceremonious Rejection"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(2, "Timely Reinforcements"),
            new SampleCard(1, "Wrath of God") 
        };
    }
}