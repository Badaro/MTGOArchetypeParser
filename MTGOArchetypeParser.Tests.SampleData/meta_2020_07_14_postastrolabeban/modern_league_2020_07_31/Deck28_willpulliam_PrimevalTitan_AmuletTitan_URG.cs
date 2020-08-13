using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_31
{
    public class Deck28_willpulliam_PrimevalTitan_AmuletTitan_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Azusa, Lost but Seeking"),
            new SampleCard(4, "Dryad of the Ilysian Grove"),
            new SampleCard(4, "Primeval Titan"),
            new SampleCard(4, "Sakura-Tribe Scout"),
            new SampleCard(4, "Explore"),
            new SampleCard(1, "Pact of Negation"),
            new SampleCard(4, "Summoner's Pact"),
            new SampleCard(4, "Amulet of Vigor"),
            new SampleCard(1, "Bojuka Bog"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(4, "Castle Garenbrig"),
            new SampleCard(2, "Cavern of Souls"),
            new SampleCard(2, "Field of the Dead"),
            new SampleCard(2, "Forest"),
            new SampleCard(1, "Gemstone Mine"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(4, "Gruul Turf"),
            new SampleCard(1, "Hanweir Battlements"),
            new SampleCard(1, "Radiant Fountain"),
            new SampleCard(4, "Simic Growth Chamber"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(2, "Tolaria West"),
            new SampleCard(2, "Valakut, the Molten Pinnacle"),
            new SampleCard(1, "Vesuva"),
            new SampleCard(1, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Beast Within"),
            new SampleCard(2, "Dismember"),
            new SampleCard(2, "Engineered Explosives"),
            new SampleCard(1, "Force of Vigor"),
            new SampleCard(3, "Mystical Dispute"),
            new SampleCard(1, "Ramunap Excavator"),
            new SampleCard(1, "Reclamation Sage"),
            new SampleCard(3, "Tireless Tracker") 
        };
    }
}