using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14
{
    public class Deck10_GoblinK1ng_Goblins_WUBRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Frogtosser Banneret"),(4, "Goblin Matron"),(4, "Goblin Ringleader"),(3, "Grumgully, the Generous"),(4, "Metallic Mimic"),(4, "Munitions Expert"),(3, "Murderous Redcap"),(4, "Putrid Goblin"),(4, "Skirk Prospector"),(2, "Sling-Gang Lieutenant"),(4, "Aether Vial"),(1, "Ancient Ziggurat"),(4, "Auntie's Hovel"),(3, "Blood Crypt"),(4, "Cavern of Souls"),(2, "Fiery Islet"),(3, "Mountain"),(1, "Sunbaked Canyon"),(4, "Unclaimed Territory"),(1, "Tarfire") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (4, "Chalice of the Void"),(3, "Damping Sphere"),(1, "Fulminator Mage"),(1, "Goblin Cratermaker"),(1, "Legion's End"),(4, "Relic of Progenitus"),(1, "Spellskite") }; } }
    }
}