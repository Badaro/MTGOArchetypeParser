using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck58_MartinezDP_Devoted_HeliodDevoted_WUG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(4, "Teferi, Time Raveler"),
            new SampleCard(4, "Arbor Elf"),
            new SampleCard(1, "Auriok Champion"),
            new SampleCard(4, "Devoted Druid"),
            new SampleCard(1, "Heliod, Sun-Crowned"),
            new SampleCard(1, "Ranger-Captain of Eos"),
            new SampleCard(1, "Spike Feeder"),
            new SampleCard(1, "Uro, Titan of Nature's Wrath"),
            new SampleCard(1, "Vizier of Remedies"),
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(4, "Finale of Devastation"),
            new SampleCard(1, "Postmortem Lunge"),
            new SampleCard(4, "Eladamri's Call"),
            new SampleCard(4, "Oath of Nissa"),
            new SampleCard(4, "Utopia Sprawl"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(2, "Horizon Canopy"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(4, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(2, "Temple Garden"),
            new SampleCard(4, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Auriok Champion"),
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(1, "Eidolon of Rhetoric"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(1, "Kor Firewalker"),
            new SampleCard(1, "Lavinia, Azorius Renegade"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(1, "Meddling Mage"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(1, "Tormod's Crypt"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}