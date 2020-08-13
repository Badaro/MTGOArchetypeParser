using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_challenge_2020_08_12_0
{
    public class Deck31_kthanakit26_Prowess_IzzetProwess_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Bedlam Reveler"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(3, "Sprite Dragon"),
            new SampleCard(4, "Stormwing Entity"),
            new SampleCard(3, "Light Up the Stage"),
            new SampleCard(2, "Burst Lightning"),
            new SampleCard(2, "Gut Shot"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(3, "Mutagenic Growth"),
            new SampleCard(3, "Opt"),
            new SampleCard(2, "Arid Mesa"),
            new SampleCard(3, "Fiery Islet"),
            new SampleCard(3, "Mountain"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(4, "Spirebluff Canal"),
            new SampleCard(2, "Steam Vents"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Abrade"),
            new SampleCard(3, "Dragon's Claw"),
            new SampleCard(2, "Flame Slash"),
            new SampleCard(2, "Kozilek's Return"),
            new SampleCard(3, "Spell Pierce"),
            new SampleCard(3, "Surgical Extraction") 
        };
    }
}