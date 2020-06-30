using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck27_FuryGarruk_EmeriaTitan_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Deputy of Detention"),
            new SampleCard(3, "Flickerwisp"),
            new SampleCard(1, "Golos, Tireless Pilgrim"),
            new SampleCard(2, "Lone Missionary"),
            new SampleCard(1, "Reflector Mage"),
            new SampleCard(1, "Skittering Surveyor"),
            new SampleCard(4, "Soulherder"),
            new SampleCard(3, "Sun Titan"),
            new SampleCard(2, "Venser, Shaper Savant"),
            new SampleCard(4, "Wall of Omens"),
            new SampleCard(3, "Watcher for Tomorrow"),
            new SampleCard(2, "Winds of Abandon"),
            new SampleCard(1, "Dovin's Veto"),
            new SampleCard(4, "Ephemerate"),
            new SampleCard(1, "Ojutai's Command"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(3, "Emeria, the Sky Ruin"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(4, "Hallowed Fountain"),
            new SampleCard(1, "Island"),
            new SampleCard(5, "Plains"),
            new SampleCard(3, "Prairie Stream") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Lone Missionary"),
            new SampleCard(2, "Dovin's Veto"),
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(1, "Negate"),
            new SampleCard(2, "Stony Silence"),
            new SampleCard(3, "Tormod's Crypt") 
        };
    }
}