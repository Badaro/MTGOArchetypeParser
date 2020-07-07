using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_07
{
    public class Deck08_twilightSSparkle_Neobrand_WUG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Allosaurus Rider"),
            new SampleCard(2, "Autochthon Wurm"),
            new SampleCard(3, "Chancellor of the Tangle"),
            new SampleCard(2, "Griselbrand"),
            new SampleCard(1, "Laboratory Maniac"),
            new SampleCard(4, "Simian Spirit Guide"),
            new SampleCard(4, "Eldritch Evolution"),
            new SampleCard(4, "Glittering Wish"),
            new SampleCard(3, "Neoform"),
            new SampleCard(1, "Safewright Quest"),
            new SampleCard(1, "Dissenter's Deliverance"),
            new SampleCard(1, "Life Goes On"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(4, "Nourishing Shoal"),
            new SampleCard(4, "Summoner's Pact"),
            new SampleCard(3, "Veil of Summer"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "City of Brass"),
            new SampleCard(4, "Gemstone Mine"),
            new SampleCard(1, "Horizon Canopy"),
            new SampleCard(4, "Mana Confluence"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(1, "Tranquil Thicket"),
            new SampleCard(1, "Waterlogged Grove") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Neoform"),
            new SampleCard(1, "Safewright Quest"),
            new SampleCard(2, "Abrupt Decay"),
            new SampleCard(2, "Assassin's Trophy"),
            new SampleCard(1, "Eladamri's Call"),
            new SampleCard(1, "Guttural Response"),
            new SampleCard(3, "Leyline of Sanctity"),
            new SampleCard(4, "Pact of Negation") 
        };
    }
}