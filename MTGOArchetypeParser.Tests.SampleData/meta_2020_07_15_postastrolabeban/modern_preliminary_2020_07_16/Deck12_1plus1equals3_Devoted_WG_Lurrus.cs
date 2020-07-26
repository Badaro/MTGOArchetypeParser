using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_16
{
    public class Deck12_1plus1equals3_Devoted_WG_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Birds of Paradise"),
            new SampleCard(4, "Devoted Druid"),
            new SampleCard(4, "Duskwatch Recruiter"),
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(4, "Vizier of Remedies"),
            new SampleCard(2, "Walking Ballista"),
            new SampleCard(4, "Finale of Devastation"),
            new SampleCard(4, "Postmortem Lunge"),
            new SampleCard(1, "Blossoming Defense"),
            new SampleCard(1, "Chord of Calling"),
            new SampleCard(4, "Eladamri's Call"),
            new SampleCard(2, "Forest"),
            new SampleCard(1, "Gavony Township"),
            new SampleCard(2, "Plains"),
            new SampleCard(4, "Razorverge Thicket"),
            new SampleCard(1, "Sunpetal Grove"),
            new SampleCard(2, "Temple Garden"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(4, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Blossoming Defense"),
            new SampleCard(3, "Burrenton Forge-Tender"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(3, "Veil of Summer"),
            new SampleCard(2, "Vexing Shusher") 
        };
    }
}