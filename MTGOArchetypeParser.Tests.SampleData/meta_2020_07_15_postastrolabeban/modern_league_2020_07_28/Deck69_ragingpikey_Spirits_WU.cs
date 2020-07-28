using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_28
{
    public class Deck69_ragingpikey_Spirits_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Drogskol Captain"),
            new SampleCard(1, "Kira, Great Glass-Spinner"),
            new SampleCard(4, "Mausoleum Wanderer"),
            new SampleCard(3, "Phantasmal Image"),
            new SampleCard(4, "Rattlechains"),
            new SampleCard(4, "Selfless Spirit"),
            new SampleCard(2, "Spectral Sailor"),
            new SampleCard(4, "Spell Queller"),
            new SampleCard(4, "Supreme Phantom"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(3, "Island"),
            new SampleCard(1, "Moorland Haunt"),
            new SampleCard(2, "Mutavault"),
            new SampleCard(2, "Plains"),
            new SampleCard(4, "Seachrome Coast"),
            new SampleCard(1, "Waterlogged Grove") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Kira, Great Glass-Spinner"),
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(2, "Auriok Champion"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Deputy of Detention"),
            new SampleCard(1, "Kor Firewalker"),
            new SampleCard(2, "Lofty Denial"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(2, "Rest in Peace") 
        };
    }
}