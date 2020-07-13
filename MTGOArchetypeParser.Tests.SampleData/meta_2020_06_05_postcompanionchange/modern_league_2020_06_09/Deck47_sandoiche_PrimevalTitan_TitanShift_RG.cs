using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_09
{
    public class Deck47_sandoiche_PrimevalTitan_TitanShift_RG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Courser of Kruphix"),
            new SampleCard(2, "Dryad of the Ilysian Grove"),
            new SampleCard(4, "Primeval Titan"),
            new SampleCard(4, "Sakura-Tribe Elder"),
            new SampleCard(3, "Explore"),
            new SampleCard(2, "Farseek"),
            new SampleCard(1, "Mwonvuli Acid-Moss"),
            new SampleCard(3, "Scapeshift"),
            new SampleCard(4, "Search for Tomorrow"),
            new SampleCard(1, "Sweltering Suns"),
            new SampleCard(3, "Lightning Bolt"),
            new SampleCard(3, "Summoner's Pact"),
            new SampleCard(3, "Castle Garenbrig"),
            new SampleCard(2, "Cinder Glade"),
            new SampleCard(1, "Field of the Dead"),
            new SampleCard(1, "Forest"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(3, "Mountain"),
            new SampleCard(1, "Sheltered Thicket"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(3, "Snow-Covered Mountain"),
            new SampleCard(4, "Stomping Ground"),
            new SampleCard(4, "Valakut, the Molten Pinnacle"),
            new SampleCard(1, "Verdant Catacombs"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Anger of the Gods"),
            new SampleCard(2, "Beast Within"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(1, "Fry"),
            new SampleCard(2, "Obstinate Baloth"),
            new SampleCard(1, "Reclamation Sage"),
            new SampleCard(1, "Relic of Progenitus"),
            new SampleCard(2, "Tireless Tracker"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}