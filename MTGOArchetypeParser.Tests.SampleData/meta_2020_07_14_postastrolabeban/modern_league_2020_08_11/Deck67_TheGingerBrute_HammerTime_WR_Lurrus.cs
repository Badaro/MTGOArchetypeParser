using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_11
{
    public class Deck67_TheGingerBrute_HammerTime_WR_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(4, "Kor Duelist"),
            new SampleCard(4, "Kor Outfitter"),
            new SampleCard(4, "Spellskite"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(1, "Swiftblade Vindicator"),
            new SampleCard(4, "Steelshaper's Gift"),
            new SampleCard(4, "Magnetic Theft"),
            new SampleCard(4, "Colossus Hammer"),
            new SampleCard(2, "Shadowspear"),
            new SampleCard(4, "Sigarda's Aid"),
            new SampleCard(4, "Inkmoth Nexus"),
            new SampleCard(4, "Inspiring Vantage"),
            new SampleCard(5, "Plains"),
            new SampleCard(4, "Sacred Foundry"),
            new SampleCard(4, "Sunbaked Canyon") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Burrenton Forge-Tender"),
            new SampleCard(2, "Grand Abolisher"),
            new SampleCard(3, "Kor Firewalker"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(2, "Tormod's Crypt"),
            new SampleCard(2, "Wear // Tear") 
        };
    }
}