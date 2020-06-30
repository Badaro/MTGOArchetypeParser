using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_19
{
    public class Deck01_SparTaNxX_Neobrand_UG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Allosaurus Rider"),(2, "Autochthon Wurm"),(4, "Chancellor of the Tangle"),(2, "Griselbrand"),(1, "Laboratory Maniac"),(4, "Simian Spirit Guide"),(1, "Wild Cantor"),(4, "Eldritch Evolution"),(4, "Neoform"),(4, "Serum Visions"),(1, "Life Goes On"),(4, "Manamorphose"),(4, "Nourishing Shoal"),(4, "Summoner's Pact"),(3, "Veil of Summer"),(4, "Botanical Sanctum"),(1, "Forest"),(4, "Gemstone Mine"),(1, "Snow-Covered Island"),(4, "Waterlogged Grove") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Chromatic Lantern"),(3, "Dissenter's Deliverance"),(3, "Leyline of Sanctity"),(4, "Pact of Negation"),(3, "Slaughter Pact"),(1, "Wilt") }; } }
    }
}