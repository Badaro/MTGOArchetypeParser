using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_19
{
    public class Deck09_xlsnapcaster_AzoriusControl_Miracles_WU_Kaheera : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Jace, the Mind Sculptor"),
            new SampleCard(2, "Teferi, Hero of Dominaria"),
            new SampleCard(1, "Supreme Verdict"),
            new SampleCard(4, "Terminus"),
            new SampleCard(2, "Timely Reinforcements"),
            new SampleCard(4, "Cryptic Command"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(3, "Mana Leak"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Detention Sphere"),
            new SampleCard(4, "Omen of the Sea"),
            new SampleCard(2, "Castle Vantress"),
            new SampleCard(2, "Celestial Colonnade"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(6, "Island"),
            new SampleCard(3, "Mystic Sanctuary"),
            new SampleCard(2, "Plains") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Supreme Verdict"),
            new SampleCard(1, "Timely Reinforcements"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(4, "Ashiok, Dream Render"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(2, "Dovin's Veto"),
            new SampleCard(1, "Kaheera, the Orphanguard"),
            new SampleCard(2, "Narset, Parter of Veils") 
        };
    }
}