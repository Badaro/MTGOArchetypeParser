using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_04
{
    public class Deck30_MomentsPeace_DeathAndTaxes_EldraziTaxes_WB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Eldrazi Displacer"),
            new SampleCard(3, "Flickerwisp"),
            new SampleCard(3, "Giver of Runes"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Thalia, Guardian of Thraben"),
            new SampleCard(1, "Thalia, Heretic Cathar"),
            new SampleCard(4, "Thought-Knot Seer"),
            new SampleCard(2, "Tidehollow Sculler"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(4, "Caves of Koilos"),
            new SampleCard(4, "Eldrazi Temple"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(2, "Silent Clearing"),
            new SampleCard(5, "Snow-Covered Plains"),
            new SampleCard(1, "Swamp"),
            new SampleCard(1, "Tectonic Edge") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Tidehollow Sculler"),
            new SampleCard(2, "Containment Priest"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Duress"),
            new SampleCard(2, "Eidolon of Rhetoric"),
            new SampleCard(2, "Kor Firewalker"),
            new SampleCard(2, "Phyrexian Revoker"),
            new SampleCard(2, "Rest in Peace") 
        };
    }
}