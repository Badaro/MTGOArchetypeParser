using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_23
{
    public class Deck23_abombdiggity_Slivers_WUBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Cloudshredder Sliver"),
            new SampleCard(3, "Dregscape Sliver"),
            new SampleCard(2, "Frenzy Sliver"),
            new SampleCard(4, "Galerider Sliver"),
            new SampleCard(1, "Harmonic Sliver"),
            new SampleCard(4, "Leeching Sliver"),
            new SampleCard(1, "Opaline Sliver"),
            new SampleCard(4, "Predatory Sliver"),
            new SampleCard(2, "Sidewinder Sliver"),
            new SampleCard(4, "Sinew Sliver"),
            new SampleCard(2, "Striking Sliver"),
            new SampleCard(1, "Syphon Sliver"),
            new SampleCard(4, "Unsettled Mariner"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(2, "Fiery Islet"),
            new SampleCard(3, "Mutavault"),
            new SampleCard(2, "Silent Clearing"),
            new SampleCard(4, "Sliver Hive"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(4, "Unclaimed Territory") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Harmonic Sliver"),
            new SampleCard(4, "Chalice of the Void"),
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(2, "Dismember"),
            new SampleCard(4, "Leyline of the Void") 
        };
    }
}