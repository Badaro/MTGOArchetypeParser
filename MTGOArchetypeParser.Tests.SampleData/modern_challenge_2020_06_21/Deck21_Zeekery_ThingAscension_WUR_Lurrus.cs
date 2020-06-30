using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21
{
    public class Deck21_Zeekery_ThingAscension_WUR_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Thing in the Ice"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(4, "Sleight of Hand"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Lightning Helix"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(4, "Opt"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(2, "Remand"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(4, "Pyromancer Ascension"),
            new SampleCard(1, "Fiery Islet"),
            new SampleCard(3, "Flooded Strand"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(1, "Raugrin Triome"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(2, "Spirebluff Canal"),
            new SampleCard(2, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(1, "Blessed Alliance"),
            new SampleCard(1, "Lurrus of the Dream Den"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(2, "Pillage"),
            new SampleCard(2, "Sprite Dragon"),
            new SampleCard(2, "Surgical Extraction"),
            new SampleCard(1, "Wear // Tear") 
        };
    }
}