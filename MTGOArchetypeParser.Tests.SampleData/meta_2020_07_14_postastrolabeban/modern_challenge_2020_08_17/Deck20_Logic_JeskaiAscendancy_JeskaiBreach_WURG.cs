using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_challenge_2020_08_17
{
    public class Deck20_Logic_JeskaiAscendancy_JeskaiBreach_WURG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(4, "Birds of Paradise"),
            new SampleCard(2, "Fatestitcher"),
            new SampleCard(3, "Noble Hierarch"),
            new SampleCard(4, "Sylvan Caryatid"),
            new SampleCard(4, "Glittering Wish"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(4, "Sleight of Hand"),
            new SampleCard(4, "Cerulean Wisps"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(3, "Jeskai Ascendancy"),
            new SampleCard(4, "Underworld Breach"),
            new SampleCard(1, "Botanical Sanctum"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Fiery Islet"),
            new SampleCard(1, "Flooded Strand"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(1, "Horizon Canopy"),
            new SampleCard(1, "Island"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(1, "Scalding Tarn"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(1, "Waterlogged Grove"),
            new SampleCard(1, "Windswept Heath"),
            new SampleCard(1, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Jeskai Ascendancy"),
            new SampleCard(1, "Teferi, Time Raveler"),
            new SampleCard(1, "Consign // Oblivion"),
            new SampleCard(1, "Fiery Justice"),
            new SampleCard(1, "Flesh // Blood"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Scarscale Ritual"),
            new SampleCard(4, "Veil of Summer"),
            new SampleCard(1, "Wear // Tear") 
        };
    }
}