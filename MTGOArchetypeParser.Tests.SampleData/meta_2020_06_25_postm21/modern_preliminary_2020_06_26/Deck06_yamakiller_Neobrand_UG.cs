using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_preliminary_2020_06_26
{
    public class Deck06_yamakiller_Neobrand_UG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Allosaurus Rider"),
            new SampleCard(2, "Autochthon Wurm"),
            new SampleCard(4, "Chancellor of the Tangle"),
            new SampleCard(1, "Children of Korlis"),
            new SampleCard(2, "Griselbrand"),
            new SampleCard(1, "Laboratory Maniac"),
            new SampleCard(4, "Simian Spirit Guide"),
            new SampleCard(1, "Street Wraith"),
            new SampleCard(1, "Wild Cantor"),
            new SampleCard(1, "Edge of Autumn"),
            new SampleCard(4, "Eldritch Evolution"),
            new SampleCard(4, "Neoform"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(4, "Nourishing Shoal"),
            new SampleCard(4, "Summoner's Pact"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(4, "Botanical Sanctum"),
            new SampleCard(4, "Gemstone Mine"),
            new SampleCard(1, "Island"),
            new SampleCard(4, "Waterlogged Grove") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(4, "Dissenter's Deliverance"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(4, "Leyline of Sanctity"),
            new SampleCard(4, "Pact of Negation") 
        };
    }
}