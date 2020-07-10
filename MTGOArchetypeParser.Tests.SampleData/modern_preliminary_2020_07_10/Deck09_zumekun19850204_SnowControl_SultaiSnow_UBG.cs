using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_07_10
{
    public class Deck09_zumekun19850204_SnowControl_SultaiSnow_UBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(1, "Liliana, the Last Hope"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Dead of Winter"),
            new SampleCard(2, "Abrupt Decay"),
            new SampleCard(2, "Archmage's Charm"),
            new SampleCard(1, "Cling to Dust"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(1, "Deprive"),
            new SampleCard(2, "Drown in the Loch"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(3, "Field of Ruin"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(3, "Mystic Sanctuary"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "Scalding Tarn"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(5, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Watery Grave"),
            new SampleCard(1, "Zagoth Triome") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(3, "Nihil Spellbomb"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(1, "Thrun, the Last Troll"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}