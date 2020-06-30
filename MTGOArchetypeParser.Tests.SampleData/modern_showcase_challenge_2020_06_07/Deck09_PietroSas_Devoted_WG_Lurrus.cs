using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_showcase_challenge_2020_06_07
{
    public class Deck09_PietroSas_Devoted_WG_Lurrus : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Birds of Paradise"),(4, "Devoted Druid"),(3, "Duskwatch Recruiter"),(4, "Giver of Runes"),(4, "Noble Hierarch"),(1, "Spellskite"),(4, "Vizier of Remedies"),(1, "Walking Ballista"),(2, "Eldritch Evolution"),(4, "Finale of Devastation"),(4, "Postmortem Lunge"),(1, "Chord of Calling"),(4, "Eladamri's Call"),(3, "Forest"),(4, "Horizon Canopy"),(1, "Plains"),(4, "Razorverge Thicket"),(2, "Temple Garden"),(4, "Windswept Heath"),(2, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (4, "Burrenton Forge-Tender"),(1, "Caustic Caterpillar"),(2, "Kor Firewalker"),(1, "Lurrus of the Dream Den"),(3, "Path to Exile"),(4, "Veil of Summer") }; } }
    }
}