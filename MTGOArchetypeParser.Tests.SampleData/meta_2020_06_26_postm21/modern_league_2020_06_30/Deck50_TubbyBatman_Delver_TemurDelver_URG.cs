using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_06_30
{
    public class Deck50_TubbyBatman_Delver_TemurDelver_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Delver of Secrets"),
            new SampleCard(4, "Hooting Mandrills"),
            new SampleCard(3, "Stormwing Entity"),
            new SampleCard(3, "Tarmogoyf"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(2, "Mutagenic Growth"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Stubborn Denial"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(1, "Vapor Snag"),
            new SampleCard(1, "Botanical Sanctum"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Forest"),
            new SampleCard(2, "Island"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Spirebluff Canal"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Stomping Ground") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Alpine Moon"),
            new SampleCard(2, "Engineered Explosives"),
            new SampleCard(2, "Feed the Clan"),
            new SampleCard(3, "Great Sable Stag"),
            new SampleCard(2, "Surgical Extraction"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}