using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10
{
    public class Deck18_Do0mSwitch_SnowControl_SultaiSnow_UBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(3, "Jace, the Mind Sculptor"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(2, "Snapcaster Mage"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(1, "Dead of Winter"),
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(1, "Cling to Dust"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
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
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(1, "Dead of Winter"),
            new SampleCard(3, "Aether Gust"),
            new SampleCard(1, "Ceremonious Rejection"),
            new SampleCard(2, "Jolrael, Mwonvuli Recluse"),
            new SampleCard(1, "Negate"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(1, "Plague Engineer"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}