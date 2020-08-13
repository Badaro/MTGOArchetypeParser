using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_16
{
    public class Deck14_Rossello_AdNauseam_WUB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Simian Spirit Guide"),
            new SampleCard(3, "Thassa's Oracle"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(1, "Sleight of Hand"),
            new SampleCard(4, "Ad Nauseam"),
            new SampleCard(4, "Angel's Grace"),
            new SampleCard(1, "Lightning Storm"),
            new SampleCard(3, "Pact of Negation"),
            new SampleCard(4, "Spoils of the Vault"),
            new SampleCard(4, "Lotus Bloom"),
            new SampleCard(4, "Pentad Prism"),
            new SampleCard(4, "Phyrexian Unlife"),
            new SampleCard(4, "City of Brass"),
            new SampleCard(3, "Darkslick Shores"),
            new SampleCard(4, "Gemstone Mine"),
            new SampleCard(1, "Island"),
            new SampleCard(2, "Seachrome Coast"),
            new SampleCard(1, "Swamp"),
            new SampleCard(3, "Temple of Deceit"),
            new SampleCard(2, "Temple of Enlightenment") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Pact of Negation"),
            new SampleCard(3, "Assassin's Trophy"),
            new SampleCard(1, "Bontu's Last Reckoning"),
            new SampleCard(4, "Leyline of Sanctity"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}