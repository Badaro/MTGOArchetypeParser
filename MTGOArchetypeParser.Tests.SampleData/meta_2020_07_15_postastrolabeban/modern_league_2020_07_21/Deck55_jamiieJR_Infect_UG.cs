using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_21
{
    public class Deck55_jamiieJR_Infect_UG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Blighted Agent"),
            new SampleCard(4, "Glistener Elf"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(1, "Spellskite"),
            new SampleCard(2, "Distortion Strike"),
            new SampleCard(4, "Scale Up"),
            new SampleCard(4, "Blossoming Defense"),
            new SampleCard(3, "Groundswell"),
            new SampleCard(4, "Might of Old Krosa"),
            new SampleCard(4, "Mutagenic Growth"),
            new SampleCard(2, "Spell Pierce"),
            new SampleCard(4, "Vines of Vastwood"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(3, "Forest"),
            new SampleCard(4, "Inkmoth Nexus"),
            new SampleCard(2, "Pendelhaven"),
            new SampleCard(4, "Waterlogged Grove"),
            new SampleCard(1, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Spellskite"),
            new SampleCard(1, "Distortion Strike"),
            new SampleCard(1, "Spell Pierce"),
            new SampleCard(2, "Dismember"),
            new SampleCard(1, "Dissenter's Deliverance"),
            new SampleCard(2, "Force of Vigor"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(4, "Veil of Summer") 
        };
    }
}