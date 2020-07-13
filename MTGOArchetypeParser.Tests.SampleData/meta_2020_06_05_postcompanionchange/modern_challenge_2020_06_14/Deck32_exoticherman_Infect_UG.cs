using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_14
{
    public class Deck32_exoticherman_Infect_UG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Birds of Paradise"),
            new SampleCard(4, "Blighted Agent"),
            new SampleCard(4, "Glistener Elf"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(1, "Spellskite"),
            new SampleCard(2, "Distortion Strike"),
            new SampleCard(4, "Scale Up"),
            new SampleCard(1, "Become Immense"),
            new SampleCard(2, "Blossoming Defense"),
            new SampleCard(1, "Dismember"),
            new SampleCard(2, "Groundswell"),
            new SampleCard(4, "Might of Old Krosa"),
            new SampleCard(4, "Mutagenic Growth"),
            new SampleCard(2, "Spell Pierce"),
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
            new SampleCard(1, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Spellskite"),
            new SampleCard(2, "Dismember"),
            new SampleCard(1, "Ceremonious Rejection"),
            new SampleCard(3, "Mystical Dispute"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(2, "Wilt") 
        };
    }
}