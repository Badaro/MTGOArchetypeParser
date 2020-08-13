using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_challenge_2020_07_26
{
    public class Deck23_Moniz0801_PrimevalTitan_AmuletTitan_WURG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Azusa, Lost but Seeking"),
            new SampleCard(4, "Dryad of the Ilysian Grove"),
            new SampleCard(4, "Elvish Reclaimer"),
            new SampleCard(4, "Primeval Titan"),
            new SampleCard(1, "Uro, Titan of Nature's Wrath"),
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
            new SampleCard(4, "Flagstones of Trokair"),
            new SampleCard(2, "Forest"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(1, "Kabira Crossroads"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(3, "Selesnya Sanctuary"),
            new SampleCard(4, "Simic Growth Chamber"),
            new SampleCard(1, "Slayers' Stronghold"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(3, "Temple Garden"),
            new SampleCard(2, "Tolaria West"),
            new SampleCard(1, "Valakut, the Molten Pinnacle"),
            new SampleCard(1, "Vesuva") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(1, "Chameleon Colossus"),
            new SampleCard(2, "Negate"),
            new SampleCard(2, "Obstinate Baloth"),
            new SampleCard(1, "Pact of Negation"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(1, "Ramunap Excavator"),
            new SampleCard(2, "Tireless Tracker") 
        };
    }
}