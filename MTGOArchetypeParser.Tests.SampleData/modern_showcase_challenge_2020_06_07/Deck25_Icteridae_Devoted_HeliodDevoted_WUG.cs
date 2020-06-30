using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_showcase_challenge_2020_06_07
{
    public class Deck25_Icteridae_Devoted_HeliodDevoted_WUG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(4, "Teferi, Time Raveler"),
            new SampleCard(4, "Arbor Elf"),
            new SampleCard(4, "Devoted Druid"),
            new SampleCard(1, "Heliod, Sun-Crowned"),
            new SampleCard(1, "Ranger-Captain of Eos"),
            new SampleCard(1, "Spike Feeder"),
            new SampleCard(1, "Uro, Titan of Nature's Wrath"),
            new SampleCard(1, "Vizier of Remedies"),
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(4, "Finale of Devastation"),
            new SampleCard(2, "Postmortem Lunge"),
            new SampleCard(4, "Eladamri's Call"),
            new SampleCard(4, "Oath of Nissa"),
            new SampleCard(4, "Utopia Sprawl"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(1, "Horizon Canopy"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(4, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(2, "Temple Garden"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(1, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(2, "Auriok Champion"),
            new SampleCard(1, "Burrenton Forge-Tender"),
            new SampleCard(1, "Chalice of the Void"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(1, "Kor Firewalker"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(1, "Tormod's Crypt"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}