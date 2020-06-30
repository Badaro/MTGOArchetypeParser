using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck08_PaChA94s_AdNauseam_WUB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Simian Spirit Guide"),
            new SampleCard(3, "Thassa's Oracle"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(2, "Sleight of Hand"),
            new SampleCard(4, "Ad Nauseam"),
            new SampleCard(4, "Angel's Grace"),
            new SampleCard(1, "Lightning Storm"),
            new SampleCard(2, "Pact of Negation"),
            new SampleCard(4, "Spoils of the Vault"),
            new SampleCard(4, "Lotus Bloom"),
            new SampleCard(4, "Pentad Prism"),
            new SampleCard(4, "Phyrexian Unlife"),
            new SampleCard(2, "City of Brass"),
            new SampleCard(3, "Darkslick Shores"),
            new SampleCard(3, "Gemstone Mine"),
            new SampleCard(1, "Island"),
            new SampleCard(1, "Plains"),
            new SampleCard(3, "Seachrome Coast"),
            new SampleCard(1, "Swamp"),
            new SampleCard(4, "Temple of Deceit"),
            new SampleCard(2, "Temple of Enlightenment") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Pact of Negation"),
            new SampleCard(1, "Bontu's Last Reckoning"),
            new SampleCard(1, "Duress"),
            new SampleCard(2, "Echoing Truth"),
            new SampleCard(1, "Grand Abolisher"),
            new SampleCard(4, "Leyline of Sanctity"),
            new SampleCard(1, "Path to Exile"),
            new SampleCard(1, "Thoughtseize"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}