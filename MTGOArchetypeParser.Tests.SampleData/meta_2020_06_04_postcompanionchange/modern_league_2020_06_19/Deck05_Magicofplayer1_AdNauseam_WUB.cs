using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_19
{
    public class Deck05_Magicofplayer1_AdNauseam_WUB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Simian Spirit Guide"),
            new SampleCard(4, "Thassa's Oracle"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(4, "Ad Nauseam"),
            new SampleCard(4, "Angel's Grace"),
            new SampleCard(1, "Lightning Storm"),
            new SampleCard(3, "Pact of Negation"),
            new SampleCard(4, "Spoils of the Vault"),
            new SampleCard(4, "Lotus Bloom"),
            new SampleCard(4, "Pentad Prism"),
            new SampleCard(4, "Phyrexian Unlife"),
            new SampleCard(3, "City of Brass"),
            new SampleCard(2, "Darkslick Shores"),
            new SampleCard(4, "Gemstone Mine"),
            new SampleCard(3, "Seachrome Coast"),
            new SampleCard(1, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(3, "Temple of Deceit"),
            new SampleCard(2, "Temple of Enlightenment") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Pact of Negation"),
            new SampleCard(1, "Echoing Truth"),
            new SampleCard(4, "Leyline of Sanctity"),
            new SampleCard(1, "Path to Exile"),
            new SampleCard(2, "Slaughter Pact"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}