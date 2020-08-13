using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_09
{
    public class Deck04_HeyPharaoh_AzoriusControl_Miracles_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Jace, the Mind Sculptor"),
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(1, "Entreat the Angels"),
            new SampleCard(3, "Terminus"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(2, "Logic Knot"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(4, "Counterbalance"),
            new SampleCard(4, "Omen of the Sea"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(3, "Hallowed Fountain"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(4, "Mystic Sanctuary"),
            new SampleCard(1, "Prairie Stream"),
            new SampleCard(1, "Scalding Tarn"),
            new SampleCard(6, "Snow-Covered Island") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(2, "Flusterstorm"),
            new SampleCard(2, "Monastery Mentor"),
            new SampleCard(2, "On Thin Ice"),
            new SampleCard(1, "Teferi, Hero of Dominaria"),
            new SampleCard(2, "Timely Reinforcements") 
        };
    }
}