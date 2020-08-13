using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_challenge_2020_07_19
{
    public class Deck28_azatoyellow_RedDeckWins_R_Jegantha : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Abbot of Keral Keep"),
            new SampleCard(4, "Bonecrusher Giant"),
            new SampleCard(4, "Heartfire Immolator"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(4, "Firebolt"),
            new SampleCard(4, "Light Up the Stage"),
            new SampleCard(4, "Burst Lightning"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Fiery Islet"),
            new SampleCard(18, "Mountain") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Abrade"),
            new SampleCard(3, "Blood Moon"),
            new SampleCard(1, "Jegantha, the Wellspring"),
            new SampleCard(3, "Kozilek's Return"),
            new SampleCard(4, "Relic of Progenitus") 
        };
    }
}