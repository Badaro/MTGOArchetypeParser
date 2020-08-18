using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck18_harukispecial_SnowControl_SultaiSnow_UBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Jace, the Mind Sculptor"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(2, "Snapcaster Mage"),
            new SampleCard(1, "Tasigur, the Golden Fang"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(2, "Abrupt Decay"),
            new SampleCard(1, "Cryptic Command"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(3, "Mana Leak"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(2, "Creeping Tar Pit"),
            new SampleCard(3, "Misty Rainforest"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(4, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(2, "Watery Grave"),
            new SampleCard(1, "Zagoth Triome") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(3, "Kitchen Finks"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(4, "Spreading Seas"),
            new SampleCard(1, "Thragtusk") 
        };
    }
}