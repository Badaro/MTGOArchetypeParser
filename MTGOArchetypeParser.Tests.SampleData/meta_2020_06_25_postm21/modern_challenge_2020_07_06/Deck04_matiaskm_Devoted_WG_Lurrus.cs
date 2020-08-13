using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_challenge_2020_07_06
{
    public class Deck04_matiaskm_Devoted_WG_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Birds of Paradise"),
            new SampleCard(4, "Devoted Druid"),
            new SampleCard(3, "Duskwatch Recruiter"),
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(2, "Noble Hierarch"),
            new SampleCard(4, "Vizier of Remedies"),
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(4, "Finale of Devastation"),
            new SampleCard(4, "Postmortem Lunge"),
            new SampleCard(1, "Blossoming Defense"),
            new SampleCard(1, "Chord of Calling"),
            new SampleCard(4, "Eladamri's Call"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(2, "Forest"),
            new SampleCard(3, "Horizon Canopy"),
            new SampleCard(2, "Plains"),
            new SampleCard(3, "Razorverge Thicket"),
            new SampleCard(2, "Temple Garden"),
            new SampleCard(1, "Verdant Catacombs"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(3, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Blossoming Defense"),
            new SampleCard(4, "Burrenton Forge-Tender"),
            new SampleCard(1, "Caustic Caterpillar"),
            new SampleCard(1, "Dismember"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(4, "Veil of Summer") 
        };
    }
}