using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_10
{
    public class Deck37_gobboboy_DeathAndTaxes_EldraziTaxes_WB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Eldrazi Displacer"),
            new SampleCard(4, "Flickerwisp"),
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(3, "Thalia, Guardian of Thraben"),
            new SampleCard(4, "Thought-Knot Seer"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(4, "Caves of Koilos"),
            new SampleCard(4, "Eldrazi Temple"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(6, "Plains"),
            new SampleCard(4, "Silent Clearing") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Containment Priest"),
            new SampleCard(3, "Eidolon of Rhetoric"),
            new SampleCard(2, "Kor Firewalker"),
            new SampleCard(2, "Light of Hope"),
            new SampleCard(3, "Plague Engineer"),
            new SampleCard(2, "Rest in Peace") 
        };
    }
}