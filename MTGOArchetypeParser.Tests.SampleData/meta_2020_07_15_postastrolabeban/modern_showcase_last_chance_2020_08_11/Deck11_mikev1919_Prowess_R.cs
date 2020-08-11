using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_showcase_last_chance_2020_08_11
{
    public class Deck11_mikev1919_Prowess_R : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Bedlam Reveler"),
            new SampleCard(2, "Kiln Fiend"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(1, "Runaway Steam-Kin"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(4, "Crash Through"),
            new SampleCard(2, "Firebolt"),
            new SampleCard(4, "Lava Spike"),
            new SampleCard(4, "Light Up the Stage"),
            new SampleCard(2, "Burst Lightning"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(1, "Fiery Islet"),
            new SampleCard(14, "Mountain"),
            new SampleCard(3, "Sunbaked Canyon") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Bedlam Reveler"),
            new SampleCard(1, "Kiln Fiend"),
            new SampleCard(1, "Abrade"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(3, "Grafdigger's Cage"),
            new SampleCard(3, "Mutagenic Growth"),
            new SampleCard(1, "Shrine of Burning Rage"),
            new SampleCard(3, "Skullcrack") 
        };
    }
}