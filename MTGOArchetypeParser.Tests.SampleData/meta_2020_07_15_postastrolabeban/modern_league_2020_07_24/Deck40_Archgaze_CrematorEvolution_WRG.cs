using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24
{
    public class Deck40_Archgaze_CrematorEvolution_WRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Birds of Paradise"),
            new SampleCard(2, "Bonecrusher Giant"),
            new SampleCard(4, "Cragganwick Cremator"),
            new SampleCard(2, "Fauna Shaman"),
            new SampleCard(4, "Impervious Greatwurm"),
            new SampleCard(1, "Magus of the Moon"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(1, "Nullhide Ferox"),
            new SampleCard(1, "Questing Beast"),
            new SampleCard(1, "Scavenging Ooze"),
            new SampleCard(4, "Steel Leaf Champion"),
            new SampleCard(4, "Strangleroot Geist"),
            new SampleCard(3, "Eldritch Evolution"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(3, "Copperline Gorge"),
            new SampleCard(2, "Fire-Lit Thicket"),
            new SampleCard(6, "Forest"),
            new SampleCard(1, "Kessig Wolf Run"),
            new SampleCard(2, "Misty Rainforest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(2, "Stomping Ground"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(1, "Boil"),
            new SampleCard(1, "Choke"),
            new SampleCard(1, "Collector Ouphe"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(1, "Eidolon of Rhetoric"),
            new SampleCard(2, "Engineered Explosives"),
            new SampleCard(1, "Klothys, God of Destiny"),
            new SampleCard(1, "Obstinate Baloth"),
            new SampleCard(1, "Reclamation Sage"),
            new SampleCard(1, "Relic of Progenitus"),
            new SampleCard(1, "Shattering Spree"),
            new SampleCard(1, "Soul-Guide Lantern"),
            new SampleCard(1, "Veil of Summer") 
        };
    }
}