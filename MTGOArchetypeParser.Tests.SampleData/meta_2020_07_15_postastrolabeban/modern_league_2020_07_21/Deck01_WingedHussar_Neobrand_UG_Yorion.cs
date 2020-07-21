using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_21
{
    public class Deck01_WingedHussar_Neobrand_UG_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Allosaurus Rider"),
            new SampleCard(4, "Autochthon Wurm"),
            new SampleCard(4, "Chancellor of the Tangle"),
            new SampleCard(1, "Children of Korlis"),
            new SampleCard(2, "Griselbrand"),
            new SampleCard(1, "Laboratory Maniac"),
            new SampleCard(4, "Simian Spirit Guide"),
            new SampleCard(1, "Wild Cantor"),
            new SampleCard(1, "Conflagrate"),
            new SampleCard(4, "Eldritch Evolution"),
            new SampleCard(4, "Neoform"),
            new SampleCard(1, "Safewright Quest"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(4, "Sleight of Hand"),
            new SampleCard(4, "Dissenter's Deliverance"),
            new SampleCard(1, "Life Goes On"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(4, "Nourishing Shoal"),
            new SampleCard(2, "Noxious Revival"),
            new SampleCard(4, "Summoner's Pact"),
            new SampleCard(4, "Veil of Summer"),
            new SampleCard(4, "Botanical Sanctum"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(4, "Gemstone Mine"),
            new SampleCard(1, "Island"),
            new SampleCard(4, "Waterlogged Grove"),
            new SampleCard(4, "Yavimaya Coast") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Leyline of Sanctity"),
            new SampleCard(4, "Pact of Negation"),
            new SampleCard(4, "Rhonas's Last Stand"),
            new SampleCard(2, "Spell Pierce"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}