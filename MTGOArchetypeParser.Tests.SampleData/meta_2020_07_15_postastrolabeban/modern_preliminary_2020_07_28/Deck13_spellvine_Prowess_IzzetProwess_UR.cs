using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_28
{
    public class Deck13_spellvine_Prowess_IzzetProwess_UR : ISampleDeck
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
            new SampleCard(2, "Mutagenic Growth"),
            new SampleCard(4, "Opt"),
            new SampleCard(2, "Bloodstained Mire"),
            new SampleCard(2, "Fiery Islet"),
            new SampleCard(3, "Mountain"),
            new SampleCard(4, "Spirebluff Canal"),
            new SampleCard(3, "Steam Vents"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Abrade"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(2, "Dragon's Claw"),
            new SampleCard(1, "Kozilek's Return"),
            new SampleCard(2, "Soul-Guide Lantern"),
            new SampleCard(2, "Spell Pierce") 
        };
    }
}