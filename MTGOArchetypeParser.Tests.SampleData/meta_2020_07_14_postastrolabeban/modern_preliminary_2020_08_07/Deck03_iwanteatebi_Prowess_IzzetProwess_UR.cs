using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_07
{
    public class Deck03_iwanteatebi_Prowess_IzzetProwess_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Bonecrusher Giant"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(2, "Sprite Dragon"),
            new SampleCard(4, "Stormwing Entity"),
            new SampleCard(4, "Crash Through"),
            new SampleCard(4, "Light Up the Stage"),
            new SampleCard(3, "Gut Shot"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(3, "Mutagenic Growth"),
            new SampleCard(3, "Fiery Islet"),
            new SampleCard(3, "Mountain"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(4, "Spirebluff Canal"),
            new SampleCard(2, "Steam Vents"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Bonecrusher Giant"),
            new SampleCard(4, "Abrade"),
            new SampleCard(4, "Dragon's Claw"),
            new SampleCard(2, "Engineered Explosives"),
            new SampleCard(4, "Soul-Guide Lantern") 
        };
    }
}