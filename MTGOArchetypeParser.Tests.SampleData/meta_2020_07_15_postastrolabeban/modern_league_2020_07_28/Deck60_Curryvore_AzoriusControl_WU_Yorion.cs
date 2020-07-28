using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_28
{
    public class Deck60_Curryvore_AzoriusControl_WU_Yorion : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Jace, the Mind Sculptor"),
            new SampleCard(3, "Teferi, Time Raveler"),
            new SampleCard(2, "Brazen Borrower"),
            new SampleCard(3, "Kitchen Finks"),
            new SampleCard(3, "Restoration Angel"),
            new SampleCard(2, "Snapcaster Mage"),
            new SampleCard(3, "Vendilion Clique"),
            new SampleCard(4, "Wall of Omens"),
            new SampleCard(4, "Supreme Verdict"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(4, "Force of Negation"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(2, "Spell Snare"),
            new SampleCard(4, "Spreading Seas"),
            new SampleCard(2, "Celestial Colonnade"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(7, "Island"),
            new SampleCard(1, "Mystic Gate"),
            new SampleCard(3, "Mystic Sanctuary"),
            new SampleCard(3, "Plains"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(2, "Prairie Stream") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(3, "Ashiok, Dream Render"),
            new SampleCard(1, "Celestial Purge"),
            new SampleCard(1, "Ceremonious Rejection"),
            new SampleCard(3, "Dovin's Veto"),
            new SampleCard(2, "Lyra Dawnbringer"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(1, "Yorion, Sky Nomad") 
        };
    }
}