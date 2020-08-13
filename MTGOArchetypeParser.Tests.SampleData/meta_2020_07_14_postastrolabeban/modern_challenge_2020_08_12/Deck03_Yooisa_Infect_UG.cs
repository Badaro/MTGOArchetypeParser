using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_challenge_2020_08_12
{
    public class Deck03_Yooisa_Infect_UG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Blighted Agent"),
            new SampleCard(4, "Glistener Elf"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(1, "Spellskite"),
            new SampleCard(1, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Distortion Strike"),
            new SampleCard(4, "Scale Up"),
            new SampleCard(4, "Blossoming Defense"),
            new SampleCard(2, "Groundswell"),
            new SampleCard(4, "Might of Old Krosa"),
            new SampleCard(3, "Mutagenic Growth"),
            new SampleCard(2, "Spell Pierce"),
            new SampleCard(4, "Vines of Vastwood"),
            new SampleCard(3, "Breeding Pool"),
            new SampleCard(3, "Forest"),
            new SampleCard(4, "Inkmoth Nexus"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(1, "Pendelhaven"),
            new SampleCard(2, "Verdant Catacombs"),
            new SampleCard(2, "Waterlogged Grove"),
            new SampleCard(1, "Windswept Heath"),
            new SampleCard(1, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Spellskite"),
            new SampleCard(1, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Dismember"),
            new SampleCard(2, "Force of Vigor"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Island"),
            new SampleCard(1, "Miscast"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(1, "Wilt") 
        };
    }
}