using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_08
{
    public class Deck28_Wartico1_Devoted_WG_Lurrus : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Birds of Paradise"),(4, "Devoted Druid"),(3, "Duskwatch Recruiter"),(3, "Giver of Runes"),(2, "Noble Hierarch"),(1, "Spellskite"),(4, "Vizier of Remedies"),(1, "Walking Ballista"),(4, "Finale of Devastation"),(3, "Postmortem Lunge"),(4, "Eladamri's Call"),(3, "Path to Exile"),(4, "Mishra's Bauble"),(3, "Forest"),(1, "Gavony Township"),(2, "Horizon Canopy"),(1, "Plains"),(4, "Razorverge Thicket"),(2, "Temple Garden"),(1, "Verdant Catacombs"),(4, "Windswept Heath"),(2, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Path to Exile"),(2, "Burrenton Forge-Tender"),(1, "Caustic Caterpillar"),(2, "Kor Firewalker"),(1, "Lurrus of the Dream Den"),(2, "Seal of Primordium"),(4, "Veil of Summer"),(2, "Voice of Resurgence") }; } }
    }
}