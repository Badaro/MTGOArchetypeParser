using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck02_aspiringspike_BantBlink_WUG_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(4, "Coiling Oracle"),
            new SampleCard(4, "Eternal Witness"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Uro, Titan of Nature's Wrath"),
            new SampleCard(1, "Venser, Shaper Savant"),
            new SampleCard(1, "Time Warp"),
            new SampleCard(4, "Cryptic Command"),
            new SampleCard(4, "Ephemerate"),
            new SampleCard(4, "Force of Negation"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(2, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(1, "Mystic Sanctuary"),
            new SampleCard(4, "Prismatic Vista"),
            new SampleCard(3, "Snow-Covered Forest"),
            new SampleCard(5, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(2, "Temple Garden") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Aether Gust"),
            new SampleCard(4, "Ceremonious Rejection"),
            new SampleCard(4, "On Thin Ice"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}