using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13
{
    public class Deck01_Lavaridge_SnowControl_SultaiSnow_UBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(1, "Ashiok, Nightmare Muse"),
            new SampleCard(3, "Jace, the Mind Sculptor"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(1, "Snapcaster Mage"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Dead of Winter"),
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(1, "Cling to Dust"),
            new SampleCard(1, "Cryptic Command"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(3, "Mana Leak"),
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
            new SampleCard(4, "Aether Gust"),
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(1, "Ceremonious Rejection"),
            new SampleCard(1, "Jolrael, Mwonvuli Recluse"),
            new SampleCard(1, "Narset, Parter of Veils"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(1, "Plague Engineer"),
            new SampleCard(1, "Surgical Extraction"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}