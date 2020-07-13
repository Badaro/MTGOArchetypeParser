using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_06_30
{
    public class Deck38_NightOwl61_Rock_Jund_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(3, "Liliana of the Veil"),
            new SampleCard(2, "Wrenn and Six"),
            new SampleCard(4, "Bloodbraid Elf"),
            new SampleCard(1, "Klothys, God of Destiny"),
            new SampleCard(2, "Kroxa, Titan of Death's Hunger"),
            new SampleCard(2, "Seasoned Pyromancer"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(3, "Assassin's Trophy"),
            new SampleCard(1, "Cling to Dust"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(3, "Lightning Bolt"),
            new SampleCard(1, "Terminate"),
            new SampleCard(3, "Blackcleave Cliffs"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(1, "Castle Locthwain"),
            new SampleCard(1, "Forest"),
            new SampleCard(2, "Nurturing Peatland"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(2, "Raging Ravine"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(2, "Swamp"),
            new SampleCard(3, "Verdant Catacombs") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(2, "Boil"),
            new SampleCard(1, "Choke"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(1, "Creeping Corrosion"),
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(3, "Pillage"),
            new SampleCard(2, "Plague Engineer") 
        };
    }
}