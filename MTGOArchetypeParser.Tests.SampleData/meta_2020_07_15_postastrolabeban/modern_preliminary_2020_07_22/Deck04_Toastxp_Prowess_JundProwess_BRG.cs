using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_22
{
    public class Deck04_Toastxp_Prowess_JundProwess_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(4, "Cling to Dust"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(3, "Seal of Fire"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(2, "Mountain"),
            new SampleCard(1, "Nurturing Peatland"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(1, "Swamp"),
            new SampleCard(4, "Wooded Foothills"),
            new SampleCard(2, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(2, "Assassin's Trophy"),
            new SampleCard(3, "Collective Brutality"),
            new SampleCard(3, "Kiln Fiend"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(3, "Unearth") 
        };
    }
}