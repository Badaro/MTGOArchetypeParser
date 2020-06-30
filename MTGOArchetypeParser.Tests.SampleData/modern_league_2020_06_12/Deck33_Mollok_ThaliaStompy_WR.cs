using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12
{
    public class Deck33_Mollok_ThaliaStompy_WR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Bonecrusher Giant"),(4, "Eldrazi Displacer"),(4, "Leonin Arbiter"),(4, "Reality Smasher"),(4, "Simian Spirit Guide"),(4, "Thalia, Guardian of Thraben"),(2, "Thalia, Heretic Cathar"),(4, "Thought-Knot Seer"),(2, "Dismember"),(4, "Chalice of the Void"),(4, "Battlefield Forge"),(4, "Eldrazi Temple"),(3, "Gemstone Caverns"),(4, "Ghost Quarter"),(3, "Plains"),(1, "Sacred Foundry"),(4, "Sunbaked Canyon"),(1, "Wastes") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Wastes"),(2, "Abrade"),(2, "Hazoret the Fervent"),(2, "Hushbringer"),(2, "Magus of the Moon"),(2, "Rest in Peace"),(2, "Winds of Abandon"),(2, "Worship") }; } }
    }
}