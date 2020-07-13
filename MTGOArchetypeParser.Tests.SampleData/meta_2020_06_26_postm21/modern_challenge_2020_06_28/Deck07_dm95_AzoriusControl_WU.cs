using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_06_28
{
    public class Deck07_dm95_AzoriusControl_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Jace, the Mind Sculptor"),
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(1, "Vendilion Clique"),
            new SampleCard(1, "Oust"),
            new SampleCard(2, "Supreme Verdict"),
            new SampleCard(1, "Archmage's Charm"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Shark Typhoon"),
            new SampleCard(2, "Celestial Colonnade"),
            new SampleCard(3, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(2, "Glacial Fortress"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(7, "Island"),
            new SampleCard(1, "Mystic Sanctuary"),
            new SampleCard(1, "Plains"),
            new SampleCard(2, "Polluted Delta") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Batterskull"),
            new SampleCard(3, "Aether Gust"),
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(1, "Ceremonious Rejection"),
            new SampleCard(2, "Containment Priest"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(1, "Dovin's Veto"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(2, "Timely Reinforcements") 
        };
    }
}