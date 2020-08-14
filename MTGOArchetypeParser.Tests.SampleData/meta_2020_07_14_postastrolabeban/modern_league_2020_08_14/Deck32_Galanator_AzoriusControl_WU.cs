using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14
{
    public class Deck32_Galanator_AzoriusControl_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(4, "Narset, Parter of Veils"),
            new SampleCard(2, "Oust"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(1, "Supreme Verdict"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(4, "Force of Negation"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(4, "Remand"),
            new SampleCard(2, "Spell Snare"),
            new SampleCard(2, "On Thin Ice"),
            new SampleCard(3, "Shark Typhoon"),
            new SampleCard(4, "Spreading Seas"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Geier Reach Sanitarium"),
            new SampleCard(1, "Hall of Heliod's Generosity"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(2, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(2, "Polluted Delta"),
            new SampleCard(1, "Prairie Stream"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(6, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Supreme Verdict"),
            new SampleCard(3, "Aether Gust"),
            new SampleCard(1, "Celestial Purge"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(1, "Dovin's Veto"),
            new SampleCard(1, "Flusterstorm"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(2, "Porphyry Nodes"),
            new SampleCard(1, "Teferi's Puzzle Box"),
            new SampleCard(3, "Timely Reinforcements") 
        };
    }
}