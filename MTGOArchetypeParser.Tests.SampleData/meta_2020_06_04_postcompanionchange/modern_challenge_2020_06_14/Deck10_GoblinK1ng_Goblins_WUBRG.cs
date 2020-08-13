using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_challenge_2020_06_14
{
    public class Deck10_GoblinK1ng_Goblins_WUBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Frogtosser Banneret"),
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
            new SampleCard(1, "Ancient Ziggurat"),
            new SampleCard(4, "Auntie's Hovel"),
            new SampleCard(3, "Blood Crypt"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(2, "Fiery Islet"),
            new SampleCard(3, "Mountain"),
            new SampleCard(1, "Sunbaked Canyon"),
            new SampleCard(4, "Unclaimed Territory"),
            new SampleCard(1, "Tarfire") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Chalice of the Void"),
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(1, "Fulminator Mage"),
            new SampleCard(1, "Goblin Cratermaker"),
            new SampleCard(1, "Legion's End"),
            new SampleCard(4, "Relic of Progenitus"),
            new SampleCard(1, "Spellskite") 
        };
    }
}