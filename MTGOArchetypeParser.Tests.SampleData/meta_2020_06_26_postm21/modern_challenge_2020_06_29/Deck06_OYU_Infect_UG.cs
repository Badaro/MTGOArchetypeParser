using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_06_29
{
    public class Deck06_OYU_Infect_UG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Blighted Agent"),
            new SampleCard(4, "Glistener Elf"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(1, "Spellskite"),
            new SampleCard(2, "Distortion Strike"),
            new SampleCard(3, "Scale Up"),
            new SampleCard(1, "Sylvan Scrying"),
            new SampleCard(1, "Become Immense"),
            new SampleCard(3, "Blossoming Defense"),
            new SampleCard(3, "Groundswell"),
            new SampleCard(4, "Might of Old Krosa"),
            new SampleCard(4, "Mutagenic Growth"),
            new SampleCard(1, "Spell Pierce"),
            new SampleCard(4, "Vines of Vastwood"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(1, "Dryad Arbor"),
            new SampleCard(2, "Forest"),
            new SampleCard(4, "Inkmoth Nexus"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(2, "Pendelhaven"),
            new SampleCard(2, "Verdant Catacombs"),
            new SampleCard(3, "Waterlogged Grove"),
            new SampleCard(2, "Windswept Heath"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Spellskite"),
            new SampleCard(1, "Spell Pierce"),
            new SampleCard(1, "Aether Gust"),
            new SampleCard(2, "Dismember"),
            new SampleCard(1, "Nature's Claim"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(2, "Wilt") 
        };
    }
}