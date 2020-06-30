using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12
{
    public class Deck32_DrD1ckForest_AdNauseam_WUB : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Simian Spirit Guide"),(4, "Thassa's Oracle"),(4, "Serum Visions"),(1, "Sleight of Hand"),(4, "Ad Nauseam"),(4, "Angel's Grace"),(1, "Lightning Storm"),(1, "Manamorphose"),(2, "Pact of Negation"),(4, "Spoils of the Vault"),(4, "Lotus Bloom"),(4, "Pentad Prism"),(3, "Phyrexian Unlife"),(4, "City of Brass"),(3, "Darkslick Shores"),(4, "Gemstone Mine"),(1, "Island"),(1, "Plains"),(3, "Seachrome Coast"),(2, "Temple of Deceit"),(2, "Temple of Enlightenment") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Bontu's Last Reckoning"),(1, "Echoing Truth"),(1, "Fatal Push"),(1, "Gideon of the Trials"),(4, "Leyline of Sanctity"),(1, "Path to Exile"),(2, "Spell Pierce"),(3, "Veil of Summer") }; } }
    }
}