using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_06_30
{
    public class Deck31_FabriceK_SnowControl_SnowReclamation_UBG_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(1, "Dead of Winter"),
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(4, "Archmage's Charm"),
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(4, "Cryptic Command"),
            new SampleCard(4, "Fact or Fiction"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(4, "Growth Spiral"),
            new SampleCard(2, "Nexus of Fate"),
            new SampleCard(4, "Remand"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(1, "Search for Azcanta"),
            new SampleCard(4, "Wilderness Reclamation"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(3, "Field of Ruin"),
            new SampleCard(2, "Flooded Strand"),
            new SampleCard(3, "Misty Rainforest"),
            new SampleCard(4, "Mystic Sanctuary"),
            new SampleCard(3, "Polluted Delta"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(6, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Watery Grave"),
            new SampleCard(1, "Zagoth Triome") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(2, "Dead of Winter"),
            new SampleCard(3, "Aether Gust"),
            new SampleCard(1, "Ceremonious Rejection"),
            new SampleCard(1, "Flusterstorm"),
            new SampleCard(1, "Negate"),
            new SampleCard(3, "Shark Typhoon"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}