using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_07_03
{
    public class Deck05_triosk_HardenedScales_G : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Arcbound Ravager"),
            new SampleCard(4, "Arcbound Worker"),
            new SampleCard(4, "Hangarback Walker"),
            new SampleCard(2, "Scrapyard Recombiner"),
            new SampleCard(4, "Walking Ballista"),
            new SampleCard(4, "Ancient Stirrings"),
            new SampleCard(2, "Animation Module"),
            new SampleCard(2, "Springleaf Drum"),
            new SampleCard(4, "The Ozolith"),
            new SampleCard(2, "Throne of Geth"),
            new SampleCard(2, "Welding Jar"),
            new SampleCard(4, "Hardened Scales"),
            new SampleCard(2, "Blinkmoth Nexus"),
            new SampleCard(2, "Cavern of Souls"),
            new SampleCard(4, "Inkmoth Nexus"),
            new SampleCard(4, "Llanowar Reborn"),
            new SampleCard(2, "Pendelhaven"),
            new SampleCard(2, "Phyrexia's Core"),
            new SampleCard(6, "Snow-Covered Forest") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Animation Module"),
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(2, "Dismember"),
            new SampleCard(4, "Gemrazer"),
            new SampleCard(4, "Relic of Progenitus") 
        };
    }
}