using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16
{
    public class Deck15_osmanozguney_SnowControl_SultaiSnow_UBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(1, "Lochmere Serpent"),
            new SampleCard(4, "Uro, Titan of Nature's Wrath"),
            new SampleCard(1, "Dead of Winter"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(2, "Life from the Loam"),
            new SampleCard(1, "Maelstrom Pulse"),
            new SampleCard(1, "Raven's Crime"),
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(2, "Gifts Ungiven"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Field of Ruin"),
            new SampleCard(1, "Field of the Dead"),
            new SampleCard(1, "Lonely Sandbar"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(2, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Tranquil Thicket"),
            new SampleCard(2, "Verdant Catacombs"),
            new SampleCard(1, "Watery Grave"),
            new SampleCard(1, "Zagoth Triome") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Dead of Winter"),
            new SampleCard(1, "Fatal Push"),
            new SampleCard(4, "Aether Gust"),
            new SampleCard(1, "Bojuka Bog"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(2, "Unmoored Ego"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}