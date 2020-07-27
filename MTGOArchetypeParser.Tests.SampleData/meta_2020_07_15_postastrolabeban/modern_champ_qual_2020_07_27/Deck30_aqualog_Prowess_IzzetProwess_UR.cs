using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_27
{
    public class Deck30_aqualog_Prowess_IzzetProwess_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Bedlam Reveler"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(2, "Sprite Dragon"),
            new SampleCard(4, "Stormwing Entity"),
            new SampleCard(4, "Light Up the Stage"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(4, "Mutagenic Growth"),
            new SampleCard(4, "Opt"),
            new SampleCard(2, "Wild Slash"),
            new SampleCard(1, "Arid Mesa"),
            new SampleCard(2, "Bloodstained Mire"),
            new SampleCard(3, "Fiery Islet"),
            new SampleCard(3, "Mountain"),
            new SampleCard(1, "Scalding Tarn"),
            new SampleCard(4, "Spirebluff Canal"),
            new SampleCard(2, "Steam Vents"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Abrade"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(3, "Dragon's Claw"),
            new SampleCard(1, "Kozilek's Return"),
            new SampleCard(2, "Spell Pierce"),
            new SampleCard(4, "Tormod's Crypt") 
        };
    }
}