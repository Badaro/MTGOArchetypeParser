using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_09
{
    public class Deck09_SonsoJF_Devoted_HeliodDevoted_WBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Birds of Paradise"),
            new SampleCard(4, "Devoted Druid"),
            new SampleCard(1, "Giver of Runes"),
            new SampleCard(4, "Heliod, Sun-Crowned"),
            new SampleCard(4, "Kitchen Finks"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(3, "Ranger-Captain of Eos"),
            new SampleCard(4, "Spike Feeder"),
            new SampleCard(1, "Viscera Seer"),
            new SampleCard(3, "Vizier of Remedies"),
            new SampleCard(2, "Walking Ballista"),
            new SampleCard(2, "Finale of Devastation"),
            new SampleCard(4, "Collected Company"),
            new SampleCard(2, "Forest"),
            new SampleCard(1, "Godless Shrine"),
            new SampleCard(3, "Horizon Canopy"),
            new SampleCard(1, "Marsh Flats"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(2, "Plains"),
            new SampleCard(2, "Razorverge Thicket"),
            new SampleCard(2, "Temple Garden"),
            new SampleCard(3, "Verdant Catacombs"),
            new SampleCard(4, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Choke"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(3, "Kor Firewalker"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}