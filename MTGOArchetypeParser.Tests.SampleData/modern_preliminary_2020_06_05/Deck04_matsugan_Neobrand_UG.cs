using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_05
{
    public class Deck04_matsugan_Neobrand_UG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Allosaurus Rider"),(2, "Autochthon Wurm"),(4, "Chancellor of the Tangle"),(1, "Griselbrand"),(1, "Laboratory Maniac"),(4, "Simian Spirit Guide"),(1, "Street Wraith"),(1, "Wild Cantor"),(1, "Edge of Autumn"),(4, "Eldritch Evolution"),(4, "Neoform"),(4, "Serum Visions"),(1, "Life Goes On"),(4, "Manamorphose"),(4, "Nourishing Shoal"),(4, "Summoner's Pact"),(3, "Veil of Summer"),(4, "Botanical Sanctum"),(4, "Gemstone Mine"),(1, "Island"),(4, "Waterlogged Grove") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Veil of Summer"),(4, "Dissenter's Deliverance"),(3, "Leyline of Sanctity"),(4, "Pact of Negation"),(1, "Remand"),(1, "Slaughter Pact"),(1, "Tel-Jilad Justice") }; } }
    }
}