using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_challenge_2020_07_13
{
    public class Deck21_MikeEgan_Ponza_RG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Chandra, Torch of Defiance"),
            new SampleCard(1, "Wrenn and Six"),
            new SampleCard(4, "Arbor Elf"),
            new SampleCard(4, "Bloodbraid Elf"),
            new SampleCard(2, "Bonecrusher Giant"),
            new SampleCard(1, "Elder Gargaroth"),
            new SampleCard(2, "Emrakul, the Aeons Torn"),
            new SampleCard(2, "Fierce Empath"),
            new SampleCard(3, "Klothys, God of Destiny"),
            new SampleCard(1, "Scavenging Ooze"),
            new SampleCard(3, "Seasoned Pyromancer"),
            new SampleCard(2, "Pillage"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(3, "Through the Breach"),
            new SampleCard(3, "Blood Moon"),
            new SampleCard(4, "Utopia Sprawl"),
            new SampleCard(6, "Forest"),
            new SampleCard(2, "Mountain"),
            new SampleCard(4, "Stomping Ground"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Abrade"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(1, "Boil"),
            new SampleCard(1, "Choke"),
            new SampleCard(1, "Cindervines"),
            new SampleCard(1, "Hornet Queen"),
            new SampleCard(2, "Kitchen Finks"),
            new SampleCard(1, "Obstinate Baloth"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(1, "Ruric Thar, the Unbowed"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}