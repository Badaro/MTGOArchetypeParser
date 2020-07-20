using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20
{
    public class Deck16_LeoFa_Scapeshift_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Wrenn and Six"),
            new SampleCard(4, "Uro, Titan of Nature's Wrath"),
            new SampleCard(3, "Scapeshift"),
            new SampleCard(4, "Censor"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(4, "Growth Spiral"),
            new SampleCard(2, "Izzet Charm"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Opt"),
            new SampleCard(2, "Remand"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(4, "Ketria Triome"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(3, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(4, "Steam Vents"),
            new SampleCard(2, "Stomping Ground"),
            new SampleCard(2, "Valakut, the Molten Pinnacle") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Aether Gust"),
            new SampleCard(3, "Anger of the Gods"),
            new SampleCard(1, "Flame Slash"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(4, "Veil of Summer"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}