using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_28
{
    public class Deck10_MasterA_Goblins_SnoopGoblins_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Boggart Harbinger"),
            new SampleCard(4, "Conspicuous Snoop"),
            new SampleCard(2, "Goblin Matron"),
            new SampleCard(1, "Grumgully, the Generous"),
            new SampleCard(2, "Kiki-Jiki, Mirror Breaker"),
            new SampleCard(4, "Metallic Mimic"),
            new SampleCard(4, "Munitions Expert"),
            new SampleCard(1, "Murderous Redcap"),
            new SampleCard(4, "Putrid Goblin"),
            new SampleCard(4, "Skirk Prospector"),
            new SampleCard(4, "Sling-Gang Lieutenant"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(1, "Arid Mesa"),
            new SampleCard(4, "Auntie's Hovel"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(1, "Gemstone Caverns"),
            new SampleCard(2, "Mountain"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(3, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Dismember"),
            new SampleCard(1, "Goblin Ringleader"),
            new SampleCard(1, "Goblin Trashmaster"),
            new SampleCard(1, "Lightning Bolt"),
            new SampleCard(4, "Relic of Progenitus"),
            new SampleCard(1, "Tarfire"),
            new SampleCard(4, "Thoughtseize") 
        };
    }
}