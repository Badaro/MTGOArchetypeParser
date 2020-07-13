using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_preliminary_2020_06_25
{
    public class Deck14_Papelucho10_Infect_UG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Blighted Agent"),
            new SampleCard(4, "Glistener Elf"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(1, "Spellskite"),
            new SampleCard(3, "Distortion Strike"),
            new SampleCard(4, "Scale Up"),
            new SampleCard(4, "Blossoming Defense"),
            new SampleCard(3, "Groundswell"),
            new SampleCard(4, "Might of Old Krosa"),
            new SampleCard(4, "Mutagenic Growth"),
            new SampleCard(2, "Spell Pierce"),
            new SampleCard(4, "Vines of Vastwood"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(3, "Inkmoth Nexus"),
            new SampleCard(1, "Pendelhaven"),
            new SampleCard(3, "Snow-Covered Forest"),
            new SampleCard(1, "Verdant Catacombs"),
            new SampleCard(3, "Waterlogged Grove"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Spellskite"),
            new SampleCard(1, "Dismember"),
            new SampleCard(2, "Force of Vigor"),
            new SampleCard(3, "Mystical Dispute"),
            new SampleCard(1, "Nature's Claim"),
            new SampleCard(1, "Piracy Charm"),
            new SampleCard(1, "Return to Nature"),
            new SampleCard(1, "Slip Through Space"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}