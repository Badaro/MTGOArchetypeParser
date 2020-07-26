using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08
{
    public class Deck28_Wartico1_Devoted_WG_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Birds of Paradise"),
            new SampleCard(4, "Devoted Druid"),
            new SampleCard(3, "Duskwatch Recruiter"),
            new SampleCard(3, "Giver of Runes"),
            new SampleCard(2, "Noble Hierarch"),
            new SampleCard(1, "Spellskite"),
            new SampleCard(4, "Vizier of Remedies"),
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(4, "Finale of Devastation"),
            new SampleCard(3, "Postmortem Lunge"),
            new SampleCard(4, "Eladamri's Call"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(3, "Forest"),
            new SampleCard(1, "Gavony Township"),
            new SampleCard(2, "Horizon Canopy"),
            new SampleCard(1, "Plains"),
            new SampleCard(4, "Razorverge Thicket"),
            new SampleCard(2, "Temple Garden"),
            new SampleCard(1, "Verdant Catacombs"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Path to Exile"),
            new SampleCard(2, "Burrenton Forge-Tender"),
            new SampleCard(1, "Caustic Caterpillar"),
            new SampleCard(2, "Kor Firewalker"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(2, "Seal of Primordium"),
            new SampleCard(4, "Veil of Summer"),
            new SampleCard(2, "Voice of Resurgence") 
        };
    }
}