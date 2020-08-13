using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_07_16
{
    public class Deck27_Sungjin_SnowControl_SnowShift_WURG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(2, "Ice-Fang Coatl"),
            new SampleCard(4, "Sakura-Tribe Elder"),
            new SampleCard(4, "Bring to Light"),
            new SampleCard(1, "Mwonvuli Acid-Moss"),
            new SampleCard(2, "Scapeshift"),
            new SampleCard(4, "Search for Tomorrow"),
            new SampleCard(1, "Supreme Verdict"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(3, "Growth Spiral"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(4, "Remand"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Flooded Strand"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(1, "Ketria Triome"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(1, "Mystic Sanctuary"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(3, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(4, "Steam Vents"),
            new SampleCard(4, "Stomping Ground"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(2, "Valakut, the Molten Pinnacle") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Anger of the Gods"),
            new SampleCard(1, "Crumble to Dust"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(1, "Force of Vigor"),
            new SampleCard(1, "Fry"),
            new SampleCard(1, "Huntmaster of the Fells"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(1, "Obstinate Baloth"),
            new SampleCard(2, "Timely Reinforcements"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}