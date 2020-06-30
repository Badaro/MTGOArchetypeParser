using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_19
{
    public class Deck13_eggybenny_Neobrand_UG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Allosaurus Rider"),(2, "Autochthon Wurm"),(4, "Chancellor of the Tangle"),(1, "Children of Korlis"),(1, "Griselbrand"),(1, "Laboratory Maniac"),(4, "Simian Spirit Guide"),(1, "Wild Cantor"),(4, "Eldritch Evolution"),(4, "Glittering Wish"),(3, "Neoform"),(4, "Manamorphose"),(4, "Nourishing Shoal"),(4, "Summoner's Pact"),(4, "Veil of Summer"),(3, "Botanical Sanctum"),(4, "City of Brass"),(4, "Gemstone Mine"),(1, "Horizon Canopy"),(1, "Mana Confluence"),(1, "Snow-Covered Forest"),(1, "Waterlogged Grove") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Neoform"),(3, "Abrupt Decay"),(2, "Dissenter's Deliverance"),(1, "Eladamri's Call"),(1, "Guttural Response"),(3, "Leyline of Sanctity"),(4, "Pact of Negation") }; } }
    }
}