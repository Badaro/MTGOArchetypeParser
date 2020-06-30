using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_18
{
    public class Deck12_Traft_AdNauseam_WUB : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Simian Spirit Guide"),(3, "Thassa's Oracle"),(4, "Serum Visions"),(3, "Sleight of Hand"),(4, "Ad Nauseam"),(4, "Angel's Grace"),(1, "Lightning Storm"),(2, "Pact of Negation"),(4, "Spoils of the Vault"),(4, "Lotus Bloom"),(4, "Pentad Prism"),(3, "Phyrexian Unlife"),(3, "City of Brass"),(3, "Darkslick Shores"),(4, "Gemstone Mine"),(1, "Island"),(2, "Plains"),(3, "Seachrome Coast"),(4, "Temple of Deceit") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Pact of Negation"),(1, "Phyrexian Unlife"),(4, "Leyline of Sanctity"),(2, "Path to Exile"),(2, "Sphinx of the Final Word"),(2, "Thoughtseize"),(3, "Veil of Summer") }; } }
    }
}