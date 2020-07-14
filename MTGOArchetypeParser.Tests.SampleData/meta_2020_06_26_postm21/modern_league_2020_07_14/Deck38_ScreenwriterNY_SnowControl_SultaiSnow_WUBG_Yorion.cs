using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_14
{
    public class Deck38_ScreenwriterNY_SnowControl_SultaiSnow_WUBG_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Jace, the Mind Sculptor"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(4, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(2, "Dead of Winter"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(2, "Abrupt Decay"),
            new SampleCard(2, "Archmage's Charm"),
            new SampleCard(3, "Assassin's Trophy"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(3, "Drown in the Loch"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(2, "Kaya's Guile"),
            new SampleCard(3, "Mana Leak"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(4, "Abundant Growth"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Creeping Tar Pit"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(3, "Prismatic Vista"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(6, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Watery Grave"),
            new SampleCard(1, "Zagoth Triome") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(3, "Ashiok, Dream Render"),
            new SampleCard(4, "Ceremonious Rejection"),
            new SampleCard(2, "Disdainful Stroke"),
            new SampleCard(3, "Veil of Summer"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}