using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07
{
    public class Deck12_markchalice_Prowess_R : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Bedlam Reveler"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(3, "Runaway Steam-Kin"),
            new SampleCard(1, "Seasoned Pyromancer"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(3, "Crash Through"),
            new SampleCard(1, "Finale of Promise"),
            new SampleCard(2, "Forked Bolt"),
            new SampleCard(3, "Lava Spike"),
            new SampleCard(4, "Light Up the Stage"),
            new SampleCard(2, "Burst Lightning"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(3, "Fiery Islet"),
            new SampleCard(15, "Mountain") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Abrade"),
            new SampleCard(3, "Blood Moon"),
            new SampleCard(2, "Dragon's Claw"),
            new SampleCard(2, "Flame Slash"),
            new SampleCard(2, "Kozilek's Return"),
            new SampleCard(3, "Leyline of the Void") 
        };
    }
}