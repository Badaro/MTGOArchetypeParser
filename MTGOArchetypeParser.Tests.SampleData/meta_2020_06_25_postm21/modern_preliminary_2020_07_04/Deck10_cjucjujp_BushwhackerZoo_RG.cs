using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_preliminary_2020_07_04
{
    public class Deck10_cjucjujp_BushwhackerZoo_RG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Burning-Tree Emissary"),
            new SampleCard(3, "Gallia of the Endless Dance"),
            new SampleCard(4, "Goblin Bushwhacker"),
            new SampleCard(4, "Goblin Guide"),
            new SampleCard(4, "Legion Loyalist"),
            new SampleCard(4, "Memnite"),
            new SampleCard(4, "Reckless Bushwhacker"),
            new SampleCard(4, "Signal Pest"),
            new SampleCard(2, "Scale Up"),
            new SampleCard(4, "Atarka's Command"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(3, "Bloodstained Mire"),
            new SampleCard(3, "Castle Embereth"),
            new SampleCard(5, "Mountain"),
            new SampleCard(4, "Stomping Ground"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Dismember"),
            new SampleCard(3, "Leyline of Combustion"),
            new SampleCard(3, "Pyrite Spellbomb"),
            new SampleCard(3, "Smash to Smithereens"),
            new SampleCard(4, "Tormod's Crypt") 
        };
    }
}