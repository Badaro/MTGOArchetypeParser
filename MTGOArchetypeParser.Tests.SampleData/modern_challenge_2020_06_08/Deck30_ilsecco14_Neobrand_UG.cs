using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_08
{
    public class Deck30_ilsecco14_Neobrand_UG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Allosaurus Rider"),(2, "Autochthon Wurm"),(4, "Chancellor of the Tangle"),(2, "Griselbrand"),(1, "Laboratory Maniac"),(4, "Simian Spirit Guide"),(1, "Wild Cantor"),(4, "Eldritch Evolution"),(4, "Neoform"),(4, "Serum Visions"),(1, "Dissenter's Deliverance"),(1, "Life Goes On"),(4, "Manamorphose"),(4, "Nourishing Shoal"),(1, "Noxious Revival"),(4, "Summoner's Pact"),(2, "Veil of Summer"),(4, "Botanical Sanctum"),(4, "Gemstone Mine"),(1, "Snow-Covered Forest"),(4, "Waterlogged Grove") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Dissenter's Deliverance"),(2, "Veil of Summer"),(3, "Leyline of Sanctity"),(4, "Pact of Negation"),(3, "Slaughter Pact"),(2, "Wilt") }; } }
    }
}