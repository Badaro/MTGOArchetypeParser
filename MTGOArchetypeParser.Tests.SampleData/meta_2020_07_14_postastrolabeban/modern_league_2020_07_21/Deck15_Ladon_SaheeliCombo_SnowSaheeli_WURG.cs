using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_21
{
    public class Deck15_Ladon_SaheeliCombo_SnowSaheeli_WURG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Saheeli Rai"),
            new SampleCard(4, "Teferi, Time Raveler"),
            new SampleCard(2, "Wrenn and Six"),
            new SampleCard(3, "Birds of Paradise"),
            new SampleCard(4, "Felidar Guardian"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(3, "Spell Queller"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(4, "Oath of Nissa"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Horizon Canopy"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(1, "Prismatic Vista"),
            new SampleCard(3, "Snow-Covered Forest"),
            new SampleCard(3, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Path to Exile"),
            new SampleCard(3, "Aether Gust"),
            new SampleCard(3, "Ashiok, Dream Render"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(2, "Flame Sweep"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(2, "Obstinate Baloth") 
        };
    }
}