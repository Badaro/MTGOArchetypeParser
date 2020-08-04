using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_04
{
    public class Deck08_ThekingFor1000years_Infect_UG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Blighted Agent"),
            new SampleCard(4, "Glistener Elf"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(1, "Spellskite"),
            new SampleCard(2, "Distortion Strike"),
            new SampleCard(4, "Scale Up"),
            new SampleCard(1, "Apostle's Blessing"),
            new SampleCard(4, "Blossoming Defense"),
            new SampleCard(2, "Groundswell"),
            new SampleCard(4, "Might of Old Krosa"),
            new SampleCard(4, "Mutagenic Growth"),
            new SampleCard(2, "Spell Pierce"),
            new SampleCard(3, "Vines of Vastwood"),
            new SampleCard(3, "Breeding Pool"),
            new SampleCard(2, "Forest"),
            new SampleCard(4, "Inkmoth Nexus"),
            new SampleCard(1, "Pendelhaven"),
            new SampleCard(3, "Waterlogged Grove"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Spellskite"),
            new SampleCard(1, "Apostle's Blessing"),
            new SampleCard(1, "Dismember"),
            new SampleCard(2, "Force of Vigor"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(2, "Wilt") 
        };
    }
}