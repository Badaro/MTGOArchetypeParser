using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_challenge_2020_08_10
{
    public class Deck08_SSkarm_Scapeshift_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Wrenn and Six"),
            new SampleCard(4, "Uro, Titan of Nature's Wrath"),
            new SampleCard(3, "Scapeshift"),
            new SampleCard(1, "Sweltering Suns"),
            new SampleCard(3, "Censor"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(4, "Growth Spiral"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Opt"),
            new SampleCard(3, "Remand"),
            new SampleCard(1, "Wilt"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(1, "Forest"),
            new SampleCard(3, "Island"),
            new SampleCard(4, "Ketria Triome"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(3, "Scalding Tarn"),
            new SampleCard(4, "Steam Vents"),
            new SampleCard(2, "Stomping Ground"),
            new SampleCard(2, "Valakut, the Molten Pinnacle") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Aether Gust"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(1, "Flame Slash"),
            new SampleCard(3, "Mystical Dispute"),
            new SampleCard(3, "Veil of Summer"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}