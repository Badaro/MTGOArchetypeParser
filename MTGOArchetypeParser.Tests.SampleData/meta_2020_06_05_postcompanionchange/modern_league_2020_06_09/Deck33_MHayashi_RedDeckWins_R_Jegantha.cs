using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_09
{
    public class Deck33_MHayashi_RedDeckWins_R_Jegantha : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Abbot of Keral Keep"),
            new SampleCard(4, "Bonecrusher Giant"),
            new SampleCard(4, "Goblin Guide"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(4, "Light Up the Stage"),
            new SampleCard(4, "Burst Lightning"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Seal of Fire"),
            new SampleCard(4, "Ramunap Ruins"),
            new SampleCard(16, "Snow-Covered Mountain") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Blood Moon"),
            new SampleCard(1, "Jegantha, the Wellspring"),
            new SampleCard(4, "Rampaging Ferocidon"),
            new SampleCard(4, "Ratchet Bomb"),
            new SampleCard(4, "Relic of Progenitus") 
        };
    }
}