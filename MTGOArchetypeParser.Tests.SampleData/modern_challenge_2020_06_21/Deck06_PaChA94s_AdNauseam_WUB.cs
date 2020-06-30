using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21
{
    public class Deck06_PaChA94s_AdNauseam_WUB : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Simian Spirit Guide"),(3, "Thassa's Oracle"),(4, "Serum Visions"),(1, "Sleight of Hand"),(4, "Ad Nauseam"),(4, "Angel's Grace"),(1, "Lightning Storm"),(3, "Pact of Negation"),(4, "Spoils of the Vault"),(4, "Lotus Bloom"),(4, "Pentad Prism"),(4, "Phyrexian Unlife"),(2, "City of Brass"),(3, "Darkslick Shores"),(4, "Gemstone Mine"),(1, "Island"),(1, "Plains"),(3, "Seachrome Coast"),(4, "Temple of Deceit"),(2, "Temple of Enlightenment") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Bontu's Last Reckoning"),(2, "Echoing Truth"),(1, "Grand Abolisher"),(4, "Leyline of Sanctity"),(1, "Path to Exile"),(2, "Thoughtseize"),(3, "Veil of Summer") }; } }
    }
}