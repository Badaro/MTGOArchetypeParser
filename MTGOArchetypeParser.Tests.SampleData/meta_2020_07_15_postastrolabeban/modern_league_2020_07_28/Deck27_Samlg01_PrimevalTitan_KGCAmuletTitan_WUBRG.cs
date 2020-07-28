using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_28
{
    public class Deck27_Samlg01_PrimevalTitan_KGCAmuletTitan_WUBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Karn, the Great Creator"),
            new SampleCard(1, "Azusa, Lost but Seeking"),
            new SampleCard(4, "Dryad of the Ilysian Grove"),
            new SampleCard(4, "Primeval Titan"),
            new SampleCard(4, "Sakura-Tribe Scout"),
            new SampleCard(1, "Uro, Titan of Nature's Wrath"),
            new SampleCard(4, "Explore"),
            new SampleCard(4, "Summoner's Pact"),
            new SampleCard(4, "Amulet of Vigor"),
            new SampleCard(1, "Bojuka Bog"),
            new SampleCard(1, "Boros Garrison"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(3, "Castle Garenbrig"),
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(1, "Crumbling Vestige"),
            new SampleCard(1, "Field of the Dead"),
            new SampleCard(2, "Forest"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(1, "Golgari Rot Farm"),
            new SampleCard(1, "Gruul Turf"),
            new SampleCard(1, "Ketria Triome"),
            new SampleCard(1, "Radiant Fountain"),
            new SampleCard(2, "Selesnya Sanctuary"),
            new SampleCard(4, "Simic Growth Chamber"),
            new SampleCard(1, "Slayers' Stronghold"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(1, "Sunhome, Fortress of the Legion"),
            new SampleCard(2, "Tolaria West"),
            new SampleCard(1, "Valakut, the Molten Pinnacle"),
            new SampleCard(1, "Vesuva"),
            new SampleCard(1, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Field of the Dead"),
            new SampleCard(1, "Beast Within"),
            new SampleCard(3, "Dismember"),
            new SampleCard(2, "Engineered Explosives"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(2, "Negate"),
            new SampleCard(1, "Pact of Negation"),
            new SampleCard(1, "Reclamation Sage"),
            new SampleCard(1, "Skysovereign, Consul Flagship"),
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(1, "Wurmcoil Engine") 
        };
    }
}