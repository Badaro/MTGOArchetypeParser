using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07
{
    public class Deck38_freneticefreet_Ponza_LiquimetalPonza_RG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Chandra, Torch of Defiance"),
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(4, "Arbor Elf"),
            new SampleCard(3, "Hexdrinker"),
            new SampleCard(1, "Klothys, God of Destiny"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(3, "Simian Spirit Guide"),
            new SampleCard(4, "Abrade"),
            new SampleCard(4, "Ancient Grudge"),
            new SampleCard(3, "Liquimetal Coating"),
            new SampleCard(4, "Blood Moon"),
            new SampleCard(4, "Utopia Sprawl"),
            new SampleCard(7, "Forest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(3, "Stomping Ground"),
            new SampleCard(2, "Verdant Catacombs"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(3, "Anger of the Gods"),
            new SampleCard(3, "Elder Gargaroth"),
            new SampleCard(2, "Ensnaring Bridge"),
            new SampleCard(1, "God-Pharaoh's Statue"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(1, "Tormod's Crypt"),
            new SampleCard(1, "Trinisphere"),
            new SampleCard(1, "Walking Ballista") 
        };
    }
}