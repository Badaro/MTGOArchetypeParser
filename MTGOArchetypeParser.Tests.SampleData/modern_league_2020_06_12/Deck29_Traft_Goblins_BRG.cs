using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12
{
    public class Deck29_Traft_Goblins_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Goblin Matron"),
            new SampleCard(4, "Goblin Ringleader"),
            new SampleCard(2, "Grumgully, the Generous"),
            new SampleCard(4, "Metallic Mimic"),
            new SampleCard(1, "Mogg Fanatic"),
            new SampleCard(2, "Mogg War Marshal"),
            new SampleCard(4, "Munitions Expert"),
            new SampleCard(2, "Murderous Redcap"),
            new SampleCard(1, "Pashalik Mons"),
            new SampleCard(4, "Putrid Goblin"),
            new SampleCard(4, "Skirk Prospector"),
            new SampleCard(2, "Sling-Gang Lieutenant"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Auntie's Hovel"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(2, "Bloodstained Mire"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(1, "Fiery Islet"),
            new SampleCard(2, "Mountain"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(4, "Unclaimed Territory"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(2, "Dismember"),
            new SampleCard(3, "Dragon's Claw"),
            new SampleCard(2, "Ensnaring Bridge"),
            new SampleCard(1, "Goblin Trashmaster"),
            new SampleCard(3, "Relic of Progenitus"),
            new SampleCard(1, "Tarfire") 
        };
    }
}