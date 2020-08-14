using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14
{
    public class Deck11_IzzetSignetIsTheBest_PrimevalTitan_AmuletTitan_WUBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Arboreal Grazer"),
            new SampleCard(4, "Azusa, Lost but Seeking"),
            new SampleCard(4, "Dryad of the Ilysian Grove"),
            new SampleCard(3, "Fierce Empath"),
            new SampleCard(4, "Primeval Titan"),
            new SampleCard(1, "Pact of Negation"),
            new SampleCard(4, "Summoner's Pact"),
            new SampleCard(4, "Amulet of Vigor"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(4, "Castle Garenbrig"),
            new SampleCard(3, "Cavern of Souls"),
            new SampleCard(1, "Crumbling Vestige"),
            new SampleCard(1, "Field of the Dead"),
            new SampleCard(2, "Forest"),
            new SampleCard(1, "Golgari Rot Farm"),
            new SampleCard(2, "Gruul Turf"),
            new SampleCard(1, "Hanweir Battlements"),
            new SampleCard(1, "Radiant Fountain"),
            new SampleCard(1, "Selesnya Sanctuary"),
            new SampleCard(4, "Simic Growth Chamber"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(3, "Tolaria West"),
            new SampleCard(2, "Valakut, the Molten Pinnacle"),
            new SampleCard(1, "Verdant Catacombs"),
            new SampleCard(1, "Vesuva") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Field of the Dead"),
            new SampleCard(2, "Beast Within"),
            new SampleCard(1, "Bojuka Bog"),
            new SampleCard(2, "Dismember"),
            new SampleCard(1, "Force of Vigor"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(1, "Reclamation Sage"),
            new SampleCard(1, "Ruric Thar, the Unbowed"),
            new SampleCard(3, "Tireless Tracker") 
        };
    }
}