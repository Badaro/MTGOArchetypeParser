using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_20
{
    public class Deck05_Papelucho10_Infect_UG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Blighted Agent"),
            new SampleCard(4, "Glistener Elf"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(1, "Spellskite"),
            new SampleCard(2, "Distortion Strike"),
            new SampleCard(4, "Scale Up"),
            new SampleCard(1, "Become Immense"),
            new SampleCard(4, "Blossoming Defense"),
            new SampleCard(4, "Groundswell"),
            new SampleCard(4, "Might of Old Krosa"),
            new SampleCard(3, "Mutagenic Growth"),
            new SampleCard(2, "Spell Pierce"),
            new SampleCard(4, "Vines of Vastwood"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(4, "Inkmoth Nexus"),
            new SampleCard(1, "Pendelhaven"),
            new SampleCard(3, "Snow-Covered Forest"),
            new SampleCard(3, "Waterlogged Grove"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(3, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Spellskite"),
            new SampleCard(1, "Ceremonious Rejection"),
            new SampleCard(1, "Contentious Plan"),
            new SampleCard(2, "Force of Vigor"),
            new SampleCard(3, "Mystical Dispute"),
            new SampleCard(1, "Nature's Claim"),
            new SampleCard(1, "Return to Nature"),
            new SampleCard(1, "Sylvan Scrying"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}