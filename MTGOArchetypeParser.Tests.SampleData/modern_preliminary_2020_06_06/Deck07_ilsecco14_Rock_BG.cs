using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_06
{
    public class Deck07_ilsecco14_Rock_BG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Liliana of the Veil"),(3, "Dark Confidant"),(3, "Grim Flayer"),(3, "Hexdrinker"),(4, "Kitchen Finks"),(2, "Scavenging Ooze"),(4, "Tarmogoyf"),(4, "Inquisition of Kozilek"),(2, "Thoughtseize"),(2, "Abrupt Decay"),(3, "Assassin's Trophy"),(4, "Fatal Push"),(4, "Field of Ruin"),(2, "Forest"),(2, "Marsh Flats"),(2, "Nurturing Peatland"),(4, "Overgrown Tomb"),(3, "Swamp"),(1, "Treetop Village"),(4, "Verdant Catacombs") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Choke"),(3, "Collective Brutality"),(3, "Damping Sphere"),(2, "Grafdigger's Cage"),(1, "Nature's Claim"),(2, "Nihil Spellbomb"),(2, "Thrun, the Last Troll") }; } }
    }
}