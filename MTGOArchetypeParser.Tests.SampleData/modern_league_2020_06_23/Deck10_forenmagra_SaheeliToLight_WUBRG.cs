using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_23
{
    public class Deck10_forenmagra_SaheeliToLight_WUBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Saheeli Rai"),
            new SampleCard(4, "Teferi, Time Raveler"),
            new SampleCard(4, "Birds of Paradise"),
            new SampleCard(4, "Felidar Guardian"),
            new SampleCard(1, "Kiki-Jiki, Mirror Breaker"),
            new SampleCard(2, "Niv-Mizzet Reborn"),
            new SampleCard(3, "Noble Hierarch"),
            new SampleCard(1, "Sylvan Caryatid"),
            new SampleCard(4, "Bring to Light"),
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(3, "Eladamri's Call"),
            new SampleCard(4, "Oath of Nissa"),
            new SampleCard(4, "Utopia Sprawl"),
            new SampleCard(4, "Arid Mesa"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Forest"),
            new SampleCard(1, "Island"),
            new SampleCard(1, "Plains"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(1, "Swamp"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(1, "Verdant Catacombs"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Grand Abolisher"),
            new SampleCard(4, "Leyline of Sanctity"),
            new SampleCard(1, "Obstinate Baloth"),
            new SampleCard(4, "Ravenous Trap"),
            new SampleCard(1, "Time Wipe"),
            new SampleCard(4, "Unmoored Ego") 
        };
    }
}