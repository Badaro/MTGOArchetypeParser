using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_25
{
    public class Deck12_Mcleskey_Burn_WR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Eidolon of the Great Revel"),
            new SampleCard(4, "Goblin Guide"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Lava Spike"),
            new SampleCard(4, "Rift Bolt"),
            new SampleCard(4, "Skewer the Critics"),
            new SampleCard(4, "Boros Charm"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Lightning Helix"),
            new SampleCard(4, "Searing Blaze"),
            new SampleCard(2, "Skullcrack"),
            new SampleCard(2, "Arid Mesa"),
            new SampleCard(1, "Fiery Islet"),
            new SampleCard(4, "Inspiring Vantage"),
            new SampleCard(3, "Mountain"),
            new SampleCard(2, "Sacred Foundry"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(4, "Sunbaked Canyon") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Skullcrack"),
            new SampleCard(3, "Kor Firewalker"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(2, "Searing Blood"),
            new SampleCard(3, "Smash to Smithereens") 
        };
    }
}