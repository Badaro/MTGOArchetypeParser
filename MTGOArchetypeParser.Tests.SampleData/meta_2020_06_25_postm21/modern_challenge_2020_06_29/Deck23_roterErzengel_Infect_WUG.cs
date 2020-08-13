using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_challenge_2020_06_29
{
    public class Deck23_roterErzengel_Infect_WUG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Teferi, Time Raveler"),
            new SampleCard(4, "Blighted Agent"),
            new SampleCard(4, "Glistener Elf"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(1, "Spellskite"),
            new SampleCard(2, "Distortion Strike"),
            new SampleCard(4, "Scale Up"),
            new SampleCard(1, "Become Immense"),
            new SampleCard(3, "Blossoming Defense"),
            new SampleCard(1, "Dismember"),
            new SampleCard(4, "Groundswell"),
            new SampleCard(4, "Might of Old Krosa"),
            new SampleCard(2, "Mutagenic Growth"),
            new SampleCard(2, "Spell Pierce"),
            new SampleCard(3, "Vines of Vastwood"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(2, "Forest"),
            new SampleCard(1, "Horizon Canopy"),
            new SampleCard(4, "Inkmoth Nexus"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(2, "Pendelhaven"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(2, "Waterlogged Grove"),
            new SampleCard(3, "Windswept Heath"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ceremonious Rejection"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(3, "Nature's Claim"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(1, "Pulse of Murasa"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}