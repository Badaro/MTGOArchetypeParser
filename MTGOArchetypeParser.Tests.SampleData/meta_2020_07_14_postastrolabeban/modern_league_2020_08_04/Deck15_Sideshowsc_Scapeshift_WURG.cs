using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_04
{
    public class Deck15_Sideshowsc_Scapeshift_WURG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(4, "Sakura-Tribe Elder"),
            new SampleCard(2, "Uro, Titan of Nature's Wrath"),
            new SampleCard(4, "Bring to Light"),
            new SampleCard(1, "Mwonvuli Acid-Moss"),
            new SampleCard(2, "Scapeshift"),
            new SampleCard(4, "Search for Tomorrow"),
            new SampleCard(1, "Supreme Verdict"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(1, "Izzet Charm"),
            new SampleCard(2, "Lightning Bolt"),
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
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(1, "Crumble to Dust"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(1, "Obstinate Baloth"),
            new SampleCard(1, "Timely Reinforcements"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(1, "Weather the Storm") 
        };
    }
}