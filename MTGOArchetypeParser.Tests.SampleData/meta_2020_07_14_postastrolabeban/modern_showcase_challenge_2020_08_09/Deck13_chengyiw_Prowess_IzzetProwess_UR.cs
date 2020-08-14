using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_showcase_challenge_2020_08_09
{
    public class Deck13_chengyiw_Prowess_IzzetProwess_UR : ISampleDeck
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
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(3, "Fiery Islet"),
            new SampleCard(3, "Mountain"),
            new SampleCard(3, "Spirebluff Canal"),
            new SampleCard(3, "Steam Vents"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Abrade"),
            new SampleCard(1, "Assault Strobe"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(3, "Dragon's Claw"),
            new SampleCard(1, "Flame Slash"),
            new SampleCard(1, "Kozilek's Return"),
            new SampleCard(2, "Spell Pierce"),
            new SampleCard(2, "Surgical Extraction") 
        };
    }
}