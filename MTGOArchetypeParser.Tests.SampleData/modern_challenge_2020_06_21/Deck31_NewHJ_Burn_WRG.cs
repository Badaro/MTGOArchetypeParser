using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21
{
    public class Deck31_NewHJ_Burn_WRG : ISampleDeck
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
            new SampleCard(4, "Lightning Helix"),
            new SampleCard(4, "Searing Blaze"),
            new SampleCard(1, "Skullcrack"),
            new SampleCard(2, "Arid Mesa"),
            new SampleCard(2, "Bloodstained Mire"),
            new SampleCard(3, "Inspiring Vantage"),
            new SampleCard(2, "Mountain"),
            new SampleCard(2, "Sacred Foundry"),
            new SampleCard(1, "Scalding Tarn"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(4, "Sunbaked Canyon"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Skullcrack"),
            new SampleCard(1, "Deflecting Palm"),
            new SampleCard(4, "Destructive Revelry"),
            new SampleCard(2, "Exquisite Firecraft"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(2, "Searing Blood") 
        };
    }
}