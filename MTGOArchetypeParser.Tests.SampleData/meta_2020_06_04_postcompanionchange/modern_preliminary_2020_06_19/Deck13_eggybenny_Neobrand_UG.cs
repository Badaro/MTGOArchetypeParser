using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_preliminary_2020_06_19
{
    public class Deck13_eggybenny_Neobrand_UG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Allosaurus Rider"),
            new SampleCard(2, "Autochthon Wurm"),
            new SampleCard(4, "Chancellor of the Tangle"),
            new SampleCard(1, "Children of Korlis"),
            new SampleCard(1, "Griselbrand"),
            new SampleCard(1, "Laboratory Maniac"),
            new SampleCard(4, "Simian Spirit Guide"),
            new SampleCard(1, "Wild Cantor"),
            new SampleCard(4, "Eldritch Evolution"),
            new SampleCard(4, "Glittering Wish"),
            new SampleCard(3, "Neoform"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(4, "Nourishing Shoal"),
            new SampleCard(4, "Summoner's Pact"),
            new SampleCard(4, "Veil of Summer"),
            new SampleCard(3, "Botanical Sanctum"),
            new SampleCard(4, "City of Brass"),
            new SampleCard(4, "Gemstone Mine"),
            new SampleCard(1, "Horizon Canopy"),
            new SampleCard(1, "Mana Confluence"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(1, "Waterlogged Grove") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Neoform"),
            new SampleCard(3, "Abrupt Decay"),
            new SampleCard(2, "Dissenter's Deliverance"),
            new SampleCard(1, "Eladamri's Call"),
            new SampleCard(1, "Guttural Response"),
            new SampleCard(3, "Leyline of Sanctity"),
            new SampleCard(4, "Pact of Negation") 
        };
    }
}