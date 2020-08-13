using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_23
{
    public class Deck29_Darthtaneon_BushwhackerZoo_RG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Domri, Anarch of Bolas"),
            new SampleCard(4, "Burning-Tree Emissary"),
            new SampleCard(2, "Gallia of the Endless Dance"),
            new SampleCard(4, "Goblin Bushwhacker"),
            new SampleCard(4, "Goblin Guide"),
            new SampleCard(3, "Hidden Herbalists"),
            new SampleCard(2, "Legion Loyalist"),
            new SampleCard(3, "Narnam Renegade"),
            new SampleCard(4, "Robber of the Rich"),
            new SampleCard(2, "Slaughterhorn"),
            new SampleCard(2, "Zhur-Taa Goblin"),
            new SampleCard(4, "Atarka's Command"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(4, "Copperline Gorge"),
            new SampleCard(1, "Mountain"),
            new SampleCard(1, "Nurturing Peatland"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(4, "Stomping Ground"),
            new SampleCard(1, "Waterlogged Grove"),
            new SampleCard(3, "Windswept Heath"),
            new SampleCard(1, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Abrade"),
            new SampleCard(2, "Collector Ouphe"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(2, "Dragon's Claw"),
            new SampleCard(2, "Life Goes On"),
            new SampleCard(2, "Magus of the Moon"),
            new SampleCard(1, "Mistcutter Hydra"),
            new SampleCard(1, "Soul-Guide Lantern"),
            new SampleCard(2, "Tormod's Crypt") 
        };
    }
}