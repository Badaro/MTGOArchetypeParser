using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_23
{
    public class Deck29_Darthtaneon_EightWhack_AtarkaWhack_RG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Domri, Anarch of Bolas"),(4, "Burning-Tree Emissary"),(2, "Gallia of the Endless Dance"),(4, "Goblin Bushwhacker"),(4, "Goblin Guide"),(3, "Hidden Herbalists"),(2, "Legion Loyalist"),(3, "Narnam Renegade"),(4, "Robber of the Rich"),(2, "Slaughterhorn"),(2, "Zhur-Taa Goblin"),(4, "Atarka's Command"),(4, "Lightning Bolt"),(4, "Bloodstained Mire"),(4, "Copperline Gorge"),(1, "Mountain"),(1, "Nurturing Peatland"),(1, "Snow-Covered Forest"),(4, "Stomping Ground"),(1, "Waterlogged Grove"),(3, "Windswept Heath"),(1, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Abrade"),(2, "Collector Ouphe"),(1, "Damping Sphere"),(2, "Dragon's Claw"),(2, "Life Goes On"),(2, "Magus of the Moon"),(1, "Mistcutter Hydra"),(1, "Soul-Guide Lantern"),(2, "Tormod's Crypt") }; } }
    }
}