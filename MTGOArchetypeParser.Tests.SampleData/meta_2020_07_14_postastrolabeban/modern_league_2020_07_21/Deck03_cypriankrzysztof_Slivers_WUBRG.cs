using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_21
{
    public class Deck03_cypriankrzysztof_Slivers_WUBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Cloudshredder Sliver"),
            new SampleCard(2, "Darkheart Sliver"),
            new SampleCard(3, "Dregscape Sliver"),
            new SampleCard(3, "Frenetic Sliver"),
            new SampleCard(4, "Galerider Sliver"),
            new SampleCard(4, "Leeching Sliver"),
            new SampleCard(4, "Predatory Sliver"),
            new SampleCard(2, "Sidewinder Sliver"),
            new SampleCard(4, "Sinew Sliver"),
            new SampleCard(2, "Striking Sliver"),
            new SampleCard(4, "Unsettled Mariner"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(1, "Fiery Islet"),
            new SampleCard(1, "Horizon Canopy"),
            new SampleCard(1, "Island"),
            new SampleCard(2, "Mutavault"),
            new SampleCard(1, "Plains"),
            new SampleCard(1, "Silent Clearing"),
            new SampleCard(4, "Sliver Hive"),
            new SampleCard(1, "Sunbaked Canyon"),
            new SampleCard(4, "Unclaimed Territory") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Chalice of the Void"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Dismember"),
            new SampleCard(3, "Harmonic Sliver"),
            new SampleCard(4, "Leyline of the Void") 
        };
    }
}