using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_17
{
    public class Deck19_argentopnz88_Prowess_IzzetProwess_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Delver of Secrets"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Sprite Dragon"),
            new SampleCard(4, "Stormwing Entity"),
            new SampleCard(1, "Assault Strobe"),
            new SampleCard(4, "Lava Spike"),
            new SampleCard(4, "Light Up the Stage"),
            new SampleCard(4, "Rift Bolt"),
            new SampleCard(2, "Gut Shot"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(4, "Fiery Islet"),
            new SampleCard(4, "Mountain"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(3, "Spirebluff Canal"),
            new SampleCard(2, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Abrade"),
            new SampleCard(3, "Ceremonious Rejection"),
            new SampleCard(2, "Dragon's Claw"),
            new SampleCard(1, "Flusterstorm"),
            new SampleCard(3, "Spell Pierce"),
            new SampleCard(2, "Surgical Extraction"),
            new SampleCard(2, "Vapor Snag") 
        };
    }
}