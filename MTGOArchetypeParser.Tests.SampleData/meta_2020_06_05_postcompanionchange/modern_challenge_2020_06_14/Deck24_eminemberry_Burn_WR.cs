using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_14
{
    public class Deck24_eminemberry_Burn_WR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Eidolon of the Great Revel"),
            new SampleCard(4, "Goblin Guide"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Lava Spike"),
            new SampleCard(4, "Rift Bolt"),
            new SampleCard(2, "Skewer the Critics"),
            new SampleCard(4, "Boros Charm"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(3, "Lightning Helix"),
            new SampleCard(3, "Searing Blaze"),
            new SampleCard(4, "Skullcrack"),
            new SampleCard(2, "Arid Mesa"),
            new SampleCard(1, "Bloodstained Mire"),
            new SampleCard(2, "Fiery Islet"),
            new SampleCard(4, "Inspiring Vantage"),
            new SampleCard(3, "Mountain"),
            new SampleCard(2, "Sacred Foundry"),
            new SampleCard(4, "Sunbaked Canyon"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Searing Blaze"),
            new SampleCard(1, "Angel's Grace"),
            new SampleCard(1, "Deflecting Palm"),
            new SampleCard(2, "Kor Firewalker"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(1, "Searing Blood"),
            new SampleCard(3, "Smash to Smithereens"),
            new SampleCard(2, "Wear // Tear") 
        };
    }
}