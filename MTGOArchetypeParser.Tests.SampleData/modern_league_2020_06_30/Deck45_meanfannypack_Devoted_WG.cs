using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck45_meanfannypack_Devoted_WG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Birds of Paradise"),(4, "Devoted Druid"),(3, "Duskwatch Recruiter"),(4, "Giver of Runes"),(4, "Noble Hierarch"),(3, "Selfless Savior"),(4, "Vizier of Remedies"),(1, "Walking Ballista"),(4, "Finale of Devastation"),(4, "Postmortem Lunge"),(4, "Eladamri's Call"),(4, "Mishra's Bauble"),(2, "Forest"),(3, "Horizon Canopy"),(3, "Misty Rainforest"),(2, "Plains"),(4, "Razorverge Thicket"),(2, "Temple Garden"),(4, "Windswept Heath") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Blossoming Defense"),(4, "Burrenton Forge-Tender"),(1, "Caustic Caterpillar"),(1, "Lurrus of the Dream-Den"),(3, "Path to Exile"),(4, "Veil of Summer") }; } }
    }
}