using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_21
{
    public class Deck42_Ayzkub_PrimevalTitan_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(1, "Arboreal Grazer"),
            new SampleCard(4, "Dryad of the Ilysian Grove"),
            new SampleCard(4, "Primeval Titan"),
            new SampleCard(4, "Sakura-Tribe Elder"),
            new SampleCard(4, "Explore"),
            new SampleCard(4, "Search for Tomorrow"),
            new SampleCard(4, "Summoner's Pact"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(1, "Bojuka Bog"),
            new SampleCard(4, "Castle Garenbrig"),
            new SampleCard(3, "Cavern of Souls"),
            new SampleCard(3, "Field of the Dead"),
            new SampleCard(2, "Forest"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(2, "Golgari Rot Farm"),
            new SampleCard(1, "Nurturing Peatland"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(1, "Radiant Fountain"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Valakut, the Molten Pinnacle"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(1, "Vesuva") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Abrupt Decay"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(1, "Darksteel Citadel"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(1, "Golos, Tireless Pilgrim"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(1, "Reclamation Sage"),
            new SampleCard(1, "Tormod's Crypt"),
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(1, "Wurmcoil Engine") 
        };
    }
}