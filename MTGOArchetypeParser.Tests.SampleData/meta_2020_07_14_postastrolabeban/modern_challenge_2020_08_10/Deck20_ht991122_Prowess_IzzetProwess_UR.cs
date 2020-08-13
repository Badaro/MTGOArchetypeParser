using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_challenge_2020_08_10
{
    public class Deck20_ht991122_Prowess_IzzetProwess_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Bedlam Reveler"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(4, "Sprite Dragon"),
            new SampleCard(4, "Stormwing Entity"),
            new SampleCard(4, "Light Up the Stage"),
            new SampleCard(1, "Rift Bolt"),
            new SampleCard(1, "Burst Lightning"),
            new SampleCard(3, "Gut Shot"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(3, "Mutagenic Growth"),
            new SampleCard(3, "Arid Mesa"),
            new SampleCard(4, "Fiery Islet"),
            new SampleCard(2, "Mountain"),
            new SampleCard(4, "Spirebluff Canal"),
            new SampleCard(3, "Steam Vents"),
            new SampleCard(3, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Abrade"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(3, "Ceremonious Rejection"),
            new SampleCard(4, "Leyline of the Void"),
            new SampleCard(2, "Spell Pierce") 
        };
    }
}