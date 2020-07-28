using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_28
{
    public class Deck08_Werebere_Burn_IncineratorBurn_WR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Chandra's Incinerator"),
            new SampleCard(3, "Eidolon of the Great Revel"),
            new SampleCard(3, "Goblin Guide"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Lava Spike"),
            new SampleCard(4, "Rift Bolt"),
            new SampleCard(4, "Skewer the Critics"),
            new SampleCard(4, "Boros Charm"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(1, "Skullcrack"),
            new SampleCard(2, "Leyline of Combustion"),
            new SampleCard(4, "Seal of Fire"),
            new SampleCard(4, "Arid Mesa"),
            new SampleCard(2, "Bloodstained Mire"),
            new SampleCard(3, "Inspiring Vantage"),
            new SampleCard(6, "Mountain"),
            new SampleCard(1, "Ramunap Ruins"),
            new SampleCard(3, "Sacred Foundry") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Skullcrack"),
            new SampleCard(2, "Exquisite Firecraft"),
            new SampleCard(2, "Kor Firewalker"),
            new SampleCard(1, "Kozilek's Return"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(3, "Relic of Progenitus"),
            new SampleCard(1, "Shattering Spree"),
            new SampleCard(2, "Smash to Smithereens") 
        };
    }
}