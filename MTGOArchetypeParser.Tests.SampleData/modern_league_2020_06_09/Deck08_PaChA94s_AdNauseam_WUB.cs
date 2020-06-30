using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck08_PaChA94s_AdNauseam_WUB : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Simian Spirit Guide"),(3, "Thassa's Oracle"),(4, "Serum Visions"),(2, "Sleight of Hand"),(4, "Ad Nauseam"),(4, "Angel's Grace"),(1, "Lightning Storm"),(2, "Pact of Negation"),(4, "Spoils of the Vault"),(4, "Lotus Bloom"),(4, "Pentad Prism"),(4, "Phyrexian Unlife"),(2, "City of Brass"),(3, "Darkslick Shores"),(3, "Gemstone Mine"),(1, "Island"),(1, "Plains"),(3, "Seachrome Coast"),(1, "Swamp"),(4, "Temple of Deceit"),(2, "Temple of Enlightenment") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Pact of Negation"),(1, "Bontu's Last Reckoning"),(1, "Duress"),(2, "Echoing Truth"),(1, "Grand Abolisher"),(4, "Leyline of Sanctity"),(1, "Path to Exile"),(1, "Thoughtseize"),(3, "Veil of Summer") }; } }
    }
}