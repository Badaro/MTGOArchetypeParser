using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_18
{
    public class Deck03_Toastxp_Prowess_RakdosProwess_WBR_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Abbot of Keral Keep"),
            new SampleCard(2, "Dreadhorde Arcanist"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(2, "Inquisition of Kozilek"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(2, "Unearth"),
            new SampleCard(3, "Cling to Dust"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(2, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(3, "Seal of Fire"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(3, "Mountain"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(3, "Sunbaked Canyon"),
            new SampleCard(1, "Swamp"),
            new SampleCard(1, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Thoughtseize"),
            new SampleCard(2, "Abrade"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(1, "Kroxa, Titan of Death's Hunger"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(4, "Molten Rain"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(2, "Wear // Tear") 
        };
    }
}