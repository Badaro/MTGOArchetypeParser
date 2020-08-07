using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_07
{
    public class Deck60_Luzur_SnowControl_SultaiSnow_UBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(2, "Liliana, the Last Hope"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(2, "Tasigur, the Golden Fang"),
            new SampleCard(2, "Uro, Titan of Nature's Wrath"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(2, "Cryptic Command"),
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
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(4, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(2, "Watery Grave"),
            new SampleCard(1, "Zagoth Triome") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(2, "Kitchen Finks"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(1, "Thragtusk"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}