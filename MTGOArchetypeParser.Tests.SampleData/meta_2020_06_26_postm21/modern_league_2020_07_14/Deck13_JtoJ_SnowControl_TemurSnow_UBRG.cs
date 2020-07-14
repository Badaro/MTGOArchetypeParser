using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_14
{
    public class Deck13_JtoJ_SnowControl_TemurSnow_UBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(3, "Wrenn and Six"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(2, "Tarmogoyf"),
            new SampleCard(2, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Rise // Fall"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(2, "Assassin's Trophy"),
            new SampleCard(3, "Kolaghan's Command"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(2, "Bloodstained Mire"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Ketria Triome"),
            new SampleCard(2, "Misty Rainforest"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(2, "Polluted Delta"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(1, "Verdant Catacombs"),
            new SampleCard(1, "Watery Grave"),
            new SampleCard(1, "Wooded Foothills"),
            new SampleCard(1, "Zagoth Triome") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Dead of Winter"),
            new SampleCard(2, "Disdainful Stroke"),
            new SampleCard(1, "Notion Thief"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(2, "Surgical Extraction"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}