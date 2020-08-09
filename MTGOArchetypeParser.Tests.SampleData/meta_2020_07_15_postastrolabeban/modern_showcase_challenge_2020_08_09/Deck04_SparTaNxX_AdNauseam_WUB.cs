using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_showcase_challenge_2020_08_09
{
    public class Deck04_SparTaNxX_AdNauseam_WUB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Simian Spirit Guide"),
            new SampleCard(3, "Thassa's Oracle"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(4, "Ad Nauseam"),
            new SampleCard(4, "Angel's Grace"),
            new SampleCard(1, "Lightning Storm"),
            new SampleCard(4, "Pact of Negation"),
            new SampleCard(4, "Spoils of the Vault"),
            new SampleCard(4, "Lotus Bloom"),
            new SampleCard(4, "Pentad Prism"),
            new SampleCard(4, "Phyrexian Unlife"),
            new SampleCard(4, "City of Brass"),
            new SampleCard(3, "Darkslick Shores"),
            new SampleCard(2, "Gemstone Mine"),
            new SampleCard(2, "Plains"),
            new SampleCard(4, "Seachrome Coast"),
            new SampleCard(4, "Temple of Deceit"),
            new SampleCard(1, "Temple of Enlightenment") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Chromatic Lantern"),
            new SampleCard(1, "Echoing Truth"),
            new SampleCard(2, "Grand Abolisher"),
            new SampleCard(4, "Leyline of Sanctity"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(1, "Slaughter Pact"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}