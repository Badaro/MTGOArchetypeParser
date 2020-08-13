using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_06_26
{
    public class Deck06_StreexIT_Spirits_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Teferi, Time Raveler"),
            new SampleCard(2, "Brazen Borrower"),
            new SampleCard(4, "Drogskol Captain"),
            new SampleCard(4, "Mausoleum Wanderer"),
            new SampleCard(4, "Rattlechains"),
            new SampleCard(4, "Selfless Spirit"),
            new SampleCard(4, "Spell Queller"),
            new SampleCard(4, "Supreme Phantom"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(2, "Remand"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(2, "Smuggler's Copter"),
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(3, "Island"),
            new SampleCard(2, "Moorland Haunt"),
            new SampleCard(2, "Mutavault"),
            new SampleCard(1, "Plains"),
            new SampleCard(4, "Seachrome Coast"),
            new SampleCard(1, "Silent Clearing") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Favorable Winds"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(1, "Kira, Great Glass-Spinner"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(2, "Shadow of Doubt"),
            new SampleCard(1, "Stony Silence"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(1, "Worship") 
        };
    }
}