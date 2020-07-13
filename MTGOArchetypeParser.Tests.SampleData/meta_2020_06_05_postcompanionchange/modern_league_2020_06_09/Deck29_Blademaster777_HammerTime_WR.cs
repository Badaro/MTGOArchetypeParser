using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_09
{
    public class Deck29_Blademaster777_HammerTime_WR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Burrenton Forge-Tender"),
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(4, "Kor Duelist"),
            new SampleCard(4, "Kor Outfitter"),
            new SampleCard(4, "Spellskite"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Steelshaper's Gift"),
            new SampleCard(4, "Magnetic Theft"),
            new SampleCard(4, "Colossus Hammer"),
            new SampleCard(1, "Shadowspear"),
            new SampleCard(4, "Sigarda's Aid"),
            new SampleCard(1, "Arid Mesa"),
            new SampleCard(4, "Inkmoth Nexus"),
            new SampleCard(4, "Inspiring Vantage"),
            new SampleCard(6, "Plains"),
            new SampleCard(2, "Sacred Foundry"),
            new SampleCard(4, "Sunbaked Canyon") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Burrenton Forge-Tender"),
            new SampleCard(2, "Auriok Champion"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(3, "Leonin Relic-Warder"),
            new SampleCard(2, "Lightning Bolt"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(3, "Rest in Peace") 
        };
    }
}