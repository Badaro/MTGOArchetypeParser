using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_08_08
{
    public class Deck10_Moniz0801_PrimevalTitan_AmuletTitan_WURG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Arboreal Grazer"),
            new SampleCard(2, "Azusa, Lost but Seeking"),
            new SampleCard(4, "Dryad of the Ilysian Grove"),
            new SampleCard(4, "Primeval Titan"),
            new SampleCard(3, "Sakura-Tribe Scout"),
            new SampleCard(2, "Explore"),
            new SampleCard(4, "Summoner's Pact"),
            new SampleCard(4, "Amulet of Vigor"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(1, "Bojuka Bog"),
            new SampleCard(1, "Boros Garrison"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(4, "Castle Garenbrig"),
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(1, "Field of the Dead"),
            new SampleCard(2, "Forest"),
            new SampleCard(2, "Gemstone Mine"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(1, "Kabira Crossroads"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(4, "Selesnya Sanctuary"),
            new SampleCard(4, "Simic Growth Chamber"),
            new SampleCard(1, "Slayers' Stronghold"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(2, "Tolaria West"),
            new SampleCard(1, "Valakut, the Molten Pinnacle"),
            new SampleCard(1, "Verdant Catacombs"),
            new SampleCard(1, "Vesuva") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Beast Within"),
            new SampleCard(3, "Celestial Purge"),
            new SampleCard(2, "Force of Vigor"),
            new SampleCard(1, "Obstinate Baloth"),
            new SampleCard(1, "Pact of Negation"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(1, "Reclamation Sage"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(1, "Tireless Tracker") 
        };
    }
}