using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_21
{
    public class Deck38_TBagTom_SnowControl_SultaiSnow_UBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(4, "Wrenn and Six"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(2, "Snapcaster Mage"),
            new SampleCard(2, "Uro, Titan of Nature's Wrath"),
            new SampleCard(3, "Dead of Winter"),
            new SampleCard(2, "Archmage's Charm"),
            new SampleCard(4, "Assassin's Trophy"),
            new SampleCard(2, "Cling to Dust"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(4, "Drown in the Loch"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(1, "Kolaghan's Command"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(2, "Field of Ruin"),
            new SampleCard(1, "Ketria Triome"),
            new SampleCard(1, "Lonely Sandbar"),
            new SampleCard(3, "Misty Rainforest"),
            new SampleCard(1, "Mystic Sanctuary"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(3, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Watery Grave"),
            new SampleCard(1, "Zagoth Triome") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Field of Ruin"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(2, "Chandra, Awakened Inferno"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(1, "Izzet Staticaster"),
            new SampleCard(1, "Klothys, God of Destiny"),
            new SampleCard(2, "Surgical Extraction"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}