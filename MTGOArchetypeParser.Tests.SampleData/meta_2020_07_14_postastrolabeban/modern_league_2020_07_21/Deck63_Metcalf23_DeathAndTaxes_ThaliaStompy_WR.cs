using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_21
{
    public class Deck63_Metcalf23_DeathAndTaxes_ThaliaStompy_WR : ISampleDeck
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
            new SampleCard(2, "Battlefield Forge"),
            new SampleCard(2, "Cavern of Souls"),
            new SampleCard(4, "Eldrazi Temple"),
            new SampleCard(3, "Gemstone Caverns"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(5, "Plains"),
            new SampleCard(4, "Sunbaked Canyon"),
            new SampleCard(1, "Wastes") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Hazoret the Fervent"),
            new SampleCard(3, "Hushbringer"),
            new SampleCard(3, "Magus of the Moon"),
            new SampleCard(3, "Rest in Peace"),
            new SampleCard(2, "Wear // Tear"),
            new SampleCard(2, "Worship") 
        };
    }
}