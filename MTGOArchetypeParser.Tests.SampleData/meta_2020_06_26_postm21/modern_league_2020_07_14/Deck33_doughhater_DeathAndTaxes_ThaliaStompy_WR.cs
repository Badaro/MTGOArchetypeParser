using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_14
{
    public class Deck33_doughhater_DeathAndTaxes_ThaliaStompy_WR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Containment Priest"),
            new SampleCard(4, "Eldrazi Displacer"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(4, "Reality Smasher"),
            new SampleCard(4, "Simian Spirit Guide"),
            new SampleCard(4, "Thalia, Guardian of Thraben"),
            new SampleCard(2, "Thalia, Heretic Cathar"),
            new SampleCard(4, "Thought-Knot Seer"),
            new SampleCard(3, "Dismember"),
            new SampleCard(4, "Chalice of the Void"),
            new SampleCard(4, "Battlefield Forge"),
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(4, "Eldrazi Temple"),
            new SampleCard(3, "Gemstone Caverns"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(4, "Snow-Covered Plains"),
            new SampleCard(4, "Sunbaked Canyon"),
            new SampleCard(1, "Wastes") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Abrade"),
            new SampleCard(3, "Boil"),
            new SampleCard(2, "Hushbringer"),
            new SampleCard(3, "Rest in Peace"),
            new SampleCard(2, "Warping Wail"),
            new SampleCard(1, "Wear // Tear"),
            new SampleCard(2, "Winds of Abandon") 
        };
    }
}