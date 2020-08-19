using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_challenge_2020_08_16
{
    public class Deck25_Storytime_Devoted_KinnanDevoted_WUG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Birds of Paradise"),
            new SampleCard(1, "Bloom Tender"),
            new SampleCard(4, "Devoted Druid"),
            new SampleCard(1, "Heliod's Pilgrim"),
            new SampleCard(3, "Kinnan, Bonder Prodigy"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(1, "Nylea, Keen-Eyed"),
            new SampleCard(3, "Sylvan Caryatid"),
            new SampleCard(1, "Vizier of Remedies"),
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(4, "Finale of Devastation"),
            new SampleCard(4, "Eladamri's Call"),
            new SampleCard(4, "Freed from the Real"),
            new SampleCard(4, "Leyline of Abundance"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(1, "Dryad Arbor"),
            new SampleCard(3, "Horizon Canopy"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(1, "Razorverge Thicket"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(2, "Temple Garden"),
            new SampleCard(1, "Waterlogged Grove"),
            new SampleCard(4, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Auriok Champion"),
            new SampleCard(2, "Burrenton Forge-Tender"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(1, "Kor Firewalker"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(1, "Tireless Tracker"),
            new SampleCard(1, "Uro, Titan of Nature's Wrath"),
            new SampleCard(4, "Veil of Summer") 
        };
    }
}