using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_06_29
{
    public class Deck26_unicornparadise_Infect_WUG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(4, "Blighted Agent"),
            new SampleCard(4, "Glistener Elf"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(1, "Spellskite"),
            new SampleCard(2, "Distortion Strike"),
            new SampleCard(4, "Scale Up"),
            new SampleCard(1, "Become Immense"),
            new SampleCard(4, "Blossoming Defense"),
            new SampleCard(1, "Dismember"),
            new SampleCard(4, "Groundswell"),
            new SampleCard(4, "Might of Old Krosa"),
            new SampleCard(2, "Spell Pierce"),
            new SampleCard(3, "Vines of Vastwood"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(2, "Forest"),
            new SampleCard(1, "Horizon Canopy"),
            new SampleCard(4, "Inkmoth Nexus"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Pendelhaven"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(2, "Windswept Heath"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Teferi, Time Raveler"),
            new SampleCard(2, "Force of Vigor"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(1, "Nature's Claim"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(1, "Pulse of Murasa"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(4, "Veil of Summer") 
        };
    }
}