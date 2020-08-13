using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_16
{
    public class Deck45_martindoktor_AzoriusControl_Miracles_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Jace, the Mind Sculptor"),
            new SampleCard(1, "Narset, Parter of Veils"),
            new SampleCard(1, "Teferi, Hero of Dominaria"),
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(1, "Entreat the Angels"),
            new SampleCard(4, "Terminus"),
            new SampleCard(1, "Archmage's Charm"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(1, "Deprive"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(1, "Logic Knot"),
            new SampleCard(1, "Mana Leak"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(1, "Detention Sphere"),
            new SampleCard(1, "Omen of the Sea"),
            new SampleCard(1, "Search for Azcanta"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(3, "Hallowed Fountain"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(3, "Polluted Delta"),
            new SampleCard(6, "Snow-Covered Island"),
            new SampleCard(2, "Snow-Covered Plains") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Celestial Purge"),
            new SampleCard(1, "Ceremonious Rejection"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(1, "Dovin's Veto"),
            new SampleCard(1, "Monastery Mentor"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(1, "Rest in Peace"),
            new SampleCard(1, "Stony Silence"),
            new SampleCard(1, "Supreme Verdict"),
            new SampleCard(3, "Timely Reinforcements") 
        };
    }
}