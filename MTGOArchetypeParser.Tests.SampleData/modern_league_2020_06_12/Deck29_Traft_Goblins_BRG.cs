using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12
{
    public class Deck29_Traft_Goblins_BRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Goblin Matron"),(4, "Goblin Ringleader"),(2, "Grumgully, the Generous"),(4, "Metallic Mimic"),(1, "Mogg Fanatic"),(2, "Mogg War Marshal"),(4, "Munitions Expert"),(2, "Murderous Redcap"),(1, "Pashalik Mons"),(4, "Putrid Goblin"),(4, "Skirk Prospector"),(2, "Sling-Gang Lieutenant"),(4, "Aether Vial"),(4, "Auntie's Hovel"),(2, "Blood Crypt"),(2, "Bloodstained Mire"),(4, "Cavern of Souls"),(1, "Fiery Islet"),(2, "Mountain"),(1, "Stomping Ground"),(4, "Unclaimed Territory"),(2, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Damping Sphere"),(2, "Dismember"),(3, "Dragon's Claw"),(2, "Ensnaring Bridge"),(1, "Goblin Trashmaster"),(3, "Relic of Progenitus"),(1, "Tarfire") }; } }
    }
}