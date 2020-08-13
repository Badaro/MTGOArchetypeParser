using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_preliminary_2020_07_09
{
    public class Deck05_samslam_Burn_WR : ISampleDeck
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
            new SampleCard(3, "Searing Blaze"),
            new SampleCard(2, "Skullcrack"),
            new SampleCard(3, "Bloodstained Mire"),
            new SampleCard(3, "Inspiring Vantage"),
            new SampleCard(3, "Mountain"),
            new SampleCard(3, "Sacred Foundry"),
            new SampleCard(4, "Sunbaked Canyon"),
            new SampleCard(3, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Skullcrack"),
            new SampleCard(1, "Exquisite Firecraft"),
            new SampleCard(3, "Kor Firewalker"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(3, "Rest in Peace"),
            new SampleCard(2, "Smash to Smithereens"),
            new SampleCard(1, "Wear // Tear") 
        };
    }
}