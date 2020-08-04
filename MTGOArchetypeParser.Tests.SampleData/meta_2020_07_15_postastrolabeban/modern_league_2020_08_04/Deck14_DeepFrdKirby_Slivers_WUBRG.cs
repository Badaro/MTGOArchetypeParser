using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_04
{
    public class Deck14_DeepFrdKirby_Slivers_WUBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Cloudshredder Sliver"),
            new SampleCard(1, "Dregscape Sliver"),
            new SampleCard(1, "Frenetic Sliver"),
            new SampleCard(3, "Galerider Sliver"),
            new SampleCard(1, "Homing Sliver"),
            new SampleCard(2, "Leeching Sliver"),
            new SampleCard(3, "Manaweft Sliver"),
            new SampleCard(1, "Necrotic Sliver"),
            new SampleCard(4, "Predatory Sliver"),
            new SampleCard(4, "Sedge Sliver"),
            new SampleCard(1, "Sidewinder Sliver"),
            new SampleCard(4, "Sinew Sliver"),
            new SampleCard(2, "Striking Sliver"),
            new SampleCard(3, "Unsettled Mariner"),
            new SampleCard(3, "Collected Company"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(1, "Forest"),
            new SampleCard(1, "Godless Shrine"),
            new SampleCard(1, "Indatha Triome"),
            new SampleCard(4, "Mutavault"),
            new SampleCard(4, "Sliver Hive"),
            new SampleCard(1, "Swamp"),
            new SampleCard(1, "Urborg, Tomb of Yawgmoth"),
            new SampleCard(3, "Verdant Catacombs") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Frenetic Sliver"),
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(2, "Darkheart Sliver"),
            new SampleCard(3, "Dismember"),
            new SampleCard(2, "Harmonic Sliver"),
            new SampleCard(3, "Leyline of the Void"),
            new SampleCard(1, "Syphon Sliver") 
        };
    }
}