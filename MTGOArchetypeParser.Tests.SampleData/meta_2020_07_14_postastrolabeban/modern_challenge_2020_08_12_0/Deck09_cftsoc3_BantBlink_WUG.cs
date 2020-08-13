using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_challenge_2020_08_12_0
{
    public class Deck09_cftsoc3_BantBlink_WUG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Teferi, Time Raveler"),
            new SampleCard(4, "Eternal Witness"),
            new SampleCard(1, "Gaddock Teeg"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(1, "Meddling Mage"),
            new SampleCard(2, "Noble Hierarch"),
            new SampleCard(1, "Soulherder"),
            new SampleCard(1, "Stonehorn Dignitary"),
            new SampleCard(1, "Thassa, Deep-Dwelling"),
            new SampleCard(2, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Venser, Shaper Savant"),
            new SampleCard(3, "Watcher for Tomorrow"),
            new SampleCard(4, "Eladamri's Call"),
            new SampleCard(4, "Ephemerate"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Canopy Vista"),
            new SampleCard(3, "Flooded Strand"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(3, "Misty Rainforest"),
            new SampleCard(1, "Prairie Stream"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(2, "Snow-Covered Island"),
            new SampleCard(2, "Snow-Covered Plains"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(4, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Gaddock Teeg"),
            new SampleCard(1, "Meddling Mage"),
            new SampleCard(1, "Path to Exile"),
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(3, "Aether Gust"),
            new SampleCard(3, "Ashiok, Dream Render"),
            new SampleCard(1, "Burrenton Forge-Tender"),
            new SampleCard(1, "Celestial Purge"),
            new SampleCard(1, "Collector Ouphe"),
            new SampleCard(1, "Lavinia of the Tenth") 
        };
    }
}