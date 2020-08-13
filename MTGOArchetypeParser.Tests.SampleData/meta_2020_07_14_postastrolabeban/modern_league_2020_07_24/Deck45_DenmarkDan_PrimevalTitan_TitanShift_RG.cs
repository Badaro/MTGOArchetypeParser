using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_24
{
    public class Deck45_DenmarkDan_PrimevalTitan_TitanShift_RG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Courser of Kruphix"),
            new SampleCard(3, "Dryad of the Ilysian Grove"),
            new SampleCard(4, "Primeval Titan"),
            new SampleCard(4, "Sakura-Tribe Elder"),
            new SampleCard(1, "Escape to the Wilds"),
            new SampleCard(4, "Explore"),
            new SampleCard(3, "Scapeshift"),
            new SampleCard(4, "Search for Tomorrow"),
            new SampleCard(3, "Lightning Bolt"),
            new SampleCard(3, "Summoner's Pact"),
            new SampleCard(3, "Castle Garenbrig"),
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(2, "Cinder Glade"),
            new SampleCard(2, "Field of the Dead"),
            new SampleCard(1, "Forest"),
            new SampleCard(3, "Mountain"),
            new SampleCard(1, "Sheltered Thicket"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(3, "Snow-Covered Mountain"),
            new SampleCard(4, "Stomping Ground"),
            new SampleCard(4, "Valakut, the Molten Pinnacle"),
            new SampleCard(1, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(1, "Beast Within"),
            new SampleCard(1, "Chandra, Awakened Inferno"),
            new SampleCard(1, "Force of Vigor"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(2, "Obstinate Baloth"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(1, "Thrashing Brontodon"),
            new SampleCard(2, "Tireless Tracker"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}