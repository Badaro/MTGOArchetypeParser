using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_preliminary_2020_06_18
{
    public class Deck12_Traft_AdNauseam_WUB : ISampleDeck
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
            new SampleCard(2, "Pact of Negation"),
            new SampleCard(4, "Spoils of the Vault"),
            new SampleCard(4, "Lotus Bloom"),
            new SampleCard(4, "Pentad Prism"),
            new SampleCard(3, "Phyrexian Unlife"),
            new SampleCard(3, "City of Brass"),
            new SampleCard(3, "Darkslick Shores"),
            new SampleCard(4, "Gemstone Mine"),
            new SampleCard(1, "Island"),
            new SampleCard(2, "Plains"),
            new SampleCard(3, "Seachrome Coast"),
            new SampleCard(4, "Temple of Deceit") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Pact of Negation"),
            new SampleCard(1, "Phyrexian Unlife"),
            new SampleCard(4, "Leyline of Sanctity"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(2, "Sphinx of the Final Word"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}