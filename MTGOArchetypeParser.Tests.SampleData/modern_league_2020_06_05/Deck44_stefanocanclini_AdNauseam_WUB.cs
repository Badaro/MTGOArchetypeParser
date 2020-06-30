using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05
{
    public class Deck44_stefanocanclini_AdNauseam_WUB : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Simian Spirit Guide"),(4, "Thassa's Oracle"),(4, "Serum Visions"),(4, "Ad Nauseam"),(4, "Angel's Grace"),(1, "Lightning Storm"),(3, "Pact of Negation"),(4, "Spoils of the Vault"),(4, "Lotus Bloom"),(4, "Pentad Prism"),(4, "Phyrexian Unlife"),(4, "City of Brass"),(3, "Darkslick Shores"),(4, "Gemstone Mine"),(2, "Plains"),(3, "Seachrome Coast"),(4, "Temple of Deceit") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Echoing Truth"),(4, "Leyline of Sanctity"),(1, "Path to Exile"),(2, "Slaughter Pact"),(1, "Sphinx of the Final Word"),(2, "Thoughtseize"),(3, "Veil of Summer"),(1, "Wear // Tear") }; } }
    }
}