using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_10
{
    public class Deck32_MartinezDP_BantBlink_WUG_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Teferi, Time Raveler"),
            new SampleCard(2, "Barrin, Tolarian Archmage"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(3, "Jolrael, Mwonvuli Recluse"),
            new SampleCard(2, "Niambi, Esteemed Speaker"),
            new SampleCard(3, "Restoration Angel"),
            new SampleCard(2, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Venser, Shaper Savant"),
            new SampleCard(4, "Wall of Omens"),
            new SampleCard(2, "Yorion, Sky Nomad"),
            new SampleCard(4, "Force of Negation"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(4, "On Thin Ice"),
            new SampleCard(4, "Spreading Seas"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(3, "Celestial Colonnade"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(5, "Snow-Covered Island"),
            new SampleCard(2, "Snow-Covered Plains"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(4, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Yorion, Sky Nomad"),
            new SampleCard(3, "Ashiok, Dream Render"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(2, "Disdainful Stroke"),
            new SampleCard(2, "Dovin's Veto"),
            new SampleCard(2, "Supreme Verdict"),
            new SampleCard(1, "Thragtusk"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}