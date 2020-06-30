using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_11
{
    public class Deck13_EdB_PrimevalTitan_AmuletTitan_UBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Arboreal Grazer"),
            new SampleCard(1, "Azusa, Lost but Seeking"),
            new SampleCard(4, "Dryad of the Ilysian Grove"),
            new SampleCard(4, "Primeval Titan"),
            new SampleCard(4, "Sakura-Tribe Scout"),
            new SampleCard(1, "Tireless Tracker"),
            new SampleCard(4, "Ancient Stirrings"),
            new SampleCard(1, "Pact of Negation"),
            new SampleCard(4, "Summoner's Pact"),
            new SampleCard(4, "Amulet of Vigor"),
            new SampleCard(1, "Bojuka Bog"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(2, "Castle Garenbrig"),
            new SampleCard(2, "Cavern of Souls"),
            new SampleCard(1, "Field of the Dead"),
            new SampleCard(2, "Forest"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(2, "Golgari Rot Farm"),
            new SampleCard(2, "Gruul Turf"),
            new SampleCard(1, "Hanweir Battlements"),
            new SampleCard(1, "Radiant Fountain"),
            new SampleCard(4, "Simic Growth Chamber"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(3, "Tolaria West"),
            new SampleCard(1, "Valakut, the Molten Pinnacle"),
            new SampleCard(1, "Vesuva"),
            new SampleCard(1, "Windswept Heath"),
            new SampleCard(1, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(1, "Radiant Fountain"),
            new SampleCard(2, "Tireless Tracker"),
            new SampleCard(4, "Dismember"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(2, "Pithing Needle"),
            new SampleCard(1, "Ramunap Excavator"),
            new SampleCard(1, "Reclamation Sage"),
            new SampleCard(2, "Spellskite") 
        };
    }
}