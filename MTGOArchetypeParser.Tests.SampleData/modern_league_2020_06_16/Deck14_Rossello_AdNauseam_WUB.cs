using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck14_Rossello_AdNauseam_WUB : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Simian Spirit Guide"),(3, "Thassa's Oracle"),(4, "Serum Visions"),(1, "Sleight of Hand"),(4, "Ad Nauseam"),(4, "Angel's Grace"),(1, "Lightning Storm"),(3, "Pact of Negation"),(4, "Spoils of the Vault"),(4, "Lotus Bloom"),(4, "Pentad Prism"),(4, "Phyrexian Unlife"),(4, "City of Brass"),(3, "Darkslick Shores"),(4, "Gemstone Mine"),(1, "Island"),(2, "Seachrome Coast"),(1, "Swamp"),(3, "Temple of Deceit"),(2, "Temple of Enlightenment") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Pact of Negation"),(3, "Assassin's Trophy"),(1, "Bontu's Last Reckoning"),(4, "Leyline of Sanctity"),(3, "Thoughtseize"),(3, "Veil of Summer") }; } }
    }
}