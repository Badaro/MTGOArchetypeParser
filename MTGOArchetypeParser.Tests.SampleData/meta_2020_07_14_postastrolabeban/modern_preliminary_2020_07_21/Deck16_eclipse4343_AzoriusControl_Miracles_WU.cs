using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_07_21
{
    public class Deck16_eclipse4343_AzoriusControl_Miracles_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Elspeth, Sun's Nemesis"),
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(2, "Teferi, Hero of Dominaria"),
            new SampleCard(2, "Teferi, Master of Time"),
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(4, "Terminus"),
            new SampleCard(2, "Archmage's Charm"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(1, "Deprive"),
            new SampleCard(4, "Force of Negation"),
            new SampleCard(4, "Frantic Inventory"),
            new SampleCard(1, "Logic Knot"),
            new SampleCard(1, "Mana Leak"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Castle Vantress"),
            new SampleCard(2, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(2, "Misty Rainforest"),
            new SampleCard(4, "Mystic Sanctuary"),
            new SampleCard(1, "Polluted Delta"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(5, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(2, "Containment Priest"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(2, "Timely Reinforcements") 
        };
    }
}