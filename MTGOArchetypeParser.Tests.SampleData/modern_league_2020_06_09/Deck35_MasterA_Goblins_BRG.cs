using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck35_MasterA_Goblins_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Goblin Cratermaker"),
            new SampleCard(4, "Goblin Matron"),
            new SampleCard(2, "Goblin Piledriver"),
            new SampleCard(3, "Goblin Ringleader"),
            new SampleCard(3, "Goblin Warchief"),
            new SampleCard(1, "Grumgully, the Generous"),
            new SampleCard(4, "Mogg War Marshal"),
            new SampleCard(3, "Munitions Expert"),
            new SampleCard(1, "Pashalik Mons"),
            new SampleCard(4, "Putrid Goblin"),
            new SampleCard(4, "Skirk Prospector"),
            new SampleCard(3, "Sling-Gang Lieutenant"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Auntie's Hovel"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(2, "Field of Ruin"),
            new SampleCard(1, "Gemstone Caverns"),
            new SampleCard(3, "Mountain"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(3, "Chalice of the Void"),
            new SampleCard(3, "Fulminator Mage"),
            new SampleCard(1, "Goblin Trashmaster"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(2, "Tarfire"),
            new SampleCard(2, "Thoughtseize") 
        };
    }
}