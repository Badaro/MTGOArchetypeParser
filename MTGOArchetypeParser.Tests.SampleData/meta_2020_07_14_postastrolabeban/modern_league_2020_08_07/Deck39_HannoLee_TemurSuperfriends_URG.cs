using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07
{
    public class Deck39_HannoLee_TemurSuperfriends_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Chandra, Awakened Inferno"),
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(2, "Teferi, Master of Time"),
            new SampleCard(2, "The Royal Scions"),
            new SampleCard(4, "Birds of Paradise"),
            new SampleCard(2, "Brazen Borrower"),
            new SampleCard(1, "Courser of Kruphix"),
            new SampleCard(1, "Elder Gargaroth"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(2, "Klothys, God of Destiny"),
            new SampleCard(4, "Simian Spirit Guide"),
            new SampleCard(2, "Sylvan Caryatid"),
            new SampleCard(2, "Uro, Titan of Nature's Wrath"),
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(3, "Oath of Nissa"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(1, "Ketria Triome"),
            new SampleCard(4, "Prismatic Vista"),
            new SampleCard(5, "Snow-Covered Forest"),
            new SampleCard(4, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(1, "Waterlogged Grove"),
            new SampleCard(4, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(2, "Skred"),
            new SampleCard(1, "Tormod's Crypt"),
            new SampleCard(1, "Torpor Orb"),
            new SampleCard(1, "Trinisphere"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(1, "Wurmcoil Engine") 
        };
    }
}