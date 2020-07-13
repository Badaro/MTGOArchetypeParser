using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_05
{
    public class Deck28_D00mwake_Prowess_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Bedlam Reveler"),
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
            new SampleCard(2, "Surgical Extraction"),
            new SampleCard(2, "Arid Mesa"),
            new SampleCard(2, "Fiery Islet"),
            new SampleCard(4, "Mountain"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(4, "Spirebluff Canal"),
            new SampleCard(2, "Steam Vents"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Surgical Extraction"),
            new SampleCard(2, "Abrade"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Assault Strobe"),
            new SampleCard(1, "Blood Moon"),
            new SampleCard(2, "Dragon's Claw"),
            new SampleCard(2, "Kozilek's Return"),
            new SampleCard(2, "Mystical Dispute") 
        };
    }
}