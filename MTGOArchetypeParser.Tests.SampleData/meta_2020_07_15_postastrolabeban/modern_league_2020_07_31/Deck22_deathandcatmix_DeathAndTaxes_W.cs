using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_31
{
    public class Deck22_deathandcatmix_DeathAndTaxes_W : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aven Mindcensor"),
            new SampleCard(4, "Flickerwisp"),
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(2, "Serra Avenger"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Thalia, Guardian of Thraben"),
            new SampleCard(2, "Wall of Omens"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(1, "Sword of Light and Shadow"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(2, "Flagstones of Trokair"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(9, "Plains"),
            new SampleCard(4, "Silent Clearing") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Burrenton Forge-Tender"),
            new SampleCard(3, "Eidolon of Rhetoric"),
            new SampleCard(3, "Leonin Relic-Warder"),
            new SampleCard(3, "Oblivion Ring"),
            new SampleCard(3, "Runed Halo") 
        };
    }
}