using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_07_06
{
    public class Deck12_gazmon48_Prowess_R_Jegantha : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Abbot of Keral Keep"),
            new SampleCard(4, "Bomat Courier"),
            new SampleCard(4, "Bonecrusher Giant"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(4, "Firebolt"),
            new SampleCard(4, "Light Up the Stage"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Seal of Fire"),
            new SampleCard(1, "Fiery Islet"),
            new SampleCard(18, "Mountain"),
            new SampleCard(1, "Sunbaked Canyon") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Abrade"),
            new SampleCard(1, "Jegantha, the Wellspring"),
            new SampleCard(4, "Magus of the Moon"),
            new SampleCard(2, "Ratchet Bomb"),
            new SampleCard(4, "Relic of Progenitus") 
        };
    }
}