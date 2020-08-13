using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_24
{
    public class Deck24_Bosseidon_Burn_IncineratorBurn_WR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Chandra's Incinerator"),
            new SampleCard(4, "Eidolon of the Great Revel"),
            new SampleCard(4, "Goblin Guide"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Lava Spike"),
            new SampleCard(4, "Rift Bolt"),
            new SampleCard(4, "Skewer the Critics"),
            new SampleCard(4, "Boros Charm"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(1, "Skullcrack"),
            new SampleCard(4, "Seal of Fire"),
            new SampleCard(4, "Arid Mesa"),
            new SampleCard(4, "Inspiring Vantage"),
            new SampleCard(3, "Mountain"),
            new SampleCard(2, "Sacred Foundry"),
            new SampleCard(4, "Sunbaked Canyon"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Skullcrack"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(2, "Pyroclasm"),
            new SampleCard(3, "Smash to Smithereens"),
            new SampleCard(3, "Surgical Extraction") 
        };
    }
}