using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_challenge_2020_06_08
{
    public class Deck15_LordBeerus_Burn_WR_Lurrus : ISampleDeck
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
            new SampleCard(3, "Lightning Helix"),
            new SampleCard(4, "Searing Blaze"),
            new SampleCard(1, "Skullcrack"),
            new SampleCard(4, "Arid Mesa"),
            new SampleCard(4, "Inspiring Vantage"),
            new SampleCard(2, "Sacred Foundry"),
            new SampleCard(3, "Scalding Tarn"),
            new SampleCard(3, "Snow-Covered Mountain"),
            new SampleCard(4, "Sunbaked Canyon") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Skullcrack"),
            new SampleCard(2, "Kor Firewalker"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(3, "Rest in Peace"),
            new SampleCard(3, "Smash to Smithereens") 
        };
    }
}