using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_16
{
    public class Deck09_ThekingFor1000years_Infect_WUG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(4, "Blighted Agent"),
            new SampleCard(4, "Glistener Elf"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(1, "Spellskite"),
            new SampleCard(2, "Distortion Strike"),
            new SampleCard(3, "Scale Up"),
            new SampleCard(4, "Blossoming Defense"),
            new SampleCard(2, "Groundswell"),
            new SampleCard(4, "Might of Old Krosa"),
            new SampleCard(4, "Mutagenic Growth"),
            new SampleCard(2, "Spell Pierce"),
            new SampleCard(3, "Vines of Vastwood"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(2, "Forest"),
            new SampleCard(4, "Inkmoth Nexus"),
            new SampleCard(1, "Pendelhaven"),
            new SampleCard(2, "Temple Garden"),
            new SampleCard(2, "Waterlogged Grove"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Spellskite"),
            new SampleCard(1, "Teferi, Time Raveler"),
            new SampleCard(2, "Dismember"),
            new SampleCard(2, "Force of Vigor"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(2, "Timely Reinforcements"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(1, "Wild Defiance"),
            new SampleCard(2, "Wilt") 
        };
    }
}