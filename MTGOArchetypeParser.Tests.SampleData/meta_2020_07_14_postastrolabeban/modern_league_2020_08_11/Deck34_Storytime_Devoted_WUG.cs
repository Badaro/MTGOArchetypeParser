using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_11
{
    public class Deck34_Storytime_Devoted_WUG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Birds of Paradise"),
            new SampleCard(4, "Devoted Druid"),
            new SampleCard(1, "Heliod's Pilgrim"),
            new SampleCard(4, "Kinnan, Bonder Prodigy"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(1, "Spectral Sailor"),
            new SampleCard(3, "Sylvan Caryatid"),
            new SampleCard(1, "Vizier of Remedies"),
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(4, "Finale of Devastation"),
            new SampleCard(1, "Postmortem Lunge"),
            new SampleCard(4, "Eladamri's Call"),
            new SampleCard(4, "Freed from the Real"),
            new SampleCard(4, "Leyline of Abundance"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(2, "Horizon Canopy"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(2, "Temple Garden"),
            new SampleCard(2, "Waterlogged Grove"),
            new SampleCard(4, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Burrenton Forge-Tender"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(2, "Knight of Autumn"),
            new SampleCard(4, "Teferi, Time Raveler"),
            new SampleCard(1, "Tireless Tracker"),
            new SampleCard(4, "Veil of Summer") 
        };
    }
}