using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck24_DemianDesposito10_Prowess_R : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Abbot of Keral Keep"),
            new SampleCard(1, "Bonecrusher Giant"),
            new SampleCard(4, "Goblin Guide"),
            new SampleCard(1, "Grim Lavamancer"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(4, "Forked Bolt"),
            new SampleCard(4, "Lava Spike"),
            new SampleCard(4, "Light Up the Stage"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(3, "Arid Mesa"),
            new SampleCard(2, "Bloodstained Mire"),
            new SampleCard(4, "Fiery Islet"),
            new SampleCard(4, "Mountain"),
            new SampleCard(4, "Sunbaked Canyon"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Blood Moon"),
            new SampleCard(2, "Dragon's Claw"),
            new SampleCard(4, "Leyline of the Void"),
            new SampleCard(3, "Reality Hemorrhage"),
            new SampleCard(4, "Smash to Smithereens") 
        };
    }
}