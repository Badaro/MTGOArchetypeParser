using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05
{
    public class Deck12_Papelucho10_Infect_UG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Blighted Agent"),
            new SampleCard(4, "Glistener Elf"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(1, "Spellskite"),
            new SampleCard(3, "Distortion Strike"),
            new SampleCard(4, "Scale Up"),
            new SampleCard(1, "Sylvan Scrying"),
            new SampleCard(1, "Become Immense"),
            new SampleCard(4, "Blossoming Defense"),
            new SampleCard(4, "Groundswell"),
            new SampleCard(4, "Might of Old Krosa"),
            new SampleCard(2, "Spell Pierce"),
            new SampleCard(4, "Vines of Vastwood"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(1, "Dryad Arbor"),
            new SampleCard(4, "Inkmoth Nexus"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(2, "Pendelhaven"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(2, "Waterlogged Grove"),
            new SampleCard(3, "Windswept Heath"),
            new SampleCard(3, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Sylvan Scrying"),
            new SampleCard(2, "Dismember"),
            new SampleCard(2, "Force of Vigor"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(2, "Pithing Needle"),
            new SampleCard(1, "Postmortem Lunge"),
            new SampleCard(3, "Veil of Summer"),
            new SampleCard(2, "Viridian Corrupter") 
        };
    }
}