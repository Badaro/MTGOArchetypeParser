using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_03
{
    public class Deck18_Weasley_SnowControl_SnowReclamation_UBG_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(4, "Uro, Titan of Nature's Wrath"),
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(4, "Archmage's Charm"),
            new SampleCard(4, "Cryptic Command"),
            new SampleCard(3, "Fact or Fiction"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(4, "Growth Spiral"),
            new SampleCard(1, "Mystical Teachings"),
            new SampleCard(1, "Nexus of Fate"),
            new SampleCard(1, "Pulse of Murasa"),
            new SampleCard(4, "Remand"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(2, "Shark Typhoon"),
            new SampleCard(4, "Wilderness Reclamation"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(4, "Mystic Sanctuary"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(6, "Snow-Covered Island"),
            new SampleCard(1, "Watery Grave"),
            new SampleCard(1, "Zagoth Triome") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Shark Typhoon"),
            new SampleCard(4, "Aether Gust"),
            new SampleCard(2, "Dead of Winter"),
            new SampleCard(4, "Veil of Summer"),
            new SampleCard(2, "Weather the Storm"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}