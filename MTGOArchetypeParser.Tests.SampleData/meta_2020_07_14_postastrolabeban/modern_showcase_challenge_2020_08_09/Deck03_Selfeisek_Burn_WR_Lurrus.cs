using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_showcase_challenge_2020_08_09
{
    public class Deck03_Selfeisek_Burn_WR_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Eidolon of the Great Revel"),
            new SampleCard(4, "Goblin Guide"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Lava Spike"),
            new SampleCard(2, "Rift Bolt"),
            new SampleCard(2, "Skewer the Critics"),
            new SampleCard(4, "Boros Charm"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(3, "Lightning Helix"),
            new SampleCard(4, "Searing Blaze"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(1, "Seal of Fire"),
            new SampleCard(4, "Arid Mesa"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(4, "Inspiring Vantage"),
            new SampleCard(2, "Mountain"),
            new SampleCard(2, "Sacred Foundry"),
            new SampleCard(4, "Sunbaked Canyon") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Kor Firewalker"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(3, "Skullcrack"),
            new SampleCard(2, "Smash to Smithereens"),
            new SampleCard(2, "Tormod's Crypt"),
            new SampleCard(1, "Wear // Tear") 
        };
    }
}