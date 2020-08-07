using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_07
{
    public class Deck24_DaSneakyPete_AdNauseam_WUB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Simian Spirit Guide"),
            new SampleCard(4, "Thassa's Oracle"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(1, "Sleight of Hand"),
            new SampleCard(4, "Ad Nauseam"),
            new SampleCard(4, "Angel's Grace"),
            new SampleCard(1, "Lightning Storm"),
            new SampleCard(3, "Pact of Negation"),
            new SampleCard(4, "Spoils of the Vault"),
            new SampleCard(4, "Lotus Bloom"),
            new SampleCard(4, "Pentad Prism"),
            new SampleCard(3, "Phyrexian Unlife"),
            new SampleCard(4, "City of Brass"),
            new SampleCard(4, "Darkslick Shores"),
            new SampleCard(1, "Island"),
            new SampleCard(1, "Plains"),
            new SampleCard(4, "Seachrome Coast"),
            new SampleCard(3, "Temple of Deceit"),
            new SampleCard(3, "Temple of Enlightenment") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Pact of Negation"),
            new SampleCard(1, "Phyrexian Unlife"),
            new SampleCard(2, "Bontu's Last Reckoning"),
            new SampleCard(2, "Duress"),
            new SampleCard(1, "Echoing Truth"),
            new SampleCard(4, "Leyline of Sanctity"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(2, "Spell Pierce") 
        };
    }
}