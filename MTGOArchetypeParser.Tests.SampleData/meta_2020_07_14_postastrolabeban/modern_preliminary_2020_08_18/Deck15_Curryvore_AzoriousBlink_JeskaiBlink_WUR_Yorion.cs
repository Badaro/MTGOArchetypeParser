using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_18
{
    public class Deck15_Curryvore_AzoriousBlink_JeskaiBlink_WUR_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Teferi, Time Raveler"),
            new SampleCard(3, "Brazen Borrower"),
            new SampleCard(4, "Restoration Angel"),
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(4, "Vendilion Clique"),
            new SampleCard(2, "Venser, Shaper Savant"),
            new SampleCard(4, "Wall of Omens"),
            new SampleCard(2, "Yorion, Sky Nomad"),
            new SampleCard(4, "Force of Negation"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(3, "Lightning Helix"),
            new SampleCard(4, "Opt"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(4, "Spreading Seas"),
            new SampleCard(2, "Celestial Colonnade"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(4, "Island"),
            new SampleCard(1, "Mountain"),
            new SampleCard(1, "Mystic Sanctuary"),
            new SampleCard(3, "Plains"),
            new SampleCard(2, "Polluted Delta"),
            new SampleCard(4, "Raugrin Triome"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(1, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Yorion, Sky Nomad"),
            new SampleCard(3, "Aether Gust"),
            new SampleCard(4, "Ashiok, Dream Render"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(4, "Dovin's Veto"),
            new SampleCard(1, "Izzet Staticaster") 
        };
    }
}