using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26
{
    public class Deck13_Borjillamtg10_AdNauseam_WUB : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Simian Spirit Guide"),(4, "Thassa's Oracle"),(4, "Serum Visions"),(4, "Ad Nauseam"),(4, "Angel's Grace"),(4, "Pact of Negation"),(4, "Spoils of the Vault"),(4, "Lotus Bloom"),(4, "Pentad Prism"),(4, "Phyrexian Unlife"),(3, "City of Brass"),(3, "Darkslick Shores"),(4, "Gemstone Mine"),(2, "Seachrome Coast"),(1, "Snow-Covered Island"),(1, "Snow-Covered Plains"),(1, "Snow-Covered Swamp"),(2, "Temple of Deceit"),(3, "Temple of Enlightenment") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Abrade"),(1, "Kozilek's Return"),(4, "Leyline of Sanctity"),(2, "Slaughter Pact"),(3, "Thoughtseize"),(3, "Veil of Summer") }; } }
    }
}