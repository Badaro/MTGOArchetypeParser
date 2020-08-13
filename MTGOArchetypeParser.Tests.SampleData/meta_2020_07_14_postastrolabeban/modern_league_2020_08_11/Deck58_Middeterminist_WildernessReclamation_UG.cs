using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_11
{
    public class Deck58_Middeterminist_WildernessReclamation_UG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(2, "Fact or Fiction"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Frantic Inventory"),
            new SampleCard(4, "Growth Spiral"),
            new SampleCard(1, "Nexus of Fate"),
            new SampleCard(4, "Opt"),
            new SampleCard(2, "Remand"),
            new SampleCard(3, "Shark Typhoon"),
            new SampleCard(4, "Wilderness Reclamation"),
            new SampleCard(3, "Breeding Pool"),
            new SampleCard(2, "Flooded Strand"),
            new SampleCard(1, "Lumbering Falls"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(4, "Mystic Sanctuary"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(5, "Snow-Covered Island") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(1, "Ceremonious Rejection"),
            new SampleCard(2, "Elder Gargaroth"),
            new SampleCard(2, "Surgical Extraction"),
            new SampleCard(3, "Veil of Summer"),
            new SampleCard(2, "Weather the Storm"),
            new SampleCard(2, "Wilt") 
        };
    }
}