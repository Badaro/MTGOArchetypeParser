using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_23
{
    public class Deck49_Pollu_AdNauseam_WUB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(4, "Thassa's Oracle"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(4, "Sleight of Hand"),
            new SampleCard(4, "Angel's Grace"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Pact of Negation"),
            new SampleCard(1, "Slaughter Pact"),
            new SampleCard(4, "Spoils of the Vault"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(4, "Pentad Prism"),
            new SampleCard(1, "Phyrexian Unlife"),
            new SampleCard(3, "Flooded Strand"),
            new SampleCard(1, "Godless Shrine"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(3, "Polluted Delta"),
            new SampleCard(4, "Prismatic Vista"),
            new SampleCard(5, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Slaughter Pact"),
            new SampleCard(3, "Aether Gust"),
            new SampleCard(3, "Ceremonious Rejection"),
            new SampleCard(2, "Dead of Winter"),
            new SampleCard(4, "Leyline of Sanctity"),
            new SampleCard(2, "Mystical Dispute") 
        };
    }
}