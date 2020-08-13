using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_08
{
    public class Deck17_IntegralHDK_Goblins_SnoopGoblins_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Boggart Harbinger"),
            new SampleCard(4, "Conspicuous Snoop"),
            new SampleCard(4, "Goblin Matron"),
            new SampleCard(2, "Grumgully, the Generous"),
            new SampleCard(1, "Kiki-Jiki, Mirror Breaker"),
            new SampleCard(3, "Munitions Expert"),
            new SampleCard(1, "Murderous Redcap"),
            new SampleCard(3, "Putrid Goblin"),
            new SampleCard(2, "Skirk Prospector"),
            new SampleCard(2, "Sling-Gang Lieutenant"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(4, "Collected Company"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(3, "Auntie's Hovel"),
            new SampleCard(3, "Blackcleave Cliffs"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(1, "Fiery Islet"),
            new SampleCard(1, "Forest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Blood Moon"),
            new SampleCard(2, "Boil"),
            new SampleCard(2, "Goblin Cratermaker"),
            new SampleCard(3, "Leyline of the Void"),
            new SampleCard(2, "Nature's Claim"),
            new SampleCard(1, "Tarfire"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}