using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12
{
    public class Deck33_Mollok_ThaliaStompy_WR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Bonecrusher Giant"),
            new SampleCard(4, "Eldrazi Displacer"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(4, "Reality Smasher"),
            new SampleCard(4, "Simian Spirit Guide"),
            new SampleCard(4, "Thalia, Guardian of Thraben"),
            new SampleCard(2, "Thalia, Heretic Cathar"),
            new SampleCard(4, "Thought-Knot Seer"),
            new SampleCard(2, "Dismember"),
            new SampleCard(4, "Chalice of the Void"),
            new SampleCard(4, "Battlefield Forge"),
            new SampleCard(4, "Eldrazi Temple"),
            new SampleCard(3, "Gemstone Caverns"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(3, "Plains"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(4, "Sunbaked Canyon"),
            new SampleCard(1, "Wastes") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Wastes"),
            new SampleCard(2, "Abrade"),
            new SampleCard(2, "Hazoret the Fervent"),
            new SampleCard(2, "Hushbringer"),
            new SampleCard(2, "Magus of the Moon"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(2, "Winds of Abandon"),
            new SampleCard(2, "Worship") 
        };
    }
}