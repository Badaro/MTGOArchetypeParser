using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_28
{
    public class Deck09_Moniz0801_PrimevalTitan_AmuletTitan_WURG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Azusa, Lost but Seeking"),
            new SampleCard(1, "Dragonlord Atarka"),
            new SampleCard(4, "Dryad of the Ilysian Grove"),
            new SampleCard(2, "Fierce Empath"),
            new SampleCard(1, "Klothys, God of Destiny"),
            new SampleCard(4, "Primeval Titan"),
            new SampleCard(4, "Sakura-Tribe Scout"),
            new SampleCard(2, "Explore"),
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
            new SampleCard(3, "Gruul Turf"),
            new SampleCard(1, "Ketria Triome"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(1, "Radiant Fountain"),
            new SampleCard(1, "Selesnya Sanctuary"),
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
            new SampleCard(2, "Abrade"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Dismember"),
            new SampleCard(2, "Firespout"),
            new SampleCard(1, "Pact of Negation"),
            new SampleCard(3, "Pithing Needle"),
            new SampleCard(3, "Tireless Tracker") 
        };
    }
}