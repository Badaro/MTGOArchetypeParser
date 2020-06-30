using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_20
{
    public class Deck02_NightKnight131_Devoted_WG_Lurrus : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Birds of Paradise"),(4, "Devoted Druid"),(3, "Duskwatch Recruiter"),(4, "Giver of Runes"),(2, "Noble Hierarch"),(4, "Vizier of Remedies"),(1, "Walking Ballista"),(4, "Finale of Devastation"),(3, "Postmortem Lunge"),(1, "Chord of Calling"),(4, "Eladamri's Call"),(4, "Mishra's Bauble"),(2, "Oath of Nissa"),(3, "Forest"),(3, "Horizon Canopy"),(1, "Plains"),(4, "Razorverge Thicket"),(2, "Temple Garden"),(4, "Windswept Heath"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (4, "Burrenton Forge-Tender"),(1, "Caustic Caterpillar"),(1, "Lurrus of the Dream Den"),(3, "Path to Exile"),(1, "Phyrexian Revoker"),(1, "Spellskite"),(4, "Veil of Summer") }; } }
    }
}