using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_28
{
    public class Deck23_77dolltoll_LivingEnd_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Brazen Borrower"),
            new SampleCard(4, "Curator of Mysteries"),
            new SampleCard(3, "Simian Spirit Guide"),
            new SampleCard(3, "Street Wraith"),
            new SampleCard(4, "Striped Riverwinder"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(3, "Viashino Sandsprinter"),
            new SampleCard(3, "Waker of Waves"),
            new SampleCard(4, "Living End"),
            new SampleCard(4, "Force of Negation"),
            new SampleCard(4, "Violent Outburst"),
            new SampleCard(3, "As Foretold"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(1, "Forest"),
            new SampleCard(2, "Island"),
            new SampleCard(1, "Ketria Triome"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Alpine Moon"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(1, "Beast Within"),
            new SampleCard(1, "Crashing Footfalls"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(2, "Faerie Macabre"),
            new SampleCard(1, "Klothys, God of Destiny"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(2, "Pillage"),
            new SampleCard(1, "Weather the Storm") 
        };
    }
}