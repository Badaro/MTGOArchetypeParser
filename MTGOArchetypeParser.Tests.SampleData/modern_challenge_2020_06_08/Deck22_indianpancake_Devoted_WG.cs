using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_08
{
    public class Deck22_indianpancake_Devoted_WG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Birds of Paradise"),(4, "Devoted Druid"),(2, "Duskwatch Recruiter"),(1, "Eternal Witness"),(4, "Giver of Runes"),(3, "Noble Hierarch"),(2, "Ranger-Captain of Eos"),(1, "Shalai, Voice of Plenty"),(4, "Vizier of Remedies"),(1, "Walking Ballista"),(4, "Finale of Devastation"),(4, "Postmortem Lunge"),(2, "Chord of Calling"),(4, "Eladamri's Call"),(3, "Forest"),(3, "Horizon Canopy"),(1, "Plains"),(4, "Razorverge Thicket"),(2, "Temple Garden"),(1, "Verdant Catacombs"),(4, "Windswept Heath"),(2, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Burrenton Forge-Tender"),(1, "Caustic Caterpillar"),(1, "Choke"),(2, "Damping Sphere"),(1, "Eidolon of Rhetoric"),(1, "Mirran Crusader"),(2, "Path to Exile"),(1, "Spellskite"),(4, "Veil of Summer") }; } }
    }
}