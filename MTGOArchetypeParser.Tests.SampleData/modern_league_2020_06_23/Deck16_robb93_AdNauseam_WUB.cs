using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_23
{
    public class Deck16_robb93_AdNauseam_WUB : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Simian Spirit Guide"),(4, "Thassa's Oracle"),(4, "Serum Visions"),(2, "Sleight of Hand"),(4, "Ad Nauseam"),(4, "Angel's Grace"),(1, "Lightning Storm"),(2, "Pact of Negation"),(4, "Spoils of the Vault"),(4, "Lotus Bloom"),(4, "Pentad Prism"),(3, "Phyrexian Unlife"),(2, "City of Brass"),(3, "Darkslick Shores"),(4, "Gemstone Mine"),(1, "Island"),(2, "Plains"),(3, "Seachrome Coast"),(3, "Temple of Deceit"),(2, "Temple of Enlightenment") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Pact of Negation"),(2, "Bontu's Last Reckoning"),(1, "Echoing Truth"),(4, "Leyline of Sanctity"),(1, "Slaughter Pact"),(3, "Thoughtseize"),(2, "Veil of Summer") }; } }
    }
}