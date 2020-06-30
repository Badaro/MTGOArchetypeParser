using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck42_wambocombo2020_JeskaiAscendancy_JeskaiBreach_WURG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Birds of Paradise"),
            new SampleCard(3, "Fatestitcher"),
            new SampleCard(2, "Noble Hierarch"),
            new SampleCard(4, "Sylvan Caryatid"),
            new SampleCard(4, "Glittering Wish"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(4, "Sleight of Hand"),
            new SampleCard(3, "Cerulean Wisps"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(3, "Jeskai Ascendancy"),
            new SampleCard(4, "Underworld Breach"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(3, "Gemstone Mine"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(1, "Island"),
            new SampleCard(3, "Mana Confluence"),
            new SampleCard(2, "Misty Rainforest"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Temple Garden") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Jeskai Ascendancy"),
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(1, "Flesh // Blood"),
            new SampleCard(4, "Leyline of Sanctity"),
            new SampleCard(1, "Scarscale Ritual"),
            new SampleCard(1, "Teferi, Time Raveler"),
            new SampleCard(4, "Veil of Summer"),
            new SampleCard(1, "Wear // Tear") 
        };
    }
}