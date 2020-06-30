using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_08
{
    public class Deck22_indianpancake_Devoted_WG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Birds of Paradise"),
            new SampleCard(4, "Devoted Druid"),
            new SampleCard(2, "Duskwatch Recruiter"),
            new SampleCard(1, "Eternal Witness"),
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(3, "Noble Hierarch"),
            new SampleCard(2, "Ranger-Captain of Eos"),
            new SampleCard(1, "Shalai, Voice of Plenty"),
            new SampleCard(4, "Vizier of Remedies"),
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(4, "Finale of Devastation"),
            new SampleCard(4, "Postmortem Lunge"),
            new SampleCard(2, "Chord of Calling"),
            new SampleCard(4, "Eladamri's Call"),
            new SampleCard(3, "Forest"),
            new SampleCard(3, "Horizon Canopy"),
            new SampleCard(1, "Plains"),
            new SampleCard(4, "Razorverge Thicket"),
            new SampleCard(2, "Temple Garden"),
            new SampleCard(1, "Verdant Catacombs"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Burrenton Forge-Tender"),
            new SampleCard(1, "Caustic Caterpillar"),
            new SampleCard(1, "Choke"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Eidolon of Rhetoric"),
            new SampleCard(1, "Mirran Crusader"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(1, "Spellskite"),
            new SampleCard(4, "Veil of Summer") 
        };
    }
}