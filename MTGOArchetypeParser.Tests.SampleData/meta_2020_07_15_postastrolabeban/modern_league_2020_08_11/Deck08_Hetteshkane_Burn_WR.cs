using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_11
{
    public class Deck08_Hetteshkane_Burn_WR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Eidolon of the Great Revel"),
            new SampleCard(4, "Goblin Guide"),
            new SampleCard(2, "Grim Lavamancer"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(2, "Lava Spike"),
            new SampleCard(4, "Rift Bolt"),
            new SampleCard(4, "Skewer the Critics"),
            new SampleCard(4, "Boros Charm"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Lightning Helix"),
            new SampleCard(3, "Searing Blaze"),
            new SampleCard(2, "Skullcrack"),
            new SampleCard(1, "Arid Mesa"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(4, "Inspiring Vantage"),
            new SampleCard(7, "Mountain"),
            new SampleCard(4, "Sacred Foundry") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Bomat Courier"),
            new SampleCard(2, "Kor Firewalker"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(1, "Rampaging Ferocidon"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(2, "Searing Blood"),
            new SampleCard(2, "Shrine of Burning Rage"),
            new SampleCard(2, "Smash to Smithereens") 
        };
    }
}