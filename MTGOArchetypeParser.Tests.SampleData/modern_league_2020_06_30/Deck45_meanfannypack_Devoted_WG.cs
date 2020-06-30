using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck45_meanfannypack_Devoted_WG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Birds of Paradise"),
            new SampleCard(4, "Devoted Druid"),
            new SampleCard(3, "Duskwatch Recruiter"),
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(3, "Selfless Savior"),
            new SampleCard(4, "Vizier of Remedies"),
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(4, "Finale of Devastation"),
            new SampleCard(4, "Postmortem Lunge"),
            new SampleCard(4, "Eladamri's Call"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(2, "Forest"),
            new SampleCard(3, "Horizon Canopy"),
            new SampleCard(3, "Misty Rainforest"),
            new SampleCard(2, "Plains"),
            new SampleCard(4, "Razorverge Thicket"),
            new SampleCard(2, "Temple Garden"),
            new SampleCard(4, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Blossoming Defense"),
            new SampleCard(4, "Burrenton Forge-Tender"),
            new SampleCard(1, "Caustic Caterpillar"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(4, "Veil of Summer") 
        };
    }
}