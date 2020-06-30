using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_27
{
    public class Deck01_Kofurea_PrimevalTitan_KGCAmuletTitan_WUBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Karn, the Great Creator"),
            new SampleCard(1, "Azusa, Lost but Seeking"),
            new SampleCard(4, "Dryad of the Ilysian Grove"),
            new SampleCard(1, "Golos, Tireless Pilgrim"),
            new SampleCard(4, "Primeval Titan"),
            new SampleCard(4, "Sakura-Tribe Scout"),
            new SampleCard(4, "Ancient Stirrings"),
            new SampleCard(4, "Summoner's Pact"),
            new SampleCard(4, "Amulet of Vigor"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(1, "Bojuka Bog"),
            new SampleCard(1, "Boros Garrison"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(3, "Castle Garenbrig"),
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(1, "Field of the Dead"),
            new SampleCard(2, "Forest"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(1, "Golgari Rot Farm"),
            new SampleCard(1, "Gruul Turf"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(1, "Radiant Fountain"),
            new SampleCard(1, "Selesnya Sanctuary"),
            new SampleCard(4, "Simic Growth Chamber"),
            new SampleCard(1, "Slayers' Stronghold"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(1, "Sunhome, Fortress of the Legion"),
            new SampleCard(3, "Tolaria West"),
            new SampleCard(1, "Valakut, the Molten Pinnacle"),
            new SampleCard(1, "Verdant Catacombs"),
            new SampleCard(1, "Vesuva") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Golos, Tireless Pilgrim"),
            new SampleCard(2, "Engineered Explosives"),
            new SampleCard(2, "Dismember"),
            new SampleCard(2, "Force of Vigor"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(1, "Reclamation Sage"),
            new SampleCard(2, "Uro, Titan of Nature's Wrath"),
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(1, "Wurmcoil Engine") 
        };
    }
}