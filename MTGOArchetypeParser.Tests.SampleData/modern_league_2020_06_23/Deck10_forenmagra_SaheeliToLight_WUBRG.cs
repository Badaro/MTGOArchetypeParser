using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_23
{
    public class Deck10_forenmagra_SaheeliToLight_WUBRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Saheeli Rai"),(4, "Teferi, Time Raveler"),(4, "Birds of Paradise"),(4, "Felidar Guardian"),(1, "Kiki-Jiki, Mirror Breaker"),(2, "Niv-Mizzet Reborn"),(3, "Noble Hierarch"),(1, "Sylvan Caryatid"),(4, "Bring to Light"),(1, "Assassin's Trophy"),(3, "Eladamri's Call"),(4, "Oath of Nissa"),(4, "Utopia Sprawl"),(4, "Arid Mesa"),(1, "Blood Crypt"),(1, "Breeding Pool"),(1, "Forest"),(1, "Island"),(1, "Plains"),(1, "Sacred Foundry"),(2, "Scalding Tarn"),(1, "Steam Vents"),(1, "Stomping Ground"),(1, "Swamp"),(1, "Temple Garden"),(1, "Verdant Catacombs"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Grand Abolisher"),(4, "Leyline of Sanctity"),(1, "Obstinate Baloth"),(4, "Ravenous Trap"),(1, "Time Wipe"),(4, "Unmoored Ego") }; } }
    }
}