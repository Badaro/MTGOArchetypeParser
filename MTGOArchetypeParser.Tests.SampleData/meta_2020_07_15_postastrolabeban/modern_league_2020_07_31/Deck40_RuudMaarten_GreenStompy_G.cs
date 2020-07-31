using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_31
{
    public class Deck40_RuudMaarten_GreenStompy_G : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Avatar of the Resolute"),
            new SampleCard(4, "Barkhide Troll"),
            new SampleCard(2, "Experiment One"),
            new SampleCard(2, "Ghalta, Primal Hunger"),
            new SampleCard(4, "Pelt Collector"),
            new SampleCard(1, "Rhonas the Indomitable"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(4, "Strangleroot Geist"),
            new SampleCard(4, "Yorvo, Lord of Garenbrig"),
            new SampleCard(4, "Aspect of Hydra"),
            new SampleCard(4, "Blossoming Defense"),
            new SampleCard(2, "The Great Henge"),
            new SampleCard(4, "Rancor"),
            new SampleCard(13, "Forest"),
            new SampleCard(2, "Horizon Canopy"),
            new SampleCard(4, "Nurturing Peatland") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Choke"),
            new SampleCard(3, "Force of Vigor"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(2, "Sorcerous Spyglass"),
            new SampleCard(4, "Veil of Summer"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}