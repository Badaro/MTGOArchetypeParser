using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck49_dabigatran_Spirits_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Drogskol Captain"),
            new SampleCard(3, "Giver of Runes"),
            new SampleCard(4, "Mausoleum Wanderer"),
            new SampleCard(4, "Rattlechains"),
            new SampleCard(3, "Selfless Spirit"),
            new SampleCard(2, "Spectral Sailor"),
            new SampleCard(4, "Spell Queller"),
            new SampleCard(4, "Supreme Phantom"),
            new SampleCard(4, "Unsettled Mariner"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(4, "Island"),
            new SampleCard(1, "Moorland Haunt"),
            new SampleCard(1, "Plains"),
            new SampleCard(4, "Seachrome Coast"),
            new SampleCard(2, "Shefet Dunes"),
            new SampleCard(2, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(4, "Deprive"),
            new SampleCard(1, "Kira, Great Glass-Spinner"),
            new SampleCard(4, "Kor Firewalker"),
            new SampleCard(1, "Mark of Asylum"),
            new SampleCard(2, "Rest in Peace") 
        };
    }
}