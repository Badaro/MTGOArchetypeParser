using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_07_25
{
    public class Deck07_tyaburi_Prowess_R : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Bedlam Reveler"),
            new SampleCard(1, "Blistercoil Weird"),
            new SampleCard(4, "Kiln Fiend"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(4, "Crash Through"),
            new SampleCard(4, "Lava Spike"),
            new SampleCard(4, "Light Up the Stage"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(2, "Mutagenic Growth"),
            new SampleCard(2, "Temur Battle Rage"),
            new SampleCard(1, "Fiery Islet"),
            new SampleCard(14, "Mountain"),
            new SampleCard(1, "Ramunap Ruins"),
            new SampleCard(2, "Sunbaked Canyon") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Bedlam Reveler"),
            new SampleCard(1, "Abbot of Keral Keep"),
            new SampleCard(3, "Abrade"),
            new SampleCard(1, "Blood Moon"),
            new SampleCard(1, "Boil"),
            new SampleCard(1, "Bonecrusher Giant"),
            new SampleCard(1, "Eidolon of the Great Revel"),
            new SampleCard(1, "Grim Lavamancer"),
            new SampleCard(1, "Gut Shot"),
            new SampleCard(3, "Leyline of Combustion"),
            new SampleCard(1, "Searing Blood") 
        };
    }
}