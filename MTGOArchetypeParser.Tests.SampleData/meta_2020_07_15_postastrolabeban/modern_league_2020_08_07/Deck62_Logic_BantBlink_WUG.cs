using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_07
{
    public class Deck62_Logic_BantBlink_WUG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Teferi, Time Raveler"),
            new SampleCard(3, "Birds of Paradise"),
            new SampleCard(1, "Deputy of Detention"),
            new SampleCard(3, "Eternal Witness"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(1, "Meddling Mage"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(2, "Soulherder"),
            new SampleCard(1, "Uro, Titan of Nature's Wrath"),
            new SampleCard(1, "Venser, Shaper Savant"),
            new SampleCard(1, "Wall of Blossoms"),
            new SampleCard(4, "Watcher for Tomorrow"),
            new SampleCard(3, "Neoform"),
            new SampleCard(4, "Ephemerate"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(3, "Flooded Strand"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(3, "Misty Rainforest"),
            new SampleCard(3, "Snow-Covered Forest"),
            new SampleCard(2, "Snow-Covered Island"),
            new SampleCard(2, "Snow-Covered Plains"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(3, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(3, "Ashiok, Dream Render"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(1, "Gaddock Teeg"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(1, "Reflector Mage"),
            new SampleCard(1, "Thragtusk"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}