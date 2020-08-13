using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07
{
    public class Deck27_Chaughey_Delver_JeskaiDelver_WUR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Brazen Borrower"),
            new SampleCard(4, "Delver of Secrets"),
            new SampleCard(4, "Mantis Rider"),
            new SampleCard(1, "Snapcaster Mage"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(4, "Sleight of Hand"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(3, "Lightning Helix"),
            new SampleCard(3, "Mana Leak"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(1, "Remand"),
            new SampleCard(1, "Spell Pierce"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(1, "Island"),
            new SampleCard(1, "Plains"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Seachrome Coast"),
            new SampleCard(2, "Spirebluff Canal"),
            new SampleCard(2, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Force of Negation"),
            new SampleCard(1, "Lightning Helix"),
            new SampleCard(1, "Mana Leak"),
            new SampleCard(1, "Path to Exile"),
            new SampleCard(1, "Spell Pierce"),
            new SampleCard(2, "Abrade"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(1, "Dovin's Veto"),
            new SampleCard(1, "Geist of Saint Traft"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(1, "Timely Reinforcements") 
        };
    }
}