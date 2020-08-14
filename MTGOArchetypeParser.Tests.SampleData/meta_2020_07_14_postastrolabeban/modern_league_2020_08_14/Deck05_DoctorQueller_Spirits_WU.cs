using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14
{
    public class Deck05_DoctorQueller_Spirits_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Drogskol Captain"),
            new SampleCard(4, "Mausoleum Wanderer"),
            new SampleCard(4, "Rattlechains"),
            new SampleCard(4, "Selfless Spirit"),
            new SampleCard(4, "Shacklegeist"),
            new SampleCard(4, "Spectral Sailor"),
            new SampleCard(4, "Spell Queller"),
            new SampleCard(4, "Supreme Phantom"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(2, "Cavern of Souls"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(1, "Moorland Haunt"),
            new SampleCard(2, "Mutavault"),
            new SampleCard(4, "Seachrome Coast"),
            new SampleCard(2, "Snow-Covered Island"),
            new SampleCard(2, "Snow-Covered Plains"),
            new SampleCard(1, "Waterlogged Grove") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Disdainful Stroke"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(3, "Kor Firewalker"),
            new SampleCard(1, "Remorseful Cleric"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(1, "Teferi, Time Raveler"),
            new SampleCard(2, "Winds of Abandon") 
        };
    }
}