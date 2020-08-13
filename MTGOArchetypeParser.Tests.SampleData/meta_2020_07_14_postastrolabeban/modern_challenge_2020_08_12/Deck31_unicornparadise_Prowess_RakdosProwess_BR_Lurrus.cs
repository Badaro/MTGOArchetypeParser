using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_challenge_2020_08_12
{
    public class Deck31_unicornparadise_Prowess_RakdosProwess_BR_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Abbot of Keral Keep"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(4, "Cling to Dust"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(3, "Seal of Fire"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(3, "Mountain"),
            new SampleCard(3, "Sunbaked Canyon"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Collective Brutality"),
            new SampleCard(2, "Infernal Reckoning"),
            new SampleCard(2, "Kiln Fiend"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(3, "Nihil Spellbomb"),
            new SampleCard(4, "Pillage") 
        };
    }
}