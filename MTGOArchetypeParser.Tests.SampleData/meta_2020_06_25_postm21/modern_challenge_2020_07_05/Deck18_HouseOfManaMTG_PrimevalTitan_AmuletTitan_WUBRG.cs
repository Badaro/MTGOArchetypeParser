using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_challenge_2020_07_05
{
    public class Deck18_HouseOfManaMTG_PrimevalTitan_AmuletTitan_WUBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Arboreal Grazer"),
            new SampleCard(1, "Azusa, Lost but Seeking"),
            new SampleCard(2, "Courser of Kruphix"),
            new SampleCard(4, "Dryad of the Ilysian Grove"),
            new SampleCard(4, "Primeval Titan"),
            new SampleCard(2, "Sakura-Tribe Scout"),
            new SampleCard(1, "Uro, Titan of Nature's Wrath"),
            new SampleCard(4, "Explore"),
            new SampleCard(4, "Summoner's Pact"),
            new SampleCard(4, "Amulet of Vigor"),
            new SampleCard(1, "Bojuka Bog"),
            new SampleCard(1, "Boros Garrison"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(3, "Castle Garenbrig"),
            new SampleCard(2, "Cavern of Souls"),
            new SampleCard(1, "Crumbling Vestige"),
            new SampleCard(1, "Field of the Dead"),
            new SampleCard(2, "Forest"),
            new SampleCard(1, "Golgari Rot Farm"),
            new SampleCard(1, "Gruul Turf"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(1, "Radiant Fountain"),
            new SampleCard(2, "Selesnya Sanctuary"),
            new SampleCard(4, "Simic Growth Chamber"),
            new SampleCard(1, "Slayers' Stronghold"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(1, "Sunhome, Fortress of the Legion"),
            new SampleCard(2, "Tolaria West"),
            new SampleCard(1, "Valakut, the Molten Pinnacle"),
            new SampleCard(1, "Vesuva"),
            new SampleCard(1, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Field of the Dead"),
            new SampleCard(1, "Uro, Titan of Nature's Wrath"),
            new SampleCard(1, "Beast Within"),
            new SampleCard(3, "Dismember"),
            new SampleCard(2, "Engineered Explosives"),
            new SampleCard(2, "Force of Vigor"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Pact of Negation"),
            new SampleCard(1, "Reclamation Sage"),
            new SampleCard(1, "Walking Ballista") 
        };
    }
}