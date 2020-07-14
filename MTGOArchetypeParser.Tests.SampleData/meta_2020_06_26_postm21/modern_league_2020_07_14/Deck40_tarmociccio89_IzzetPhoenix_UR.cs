using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_14
{
    public class Deck40_tarmociccio89_IzzetPhoenix_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Arclight Phoenix"),
            new SampleCard(1, "Crackling Drake"),
            new SampleCard(3, "Merchant of the Vale"),
            new SampleCard(4, "Thing in the Ice"),
            new SampleCard(3, "Chart a Course"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(1, "Sleight of Hand"),
            new SampleCard(2, "Izzet Charm"),
            new SampleCard(2, "Lightning Axe"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(2, "Aria of Flame"),
            new SampleCard(1, "Fiery Islet"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(4, "Island"),
            new SampleCard(1, "Mountain"),
            new SampleCard(4, "Spirebluff Canal"),
            new SampleCard(4, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Abrade"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(3, "Mystical Dispute"),
            new SampleCard(2, "Saheeli, Sublime Artificer"),
            new SampleCard(1, "Shenanigans"),
            new SampleCard(1, "Spell Pierce"),
            new SampleCard(1, "Surgical Extraction") 
        };
    }
}