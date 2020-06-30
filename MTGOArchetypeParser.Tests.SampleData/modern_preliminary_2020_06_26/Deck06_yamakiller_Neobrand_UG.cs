using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_26
{
    public class Deck06_yamakiller_Neobrand_UG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Allosaurus Rider"),(2, "Autochthon Wurm"),(4, "Chancellor of the Tangle"),(1, "Children of Korlis"),(2, "Griselbrand"),(1, "Laboratory Maniac"),(4, "Simian Spirit Guide"),(1, "Street Wraith"),(1, "Wild Cantor"),(1, "Edge of Autumn"),(4, "Eldritch Evolution"),(4, "Neoform"),(4, "Serum Visions"),(4, "Manamorphose"),(4, "Nourishing Shoal"),(4, "Summoner's Pact"),(2, "Veil of Summer"),(4, "Botanical Sanctum"),(4, "Gemstone Mine"),(1, "Island"),(4, "Waterlogged Grove") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Veil of Summer"),(4, "Dissenter's Deliverance"),(1, "Engineered Explosives"),(4, "Leyline of Sanctity"),(4, "Pact of Negation") }; } }
    }
}