using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_07
{
    public class Deck05_JMoney8771_Infect_UG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Blighted Agent"),
            new SampleCard(4, "Glistener Elf"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(2, "Spellskite"),
            new SampleCard(2, "Distortion Strike"),
            new SampleCard(4, "Scale Up"),
            new SampleCard(1, "Become Immense"),
            new SampleCard(4, "Blossoming Defense"),
            new SampleCard(2, "Dismember"),
            new SampleCard(3, "Groundswell"),
            new SampleCard(4, "Might of Old Krosa"),
            new SampleCard(2, "Spell Pierce"),
            new SampleCard(4, "Vines of Vastwood"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(1, "Dryad Arbor"),
            new SampleCard(2, "Forest"),
            new SampleCard(4, "Inkmoth Nexus"),
            new SampleCard(2, "Pendelhaven"),
            new SampleCard(4, "Waterlogged Grove"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(1, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Spellskite"),
            new SampleCard(1, "Dismember"),
            new SampleCard(3, "Force of Vigor"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(2, "Miscast"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(4, "Veil of Summer") 
        };
    }
}