using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_07_22
{
    public class Deck13_Delthar_Infect_UG : ISampleDeck
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
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(1, "Pendelhaven"),
            new SampleCard(1, "Verdant Catacombs"),
            new SampleCard(2, "Waterlogged Grove"),
            new SampleCard(3, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Force of Vigor"),
            new SampleCard(3, "Kitchen Finks"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(2, "Shapers' Sanctuary"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}