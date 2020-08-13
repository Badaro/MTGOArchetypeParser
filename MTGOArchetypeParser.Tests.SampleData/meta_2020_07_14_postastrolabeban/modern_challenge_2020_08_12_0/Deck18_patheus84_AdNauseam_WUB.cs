using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_challenge_2020_08_12_0
{
    public class Deck18_patheus84_AdNauseam_WUB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Simian Spirit Guide"),
            new SampleCard(3, "Thassa's Oracle"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(3, "Sleight of Hand"),
            new SampleCard(4, "Ad Nauseam"),
            new SampleCard(4, "Angel's Grace"),
            new SampleCard(1, "Lightning Storm"),
            new SampleCard(1, "Pact of Negation"),
            new SampleCard(4, "Spoils of the Vault"),
            new SampleCard(4, "Lotus Bloom"),
            new SampleCard(4, "Pentad Prism"),
            new SampleCard(4, "Phyrexian Unlife"),
            new SampleCard(4, "City of Brass"),
            new SampleCard(3, "Darkslick Shores"),
            new SampleCard(4, "Gemstone Mine"),
            new SampleCard(1, "Island"),
            new SampleCard(1, "Plains"),
            new SampleCard(3, "Seachrome Coast"),
            new SampleCard(2, "Temple of Deceit"),
            new SampleCard(2, "Temple of Enlightenment") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Pact of Negation"),
            new SampleCard(2, "Echoing Truth"),
            new SampleCard(4, "Leyline of Sanctity"),
            new SampleCard(2, "Slaughter Pact"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}