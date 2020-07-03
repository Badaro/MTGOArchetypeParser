using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03
{
    public class Deck26_Blkspds_Neobrand_UG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Allosaurus Rider"),
            new SampleCard(2, "Autochthon Wurm"),
            new SampleCard(4, "Chancellor of the Tangle"),
            new SampleCard(2, "Griselbrand"),
            new SampleCard(4, "Simian Spirit Guide"),
            new SampleCard(1, "Thassa's Oracle"),
            new SampleCard(1, "Wild Cantor"),
            new SampleCard(4, "Eldritch Evolution"),
            new SampleCard(4, "Neoform"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(1, "Life Goes On"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(4, "Nourishing Shoal"),
            new SampleCard(2, "Noxious Revival"),
            new SampleCard(4, "Summoner's Pact"),
            new SampleCard(1, "Veil of Summer"),
            new SampleCard(4, "Botanical Sanctum"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Forest"),
            new SampleCard(4, "Gemstone Mine"),
            new SampleCard(4, "Waterlogged Grove") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(4, "Leyline of Sanctity"),
            new SampleCard(3, "Nature's Claim"),
            new SampleCard(3, "Pact of Negation"),
            new SampleCard(2, "Pyroclasm"),
            new SampleCard(1, "Slaughter Pact") 
        };
    }
}