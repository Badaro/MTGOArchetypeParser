using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_preliminary_2020_06_06
{
    public class Deck14_nielsen333_JeskaiControl_JeskaiStoneblade_WUR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(3, "Stoneforge Mystic"),
            new SampleCard(2, "Supreme Verdict"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(1, "Electrolyze"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Lightning Helix"),
            new SampleCard(2, "Logic Knot"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(2, "Sphinx's Revelation"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(4, "Celestial Colonnade"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(1, "Island"),
            new SampleCard(1, "Mountain"),
            new SampleCard(1, "Plains"),
            new SampleCard(2, "Sacred Foundry"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Seachrome Coast"),
            new SampleCard(1, "Spirebluff Canal"),
            new SampleCard(2, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Supreme Verdict"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(3, "Anger of the Gods"),
            new SampleCard(1, "Celestial Purge"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(1, "Negate"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(2, "Rest in Peace") 
        };
    }
}