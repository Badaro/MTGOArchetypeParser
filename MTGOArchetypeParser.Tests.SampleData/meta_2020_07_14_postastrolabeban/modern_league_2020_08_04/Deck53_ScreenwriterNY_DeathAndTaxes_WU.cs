using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_04
{
    public class Deck53_ScreenwriterNY_DeathAndTaxes_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Blade Splicer"),
            new SampleCard(4, "Deputy of Detention"),
            new SampleCard(1, "Geist of Saint Traft"),
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(3, "Meddling Mage"),
            new SampleCard(2, "Restoration Angel"),
            new SampleCard(2, "Serra Avenger"),
            new SampleCard(4, "Spell Queller"),
            new SampleCard(4, "Thalia, Guardian of Thraben"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(2, "Flooded Strand"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(3, "Horizon Canopy"),
            new SampleCard(2, "Island"),
            new SampleCard(4, "Plains"),
            new SampleCard(4, "Seachrome Coast"),
            new SampleCard(2, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Burrenton Forge-Tender"),
            new SampleCard(1, "Celestial Purge"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Kor Firewalker"),
            new SampleCard(1, "Leonin Relic-Warder"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(4, "Rest in Peace") 
        };
    }
}