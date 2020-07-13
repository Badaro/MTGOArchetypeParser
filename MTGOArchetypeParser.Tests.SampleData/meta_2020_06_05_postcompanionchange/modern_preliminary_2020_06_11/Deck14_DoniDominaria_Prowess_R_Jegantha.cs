using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_preliminary_2020_06_11
{
    public class Deck14_DoniDominaria_Prowess_R_Jegantha : ISampleDeck
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
            new SampleCard(3, "Blood Moon"),
            new SampleCard(1, "Jegantha, the Wellspring"),
            new SampleCard(4, "Rampaging Ferocidon"),
            new SampleCard(3, "Ratchet Bomb"),
            new SampleCard(4, "Relic of Progenitus") 
        };
    }
}