using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_showcase_challenge_2020_06_07
{
    public class Deck25_Icteridae_Devoted_HeliodDevoted_WUG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Karn, the Great Creator"),(4, "Teferi, Time Raveler"),(4, "Arbor Elf"),(4, "Devoted Druid"),(1, "Heliod, Sun-Crowned"),(1, "Ranger-Captain of Eos"),(1, "Spike Feeder"),(1, "Uro, Titan of Nature's Wrath"),(1, "Vizier of Remedies"),(1, "Walking Ballista"),(4, "Finale of Devastation"),(2, "Postmortem Lunge"),(4, "Eladamri's Call"),(4, "Oath of Nissa"),(4, "Utopia Sprawl"),(2, "Breeding Pool"),(1, "Hallowed Fountain"),(1, "Horizon Canopy"),(4, "Misty Rainforest"),(4, "Snow-Covered Forest"),(1, "Snow-Covered Plains"),(2, "Temple Garden"),(4, "Windswept Heath"),(1, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Walking Ballista"),(2, "Auriok Champion"),(1, "Burrenton Forge-Tender"),(1, "Chalice of the Void"),(1, "Ensnaring Bridge"),(1, "Knight of Autumn"),(1, "Kor Firewalker"),(1, "Liquimetal Coating"),(2, "Path to Exile"),(1, "Pithing Needle"),(1, "Tormod's Crypt"),(2, "Veil of Summer") }; } }
    }
}