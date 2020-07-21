using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07
{
    public class Deck56_TBagTom_SnowControl_SultaiSnow_UBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ashiok, Nightmare Muse"),
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(1, "Liliana, the Last Hope"),
            new SampleCard(4, "Wrenn and Six"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(2, "Snapcaster Mage"),
            new SampleCard(2, "Uro, Titan of Nature's Wrath"),
            new SampleCard(3, "Dead of Winter"),
            new SampleCard(1, "Archmage's Charm"),
            new SampleCard(4, "Assassin's Trophy"),
            new SampleCard(2, "Cling to Dust"),
            new SampleCard(1, "Cryptic Command"),
            new SampleCard(3, "Drown in the Loch"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(1, "Kolaghan's Command"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(4, "Fabled Passage"),
            new SampleCard(3, "Field of Ruin"),
            new SampleCard(1, "Lonely Sandbar"),
            new SampleCard(4, "Prismatic Vista"),
            new SampleCard(3, "Snow-Covered Forest"),
            new SampleCard(4, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(2, "Snow-Covered Swamp") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Dead of Winter"),
            new SampleCard(1, "Force of Negation"),
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(1, "Fry"),
            new SampleCard(1, "Klothys, God of Destiny"),
            new SampleCard(4, "Leyline of the Void"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}