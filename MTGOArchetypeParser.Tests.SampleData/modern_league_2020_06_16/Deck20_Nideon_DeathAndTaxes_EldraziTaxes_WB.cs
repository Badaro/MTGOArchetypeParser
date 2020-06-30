using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck20_Nideon_DeathAndTaxes_EldraziTaxes_WB : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Charming Prince"),(4, "Eldrazi Displacer"),(4, "Flickerwisp"),(4, "Leonin Arbiter"),(3, "Thalia, Guardian of Thraben"),(4, "Thought-Knot Seer"),(4, "Tidehollow Sculler"),(3, "Wasteland Strangler"),(4, "Path to Exile"),(4, "Aether Vial"),(4, "Caves of Koilos"),(4, "Concealed Courtyard"),(4, "Eldrazi Temple"),(4, "Ghost Quarter"),(2, "Plains"),(3, "Silent Clearing"),(1, "Swamp") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Aven Mindcensor"),(2, "Burrenton Forge-Tender"),(2, "Fatal Push"),(1, "Gideon, Ally of Zendikar"),(1, "Kambal, Consul of Allocation"),(1, "Kaya, Orzhov Usurper"),(1, "Kunoros, Hound of Athreos"),(2, "Orzhov Pontiff"),(2, "Rest in Peace"),(2, "Stony Silence") }; } }
    }
}