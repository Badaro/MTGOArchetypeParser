using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_preliminary_2020_07_14
{
    public class Deck03_azatoyellow_Prowess_R : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Abbot of Keral Keep"),
            new SampleCard(2, "Bedlam Reveler"),
            new SampleCard(3, "Kiln Fiend"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(4, "Crash Through"),
            new SampleCard(4, "Lava Spike"),
            new SampleCard(4, "Light Up the Stage"),
            new SampleCard(2, "Gut Shot"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(2, "Wild Slash"),
            new SampleCard(3, "Fiery Islet"),
            new SampleCard(15, "Mountain") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Abbot of Keral Keep"),
            new SampleCard(1, "Kiln Fiend"),
            new SampleCard(2, "Abrade"),
            new SampleCard(2, "Bonecrusher Giant"),
            new SampleCard(1, "Dismember"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(2, "Leyline of Combustion"),
            new SampleCard(3, "Mutagenic Growth"),
            new SampleCard(1, "Temur Battle Rage") 
        };
    }
}