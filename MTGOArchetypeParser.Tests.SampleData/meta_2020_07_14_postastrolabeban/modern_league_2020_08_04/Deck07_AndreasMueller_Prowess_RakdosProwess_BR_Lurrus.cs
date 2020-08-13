using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_04
{
    public class Deck07_AndreasMueller_Prowess_RakdosProwess_BR_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Abbot of Keral Keep"),
            new SampleCard(1, "Kiln Fiend"),
            new SampleCard(1, "Kroxa, Titan of Death's Hunger"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(1, "Unearth"),
            new SampleCard(3, "Cling to Dust"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(1, "Kolaghan's Command"),
            new SampleCard(2, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Manamorphose"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(3, "Seal of Fire"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(1, "Fiery Islet"),
            new SampleCard(3, "Mountain"),
            new SampleCard(2, "Sunbaked Canyon"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Kiln Fiend"),
            new SampleCard(1, "Cling to Dust"),
            new SampleCard(1, "Kolaghan's Command"),
            new SampleCard(1, "Unearth"),
            new SampleCard(1, "Abrade"),
            new SampleCard(1, "Angrath's Rampage"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(1, "Duress"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(1, "Molten Rain"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(1, "Pillage"),
            new SampleCard(1, "Terminate") 
        };
    }
}