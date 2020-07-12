using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_showcase_challenge_2020_07_12
{
    public class Deck08_BSKhercules_Prowess_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Bedlam Reveler"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(4, "Stormwing Entity"),
            new SampleCard(4, "Crash Through"),
            new SampleCard(4, "Light Up the Stage"),
            new SampleCard(4, "Gut Shot"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(2, "Mutagenic Growth"),
            new SampleCard(3, "Fiery Islet"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(4, "Snow-Covered Mountain"),
            new SampleCard(3, "Spirebluff Canal"),
            new SampleCard(3, "Steam Vents"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Abrade"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Assault Strobe"),
            new SampleCard(3, "Dragon's Claw"),
            new SampleCard(1, "Flame Slash"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(3, "Soul-Guide Lantern") 
        };
    }
}