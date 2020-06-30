using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck42_wambocombo2020_JeskaiAscendancy_JeskaiBreach_WURG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Birds of Paradise"),(3, "Fatestitcher"),(2, "Noble Hierarch"),(4, "Sylvan Caryatid"),(4, "Glittering Wish"),(4, "Serum Visions"),(4, "Sleight of Hand"),(3, "Cerulean Wisps"),(4, "Manamorphose"),(4, "Thought Scour"),(3, "Jeskai Ascendancy"),(4, "Underworld Breach"),(1, "Breeding Pool"),(4, "Flooded Strand"),(3, "Gemstone Mine"),(1, "Hallowed Fountain"),(1, "Island"),(3, "Mana Confluence"),(2, "Misty Rainforest"),(1, "Steam Vents"),(1, "Temple Garden") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Jeskai Ascendancy"),(1, "Abrupt Decay"),(1, "Assassin's Trophy"),(1, "Flesh // Blood"),(4, "Leyline of Sanctity"),(1, "Scarscale Ritual"),(1, "Teferi, Time Raveler"),(4, "Veil of Summer"),(1, "Wear // Tear") }; } }
    }
}