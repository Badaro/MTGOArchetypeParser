using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_07_07
{
    public class Deck08_Binolino_PrimevalTitan_AmuletTitan_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Azusa, Lost but Seeking"),
            new SampleCard(4, "Dryad of the Ilysian Grove"),
            new SampleCard(2, "Fierce Empath"),
            new SampleCard(4, "Primeval Titan"),
            new SampleCard(4, "Sakura-Tribe Scout"),
            new SampleCard(2, "Explore"),
            new SampleCard(1, "Pact of Negation"),
            new SampleCard(4, "Summoner's Pact"),
            new SampleCard(4, "Amulet of Vigor"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(1, "Bojuka Bog"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(3, "Castle Garenbrig"),
            new SampleCard(2, "Cavern of Souls"),
            new SampleCard(1, "Crumbling Vestige"),
            new SampleCard(1, "Field of the Dead"),
            new SampleCard(2, "Forest"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(4, "Gruul Turf"),
            new SampleCard(1, "Hanweir Battlements"),
            new SampleCard(1, "Ketria Triome"),
            new SampleCard(1, "Radiant Fountain"),
            new SampleCard(4, "Simic Growth Chamber"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(2, "Tolaria West"),
            new SampleCard(2, "Valakut, the Molten Pinnacle"),
            new SampleCard(1, "Vesuva"),
            new SampleCard(1, "Windswept Heath"),
            new SampleCard(1, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(3, "Abrade"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Beast Within"),
            new SampleCard(2, "Firespout"),
            new SampleCard(1, "Force of Vigor"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(1, "Reclamation Sage"),
            new SampleCard(1, "World Breaker") 
        };
    }
}