using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_preliminary_2020_06_30
{
    public class Deck15_FEARnLOATHing_Prowess_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(4, "Stormwing Entity"),
            new SampleCard(4, "Lava Spike"),
            new SampleCard(4, "Light Up the Stage"),
            new SampleCard(4, "Rift Bolt"),
            new SampleCard(4, "Gut Shot"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(4, "Fiery Islet"),
            new SampleCard(1, "Island"),
            new SampleCard(3, "Mountain"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(4, "Spirebluff Canal"),
            new SampleCard(4, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Abrade"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(1, "Dragon's Claw"),
            new SampleCard(3, "Grafdigger's Cage"),
            new SampleCard(1, "Shrine of Burning Rage"),
            new SampleCard(3, "Skullcrack"),
            new SampleCard(2, "Surgical Extraction") 
        };
    }
}