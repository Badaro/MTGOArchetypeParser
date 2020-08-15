using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_15
{
    public class Deck14_kbzx_Prowess_IzzetProwess_UR : ISampleDeck
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
            new SampleCard(1, "Bloodstained Mire"),
            new SampleCard(3, "Fiery Islet"),
            new SampleCard(4, "Mountain"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(4, "Spirebluff Canal"),
            new SampleCard(2, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Abrade"),
            new SampleCard(3, "Aether Gust"),
            new SampleCard(1, "Dismember"),
            new SampleCard(2, "Dragon's Claw"),
            new SampleCard(1, "Kozilek's Return"),
            new SampleCard(3, "Spell Pierce"),
            new SampleCard(3, "Tormod's Crypt") 
        };
    }
}