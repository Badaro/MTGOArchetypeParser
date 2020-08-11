using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_11
{
    public class Deck16_mrounds1216_DeathAndTaxes_EldraziTaxes_WB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Charming Prince"),
            new SampleCard(4, "Eldrazi Displacer"),
            new SampleCard(2, "Flickerwisp"),
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(3, "Thalia, Guardian of Thraben"),
            new SampleCard(3, "Thought-Knot Seer"),
            new SampleCard(2, "Tidehollow Sculler"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(4, "Caves of Koilos"),
            new SampleCard(4, "Eldrazi Temple"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(3, "Plains"),
            new SampleCard(2, "Silent Clearing"),
            new SampleCard(2, "Snow-Covered Plains"),
            new SampleCard(1, "Swamp"),
            new SampleCard(1, "Tectonic Edge") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Burrenton Forge-Tender"),
            new SampleCard(2, "Containment Priest"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Eidolon of Rhetoric"),
            new SampleCard(2, "Kor Firewalker"),
            new SampleCard(2, "Mirran Crusader"),
            new SampleCard(2, "Phyrexian Revoker"),
            new SampleCard(2, "Rest in Peace") 
        };
    }
}