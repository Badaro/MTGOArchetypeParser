using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14
{
    public class Deck30_Elibaechan_Goblins_SnoopGoblins_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Boggart Harbinger"),
            new SampleCard(4, "Conspicuous Snoop"),
            new SampleCard(4, "Goblin Matron"),
            new SampleCard(3, "Goblin Ringleader"),
            new SampleCard(2, "Grumgully, the Generous"),
            new SampleCard(2, "Kiki-Jiki, Mirror Breaker"),
            new SampleCard(3, "Munitions Expert"),
            new SampleCard(1, "Murderous Redcap"),
            new SampleCard(1, "Pashalik Mons"),
            new SampleCard(4, "Putrid Goblin"),
            new SampleCard(4, "Skirk Prospector"),
            new SampleCard(2, "Sling-Gang Lieutenant"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Auntie's Hovel"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(3, "Mountain"),
            new SampleCard(2, "Stomping Ground"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Chalice of the Void"),
            new SampleCard(3, "Collective Brutality"),
            new SampleCard(1, "Goblin Trashmaster"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(2, "Tarfire"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(1, "Warren Weirding") 
        };
    }
}