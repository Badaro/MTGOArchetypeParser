using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_28
{
    public class Deck05_RodeoJones_SaheeliCombo_SnowSaheeli_WURG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Saheeli Rai"),
            new SampleCard(3, "Teferi, Time Raveler"),
            new SampleCard(3, "Wrenn and Six"),
            new SampleCard(1, "Birds of Paradise"),
            new SampleCard(2, "Brazen Borrower"),
            new SampleCard(2, "Coiling Oracle"),
            new SampleCard(3, "Felidar Guardian"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(3, "Noble Hierarch"),
            new SampleCard(2, "Uro, Titan of Nature's Wrath"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(1, "Abundant Growth"),
            new SampleCard(4, "Oath of Nissa"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(2, "Flooded Strand"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(1, "Prismatic Vista"),
            new SampleCard(3, "Snow-Covered Forest"),
            new SampleCard(3, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(1, "Waterlogged Grove"),
            new SampleCard(3, "Windswept Heath"),
            new SampleCard(1, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Path to Exile"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Blessed Alliance"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(2, "Reflector Mage"),
            new SampleCard(1, "Spell Pierce"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}