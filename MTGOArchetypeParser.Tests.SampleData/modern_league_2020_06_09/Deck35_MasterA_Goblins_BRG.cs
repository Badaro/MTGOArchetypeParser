using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck35_MasterA_Goblins_BRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Goblin Cratermaker"),(4, "Goblin Matron"),(2, "Goblin Piledriver"),(3, "Goblin Ringleader"),(3, "Goblin Warchief"),(1, "Grumgully, the Generous"),(4, "Mogg War Marshal"),(3, "Munitions Expert"),(1, "Pashalik Mons"),(4, "Putrid Goblin"),(4, "Skirk Prospector"),(3, "Sling-Gang Lieutenant"),(4, "Aether Vial"),(4, "Auntie's Hovel"),(1, "Blood Crypt"),(4, "Bloodstained Mire"),(4, "Cavern of Souls"),(2, "Field of Ruin"),(1, "Gemstone Caverns"),(3, "Mountain"),(1, "Stomping Ground"),(1, "Swamp"),(2, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Ashiok, Dream Render"),(3, "Chalice of the Void"),(3, "Fulminator Mage"),(1, "Goblin Trashmaster"),(2, "Relic of Progenitus"),(2, "Tarfire"),(2, "Thoughtseize") }; } }
    }
}