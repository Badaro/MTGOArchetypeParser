using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_challenge_2020_07_19
{
    public class Deck26_MasterA_Goblins_SnoopGoblins_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Boggart Harbinger"),
            new SampleCard(4, "Conspicuous Snoop"),
            new SampleCard(4, "Goblin Matron"),
            new SampleCard(1, "Grumgully, the Generous"),
            new SampleCard(1, "Kiki-Jiki, Mirror Breaker"),
            new SampleCard(4, "Metallic Mimic"),
            new SampleCard(2, "Munitions Expert"),
            new SampleCard(1, "Murderous Redcap"),
            new SampleCard(4, "Putrid Goblin"),
            new SampleCard(2, "Skirk Prospector"),
            new SampleCard(4, "Sling-Gang Lieutenant"),
            new SampleCard(2, "Inquisition of Kozilek"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(1, "Unearth"),
            new SampleCard(3, "Aether Vial"),
            new SampleCard(4, "Auntie's Hovel"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(2, "Mountain"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(1, "Swamp"),
            new SampleCard(1, "Verdant Catacombs") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(2, "Boil"),
            new SampleCard(1, "Goblin Ringleader"),
            new SampleCard(1, "Goblin Trashmaster"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(3, "Relic of Progenitus"),
            new SampleCard(2, "Tarfire") 
        };
    }
}