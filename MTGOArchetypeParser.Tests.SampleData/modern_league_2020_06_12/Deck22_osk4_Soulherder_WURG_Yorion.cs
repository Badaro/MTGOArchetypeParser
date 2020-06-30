using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12
{
    public class Deck22_osk4_Soulherder_WURG_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Avalanche Riders"),
            new SampleCard(4, "Birds of Paradise"),
            new SampleCard(1, "Charming Prince"),
            new SampleCard(1, "Deputy of Detention"),
            new SampleCard(3, "Eternal Witness"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(1, "Lavinia of the Tenth"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(1, "Restoration Angel"),
            new SampleCard(1, "Scavenging Ooze"),
            new SampleCard(3, "Soulherder"),
            new SampleCard(1, "Stonehorn Dignitary"),
            new SampleCard(1, "Venser, Shaper Savant"),
            new SampleCard(2, "Wall of Blossoms"),
            new SampleCard(2, "Wall of Roots"),
            new SampleCard(4, "Chord of Calling"),
            new SampleCard(4, "Ephemerate"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Lightning Helix"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(1, "Prairie Stream"),
            new SampleCard(3, "Prismatic Vista"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(4, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(3, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Knight of Autumn"),
            new SampleCard(1, "Aven Mindcensor"),
            new SampleCard(1, "Collector Ouphe"),
            new SampleCard(1, "Eidolon of Rhetoric"),
            new SampleCard(1, "Magus of the Moon"),
            new SampleCard(3, "Mystical Dispute"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Thragtusk"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}