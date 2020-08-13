using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_06_26
{
    public class Deck11_magicjpg_BantBlink_WUG_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Teferi, Time Raveler"),
            new SampleCard(1, "Deputy of Detention"),
            new SampleCard(3, "Eternal Witness"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(1, "Meddling Mage"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(2, "Soulherder"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(1, "Stonehorn Dignitary"),
            new SampleCard(2, "Uro, Titan of Nature's Wrath"),
            new SampleCard(1, "Venser, Shaper Savant"),
            new SampleCard(1, "Wood Elves"),
            new SampleCard(1, "Chord of Calling"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(4, "Eladamri's Call"),
            new SampleCard(4, "Ephemerate"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(3, "Remand"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Canopy Vista"),
            new SampleCard(3, "Flooded Strand"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(3, "Polluted Delta"),
            new SampleCard(1, "Prairie Stream"),
            new SampleCard(3, "Snow-Covered Forest"),
            new SampleCard(3, "Snow-Covered Island"),
            new SampleCard(2, "Snow-Covered Plains"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(4, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(3, "Ashiok, Dream Render"),
            new SampleCard(1, "Burrenton Forge-Tender"),
            new SampleCard(1, "Carnage Tyrant"),
            new SampleCard(1, "Collector Ouphe"),
            new SampleCard(2, "Disdainful Stroke"),
            new SampleCard(1, "Narset, Parter of Veils"),
            new SampleCard(3, "Veil of Summer"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}