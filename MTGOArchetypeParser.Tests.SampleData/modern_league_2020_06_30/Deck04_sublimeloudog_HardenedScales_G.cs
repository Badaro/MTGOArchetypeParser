using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck04_sublimeloudog_HardenedScales_G : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Arcbound Ravager"),
            new SampleCard(4, "Arcbound Worker"),
            new SampleCard(4, "Hangarback Walker"),
            new SampleCard(3, "Metallic Mimic"),
            new SampleCard(3, "Scrapyard Recombiner"),
            new SampleCard(1, "Steel Overseer"),
            new SampleCard(4, "Walking Ballista"),
            new SampleCard(3, "Animation Module"),
            new SampleCard(3, "The Ozolith"),
            new SampleCard(2, "Throne of Geth"),
            new SampleCard(3, "Welding Jar"),
            new SampleCard(4, "Hardened Scales"),
            new SampleCard(1, "Blinkmoth Nexus"),
            new SampleCard(4, "Darksteel Citadel"),
            new SampleCard(7, "Forest"),
            new SampleCard(4, "Inkmoth Nexus"),
            new SampleCard(3, "Llanowar Reborn"),
            new SampleCard(2, "Nurturing Peatland"),
            new SampleCard(1, "Pendelhaven") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(3, "Dismember"),
            new SampleCard(3, "Grafdigger's Cage"),
            new SampleCard(3, "Nature's Claim"),
            new SampleCard(2, "Spellskite"),
            new SampleCard(1, "Veil of Summer") 
        };
    }
}