using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05
{
    public class Deck15_Mussie99_AzoriusControl_Miracles_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Jace, the Mind Sculptor"),
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(1, "Entreat the Angels"),
            new SampleCard(1, "Serum Visions"),
            new SampleCard(3, "Terminus"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(2, "Logic Knot"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(4, "Counterbalance"),
            new SampleCard(3, "Omen of the Sea"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(3, "Hallowed Fountain"),
            new SampleCard(6, "Island"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(3, "Mystic Sanctuary"),
            new SampleCard(1, "Plains"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "Prairie Stream") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(2, "Flusterstorm"),
            new SampleCard(2, "Monastery Mentor"),
            new SampleCard(1, "Teferi, Hero of Dominaria"),
            new SampleCard(2, "Timely Reinforcements") 
        };
    }
}