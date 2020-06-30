using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_showcase_challenge_2020_06_07
{
    public class Deck27_Ennuixd_PrimevalTitan_AmuletTitan_WURG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Arboreal Grazer"),
            new SampleCard(1, "Azusa, Lost but Seeking"),
            new SampleCard(4, "Dryad of the Ilysian Grove"),
            new SampleCard(4, "Primeval Titan"),
            new SampleCard(1, "Uro, Titan of Nature's Wrath"),
            new SampleCard(3, "Wargate"),
            new SampleCard(1, "Pact of Negation"),
            new SampleCard(4, "Summoner's Pact"),
            new SampleCard(4, "Amulet of Vigor"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(1, "Bojuka Bog"),
            new SampleCard(1, "Boros Garrison"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(4, "Castle Garenbrig"),
            new SampleCard(2, "Cavern of Souls"),
            new SampleCard(1, "Field of the Dead"),
            new SampleCard(2, "Forest"),
            new SampleCard(2, "Gemstone Mine"),
            new SampleCard(4, "Selesnya Sanctuary"),
            new SampleCard(4, "Simic Growth Chamber"),
            new SampleCard(1, "Slayers' Stronghold"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(1, "Sunhome, Fortress of the Legion"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(2, "Tolaria West"),
            new SampleCard(2, "Valakut, the Molten Pinnacle"),
            new SampleCard(1, "Vesuva"),
            new SampleCard(1, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Field of the Dead"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(2, "Beast Within"),
            new SampleCard(2, "Dismember"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(1, "Obstinate Baloth"),
            new SampleCard(1, "Radiant Fountain"),
            new SampleCard(1, "Reclamation Sage"),
            new SampleCard(1, "Sorcerous Spyglass"),
            new SampleCard(1, "Tireless Tracker") 
        };
    }
}