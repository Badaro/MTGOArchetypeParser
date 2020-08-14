using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14
{
    public class Deck04_SpoonDonkey_IzzetControl_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Narset, Parter of Veils"),
            new SampleCard(3, "Brazen Borrower"),
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(2, "Day's Undoing"),
            new SampleCard(2, "Serum Visions"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(1, "Magmatic Sinkhole"),
            new SampleCard(4, "Mana Leak"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Remand"),
            new SampleCard(3, "Blood Moon"),
            new SampleCard(1, "Cascade Bluffs"),
            new SampleCard(2, "Flooded Strand"),
            new SampleCard(8, "Island"),
            new SampleCard(2, "Mountain"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(4, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Abrade"),
            new SampleCard(3, "Aether Gust"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(2, "Flusterstorm"),
            new SampleCard(2, "Keranos, God of Storms"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(2, "Surgical Extraction") 
        };
    }
}