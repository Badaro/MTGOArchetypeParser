using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_28
{
    public class Deck40_GoblinK1ng_Goblins_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Goblin Chieftain"),
            new SampleCard(4, "Goblin Matron"),
            new SampleCard(4, "Goblin Ringleader"),
            new SampleCard(3, "Grumgully, the Generous"),
            new SampleCard(4, "Metallic Mimic"),
            new SampleCard(4, "Munitions Expert"),
            new SampleCard(3, "Murderous Redcap"),
            new SampleCard(4, "Putrid Goblin"),
            new SampleCard(4, "Skirk Prospector"),
            new SampleCard(2, "Sling-Gang Lieutenant"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Auntie's Hovel"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(2, "Bloodstained Mire"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(2, "Fiery Islet"),
            new SampleCard(1, "Mountain"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(1, "Sunbaked Canyon"),
            new SampleCard(1, "Swamp"),
            new SampleCard(4, "Unclaimed Territory") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Chalice of the Void"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(2, "Dragon's Claw"),
            new SampleCard(1, "Goblin Cratermaker"),
            new SampleCard(1, "Icon of Ancestry"),
            new SampleCard(1, "Plague Engineer"),
            new SampleCard(4, "Relic of Progenitus"),
            new SampleCard(1, "Warren Weirding") 
        };
    }
}