using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14
{
    public class Deck22_Bugsy69_Prowess_IzzetProwess_UR : ISampleDeck
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
            new SampleCard(3, "Gut Shot"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(1, "Mutagenic Growth"),
            new SampleCard(3, "Opt"),
            new SampleCard(3, "Fiery Islet"),
            new SampleCard(5, "Mountain"),
            new SampleCard(3, "Scalding Tarn"),
            new SampleCard(4, "Spirebluff Canal"),
            new SampleCard(3, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Abrade"),
            new SampleCard(3, "Aether Gust"),
            new SampleCard(2, "Dragon's Claw"),
            new SampleCard(2, "Flame Slash"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(2, "Spell Pierce"),
            new SampleCard(2, "Tormod's Crypt") 
        };
    }
}