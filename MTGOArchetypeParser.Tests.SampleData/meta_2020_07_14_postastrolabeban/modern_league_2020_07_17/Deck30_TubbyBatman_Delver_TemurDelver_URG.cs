using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_17
{
    public class Deck30_TubbyBatman_Delver_TemurDelver_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Delver of Secrets"),
            new SampleCard(3, "Hooting Mandrills"),
            new SampleCard(3, "Stormwing Entity"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(2, "Flame Slash"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(2, "Blossoming Defense"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(4, "Stubborn Denial"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(2, "Vapor Snag"),
            new SampleCard(1, "Botanical Sanctum"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Forest"),
            new SampleCard(2, "Island"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Spirebluff Canal"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(3, "Tarfire") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(3, "Blood Moon"),
            new SampleCard(2, "Engineered Explosives"),
            new SampleCard(3, "Feed the Clan"),
            new SampleCard(3, "Grafdigger's Cage"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}