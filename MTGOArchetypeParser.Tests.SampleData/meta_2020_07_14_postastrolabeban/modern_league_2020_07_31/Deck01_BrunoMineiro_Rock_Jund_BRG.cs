using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_31
{
    public class Deck01_BrunoMineiro_Rock_Jund_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Liliana of the Veil"),
            new SampleCard(1, "Liliana, the Last Hope"),
            new SampleCard(2, "Wrenn and Six"),
            new SampleCard(2, "Kroxa, Titan of Death's Hunger"),
            new SampleCard(3, "Seasoned Pyromancer"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(2, "Inquisition of Kozilek"),
            new SampleCard(1, "Maelstrom Pulse"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(3, "Whispers of Emrakul"),
            new SampleCard(2, "Abrupt Decay"),
            new SampleCard(1, "Fatal Push"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(1, "Lightning Bolt"),
            new SampleCard(1, "Terminate"),
            new SampleCard(3, "Mishra's Bauble"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(3, "Seal of Fire"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(3, "Bloodstained Mire"),
            new SampleCard(2, "Blooming Marsh"),
            new SampleCard(1, "Forest"),
            new SampleCard(1, "Nurturing Peatland"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(2, "Raging Ravine"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(2, "Swamp"),
            new SampleCard(3, "Verdant Catacombs"),
            new SampleCard(1, "Wooded Foothills"),
            new SampleCard(2, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(3, "Blood Moon"),
            new SampleCard(1, "Boil"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(1, "Feed the Clan"),
            new SampleCard(2, "Pillage"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}