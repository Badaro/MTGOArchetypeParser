using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_16
{
    public class Deck18_NHA37_Prowess_JeskaiProwess_WUR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Delver of Secrets"),
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(4, "Sprite Dragon"),
            new SampleCard(4, "Stormwing Entity"),
            new SampleCard(2, "Gut Shot"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Lightning Helix"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(4, "Opt"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(2, "Surgical Extraction"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(2, "Flooded Strand"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(1, "Island"),
            new SampleCard(1, "Mountain"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Seachrome Coast"),
            new SampleCard(4, "Spirebluff Canal"),
            new SampleCard(1, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Path to Exile"),
            new SampleCard(1, "Surgical Extraction"),
            new SampleCard(2, "Alpine Moon"),
            new SampleCard(2, "Kor Firewalker"),
            new SampleCard(2, "Lurrus of the Dream-Den"),
            new SampleCard(2, "Seasoned Pyromancer"),
            new SampleCard(2, "Tormod's Crypt"),
            new SampleCard(2, "Wear // Tear") 
        };
    }
}