using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_14
{
    public class Deck09_tribalmaster_Prowess_IzzetProwess_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Bedlam Reveler"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(3, "Sprite Dragon"),
            new SampleCard(4, "Stormwing Entity"),
            new SampleCard(4, "Light Up the Stage"),
            new SampleCard(2, "Burst Lightning"),
            new SampleCard(2, "Gut Shot"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(2, "Mutagenic Growth"),
            new SampleCard(3, "Opt"),
            new SampleCard(1, "Arid Mesa"),
            new SampleCard(1, "Bloodstained Mire"),
            new SampleCard(3, "Fiery Islet"),
            new SampleCard(3, "Mountain"),
            new SampleCard(3, "Scalding Tarn"),
            new SampleCard(3, "Spirebluff Canal"),
            new SampleCard(3, "Steam Vents"),
            new SampleCard(1, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Abrade"),
            new SampleCard(1, "Aether Gust"),
            new SampleCard(1, "Blood Moon"),
            new SampleCard(3, "Dragon's Claw"),
            new SampleCard(2, "Flame Slash"),
            new SampleCard(1, "Kozilek's Return"),
            new SampleCard(1, "Soul-Guide Lantern"),
            new SampleCard(2, "Spell Pierce"),
            new SampleCard(2, "Surgical Extraction") 
        };
    }
}