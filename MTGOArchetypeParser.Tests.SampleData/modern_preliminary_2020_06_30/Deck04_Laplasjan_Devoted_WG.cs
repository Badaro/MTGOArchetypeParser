using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_30
{
    public class Deck04_Laplasjan_Devoted_WG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Birds of Paradise"),(4, "Devoted Druid"),(3, "Duskwatch Recruiter"),(4, "Giver of Runes"),(2, "Noble Hierarch"),(4, "Vizier of Remedies"),(1, "Walking Ballista"),(4, "Finale of Devastation"),(4, "Postmortem Lunge"),(1, "Blossoming Defense"),(1, "Chord of Calling"),(4, "Eladamri's Call"),(4, "Mishra's Bauble"),(2, "Forest"),(3, "Horizon Canopy"),(2, "Plains"),(3, "Razorverge Thicket"),(2, "Temple Garden"),(1, "Verdant Catacombs"),(4, "Windswept Heath"),(3, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Blossoming Defense"),(4, "Burrenton Forge-Tender"),(1, "Lurrus of the Dream-Den"),(2, "Nature's Claim"),(3, "Path to Exile"),(4, "Veil of Summer") }; } }
    }
}