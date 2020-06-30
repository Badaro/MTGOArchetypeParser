using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05
{
    public class Deck25_mashmalovsky_DeathAndTaxes_EldraziTaxes_WB : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Kaya, Orzhov Usurper"),(2, "Charming Prince"),(4, "Eldrazi Displacer"),(4, "Flickerwisp"),(4, "Leonin Arbiter"),(4, "Thalia, Guardian of Thraben"),(4, "Thought-Knot Seer"),(4, "Tidehollow Sculler"),(3, "Wasteland Strangler"),(4, "Path to Exile"),(4, "Aether Vial"),(4, "Caves of Koilos"),(4, "Concealed Courtyard"),(4, "Eldrazi Temple"),(4, "Ghost Quarter"),(3, "Plains"),(2, "Silent Clearing"),(1, "Swamp") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Kaya, Orzhov Usurper"),(2, "Fatal Push"),(1, "Gideon, Ally of Zendikar"),(2, "Kor Firewalker"),(1, "Kunoros, Hound of Athreos"),(1, "Orzhov Pontiff"),(3, "Rest in Peace"),(2, "Spirit of the Labyrinth"),(2, "Stony Silence") }; } }
    }
}