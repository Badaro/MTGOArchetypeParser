using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck34_hoveydw_Delver_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Delver of Secrets"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Young Pyromancer"),
            new SampleCard(1, "Forked Bolt"),
            new SampleCard(3, "Of One Mind"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(1, "Archmage's Charm"),
            new SampleCard(4, "Force of Negation"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Remand"),
            new SampleCard(2, "Spell Snare"),
            new SampleCard(1, "Flooded Strand"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(1, "Polluted Delta"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(4, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(2, "Spirebluff Canal"),
            new SampleCard(3, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Abrade"),
            new SampleCard(3, "Blood Moon"),
            new SampleCard(3, "Ceremonious Rejection"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(1, "Magmatic Sinkhole"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(2, "Narset, Parter of Veils") 
        };
    }
}