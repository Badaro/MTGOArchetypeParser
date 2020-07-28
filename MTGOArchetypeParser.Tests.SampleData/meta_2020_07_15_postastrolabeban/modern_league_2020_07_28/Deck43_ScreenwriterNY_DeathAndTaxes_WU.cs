using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_28
{
    public class Deck43_ScreenwriterNY_DeathAndTaxes_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Blade Splicer"),
            new SampleCard(4, "Deputy of Detention"),
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(4, "Meddling Mage"),
            new SampleCard(3, "Restoration Angel"),
            new SampleCard(2, "Serra Avenger"),
            new SampleCard(4, "Spell Queller"),
            new SampleCard(3, "Thalia, Guardian of Thraben"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(2, "Flooded Strand"),
            new SampleCard(3, "Ghost Quarter"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(3, "Horizon Canopy"),
            new SampleCard(2, "Island"),
            new SampleCard(4, "Plains"),
            new SampleCard(4, "Seachrome Coast"),
            new SampleCard(2, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Burrenton Forge-Tender"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(1, "Ceremonious Rejection"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Kor Firewalker"),
            new SampleCard(1, "Leonin Relic-Warder"),
            new SampleCard(3, "Mystical Dispute"),
            new SampleCard(3, "Rest in Peace") 
        };
    }
}