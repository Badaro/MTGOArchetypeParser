using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_08_10
{
    public class Deck18_Gerschi_Prowess_RakdosProwess_WBR_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Abbot of Keral Keep"),
            new SampleCard(4, "Kiln Fiend"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(2, "Cling to Dust"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Manamorphose"),
            new SampleCard(3, "Mutagenic Growth"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(2, "Seal of Fire"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(3, "Mountain"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(1, "Scalding Tarn"),
            new SampleCard(3, "Sunbaked Canyon"),
            new SampleCard(1, "Swamp") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Boil"),
            new SampleCard(2, "Dragon's Claw"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(2, "Flame Slash"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(3, "Molten Rain"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(2, "Wear // Tear") 
        };
    }
}