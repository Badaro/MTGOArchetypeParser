using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_04
{
    public class Deck52_coert_DeathAndTaxes_W : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Dauntless Bodyguard"),
            new SampleCard(4, "Dryad Militant"),
            new SampleCard(4, "Judge's Familiar"),
            new SampleCard(3, "Kytheon, Hero of Akros"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(3, "Thalia, Guardian of Thraben"),
            new SampleCard(4, "Venerated Loxodon"),
            new SampleCard(1, "Brave the Elements"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(4, "Raise the Alarm"),
            new SampleCard(3, "Honor of the Pure"),
            new SampleCard(4, "Legion's Landing"),
            new SampleCard(1, "Castle Ardenvale"),
            new SampleCard(3, "Ghost Quarter"),
            new SampleCard(13, "Plains"),
            new SampleCard(2, "Shefet Dunes") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Thalia, Guardian of Thraben"),
            new SampleCard(1, "Burrenton Forge-Tender"),
            new SampleCard(3, "Declaration in Stone"),
            new SampleCard(1, "Gideon Blackblade"),
            new SampleCard(3, "Kor Firewalker"),
            new SampleCard(3, "Leonin Relic-Warder"),
            new SampleCard(1, "Tormod's Crypt"),
            new SampleCard(2, "Vryn Wingmare") 
        };
    }
}