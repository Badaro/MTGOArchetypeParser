using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_04
{
    public class Deck71_monkeyang_IzzetPhoenix_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Arclight Phoenix"),
            new SampleCard(3, "Bedlam Reveler"),
            new SampleCard(2, "Merchant of the Vale"),
            new SampleCard(2, "Ox of Agonas"),
            new SampleCard(4, "Stormwing Entity"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(1, "Shenanigans"),
            new SampleCard(4, "Dream Twist"),
            new SampleCard(2, "Izzet Charm"),
            new SampleCard(2, "Lava Dart"),
            new SampleCard(3, "Lightning Axe"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(3, "Island"),
            new SampleCard(2, "Mountain"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Shivan Reef"),
            new SampleCard(4, "Spirebluff Canal"),
            new SampleCard(2, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Shenanigans"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(4, "Crackling Drake"),
            new SampleCard(3, "Dragon's Claw"),
            new SampleCard(1, "Firespout"),
            new SampleCard(1, "Startling Development"),
            new SampleCard(3, "Surgical Extraction") 
        };
    }
}