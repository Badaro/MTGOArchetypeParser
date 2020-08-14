using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14
{
    public class Deck49_Werebere_Burn_WRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Eidolon of the Great Revel"),
            new SampleCard(4, "Goblin Guide"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Lava Spike"),
            new SampleCard(4, "Rift Bolt"),
            new SampleCard(4, "Skewer the Critics"),
            new SampleCard(4, "Boros Charm"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Lightning Helix"),
            new SampleCard(3, "Searing Blaze"),
            new SampleCard(2, "Skullcrack"),
            new SampleCard(2, "Seal of Fire"),
            new SampleCard(4, "Arid Mesa"),
            new SampleCard(2, "Bloodstained Mire"),
            new SampleCard(3, "Inspiring Vantage"),
            new SampleCard(4, "Mountain"),
            new SampleCard(3, "Sacred Foundry"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(3, "Sunbaked Canyon") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Anger of the Gods"),
            new SampleCard(3, "Chandra's Incinerator"),
            new SampleCard(3, "Cindervines"),
            new SampleCard(1, "Exquisite Firecraft"),
            new SampleCard(3, "Kor Firewalker"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(2, "Relic of Progenitus") 
        };
    }
}