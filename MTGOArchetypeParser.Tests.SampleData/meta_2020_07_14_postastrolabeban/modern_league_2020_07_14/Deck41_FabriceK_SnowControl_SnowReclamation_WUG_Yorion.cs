using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_14
{
    public class Deck41_FabriceK_SnowControl_SnowReclamation_WUG_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(1, "Oust"),
            new SampleCard(1, "Supreme Verdict"),
            new SampleCard(4, "Archmage's Charm"),
            new SampleCard(4, "Cryptic Command"),
            new SampleCard(4, "Fact or Fiction"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(4, "Growth Spiral"),
            new SampleCard(2, "Nexus of Fate"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Remand"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(1, "Detention Sphere"),
            new SampleCard(1, "Search for Azcanta"),
            new SampleCard(4, "Wilderness Reclamation"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(3, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(3, "Misty Rainforest"),
            new SampleCard(4, "Mystic Sanctuary"),
            new SampleCard(2, "Polluted Delta"),
            new SampleCard(3, "Scalding Tarn"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(6, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(1, "Temple Garden") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Supreme Verdict"),
            new SampleCard(3, "Aether Gust"),
            new SampleCard(1, "Ceremonious Rejection"),
            new SampleCard(1, "Dovin's Veto"),
            new SampleCard(2, "Flusterstorm"),
            new SampleCard(2, "Monastery Mentor"),
            new SampleCard(2, "Settle the Wreckage"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}