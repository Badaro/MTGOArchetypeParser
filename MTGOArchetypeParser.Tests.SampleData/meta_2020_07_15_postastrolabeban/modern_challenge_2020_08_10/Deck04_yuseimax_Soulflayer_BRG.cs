using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_08_10
{
    public class Deck04_yuseimax_Soulflayer_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Bomat Courier"),
            new SampleCard(3, "Drogskol Reaver"),
            new SampleCard(1, "Ghor-Clan Rampager"),
            new SampleCard(1, "Klothys, God of Destiny"),
            new SampleCard(4, "Lotleth Troll"),
            new SampleCard(1, "Questing Beast"),
            new SampleCard(3, "Samut, Voice of Dissent"),
            new SampleCard(4, "Soulflayer"),
            new SampleCard(4, "Sylvan Caryatid"),
            new SampleCard(3, "Zetalpa, Primal Dawn"),
            new SampleCard(1, "Collective Brutality"),
            new SampleCard(4, "Gather the Pack"),
            new SampleCard(4, "Traverse the Ulvenwald"),
            new SampleCard(4, "Grisly Salvage"),
            new SampleCard(1, "Lightning Axe"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(2, "Blooming Marsh"),
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(1, "Forest"),
            new SampleCard(1, "Nurturing Peatland"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(2, "Swamp"),
            new SampleCard(4, "Verdant Catacombs") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Collective Brutality"),
            new SampleCard(1, "Lightning Axe"),
            new SampleCard(3, "Abrupt Decay"),
            new SampleCard(1, "Ancient Grudge"),
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(1, "Veil of Summer") 
        };
    }
}