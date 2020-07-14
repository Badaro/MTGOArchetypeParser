using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_10
{
    public class Deck26_Curveiganhei_RedDeckWins_R_Jegantha : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Abbot of Keral Keep"),
            new SampleCard(4, "Bomat Courier"),
            new SampleCard(4, "Bonecrusher Giant"),
            new SampleCard(2, "Heartfire Immolator"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(4, "Firebolt"),
            new SampleCard(4, "Light Up the Stage"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Seal of Fire"),
            new SampleCard(1, "Fiery Islet"),
            new SampleCard(18, "Mountain"),
            new SampleCard(1, "Sunbaked Canyon") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Abrade"),
            new SampleCard(4, "Blood Moon"),
            new SampleCard(1, "Jegantha, the Wellspring"),
            new SampleCard(2, "Ratchet Bomb"),
            new SampleCard(4, "Relic of Progenitus") 
        };
    }
}