using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_06_30
{
    public class Deck25_thepensword_IzzetControl_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "The Royal Scions"),
            new SampleCard(3, "Rielle, the Everwise"),
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(4, "Thing in the Ice"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Magmatic Sinkhole"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Remand"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(1, "Cascade Bluffs"),
            new SampleCard(6, "Island"),
            new SampleCard(1, "Mountain"),
            new SampleCard(3, "Mystic Sanctuary"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(3, "Steam Vents"),
            new SampleCard(1, "Sulfur Falls") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Abrade"),
            new SampleCard(4, "Aether Gust"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(3, "Ashiok, Dream Render"),
            new SampleCard(3, "Blood Moon"),
            new SampleCard(2, "Narset, Parter of Veils") 
        };
    }
}