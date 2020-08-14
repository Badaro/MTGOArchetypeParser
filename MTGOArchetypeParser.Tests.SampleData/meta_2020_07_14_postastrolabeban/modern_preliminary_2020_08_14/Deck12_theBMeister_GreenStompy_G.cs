using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_14
{
    public class Deck12_theBMeister_GreenStompy_G : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Avatar of the Resolute"),
            new SampleCard(2, "Barkhide Troll"),
            new SampleCard(1, "Briarhorn"),
            new SampleCard(2, "Dryad Militant"),
            new SampleCard(4, "Experiment One"),
            new SampleCard(2, "Hexdrinker"),
            new SampleCard(1, "Questing Beast"),
            new SampleCard(3, "Scavenging Ooze"),
            new SampleCard(4, "Steel Leaf Champion"),
            new SampleCard(4, "Strangleroot Geist"),
            new SampleCard(2, "Dismember"),
            new SampleCard(2, "Mutagenic Growth"),
            new SampleCard(4, "Vines of Vastwood"),
            new SampleCard(4, "Rancor"),
            new SampleCard(13, "Forest"),
            new SampleCard(2, "Horizon Canopy"),
            new SampleCard(4, "Treetop Village"),
            new SampleCard(3, "Waterlogged Grove") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Dismember"),
            new SampleCard(1, "Choke"),
            new SampleCard(1, "Collector Ouphe"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Natural State"),
            new SampleCard(1, "Obstinate Baloth"),
            new SampleCard(3, "Veil of Summer"),
            new SampleCard(2, "Weather the Storm"),
            new SampleCard(1, "Wilt") 
        };
    }
}