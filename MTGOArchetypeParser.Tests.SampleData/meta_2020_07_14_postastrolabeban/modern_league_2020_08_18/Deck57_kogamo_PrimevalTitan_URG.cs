using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck57_kogamo_PrimevalTitan_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Wrenn and Six"),
            new SampleCard(4, "Arboreal Grazer"),
            new SampleCard(4, "Dryad of the Ilysian Grove"),
            new SampleCard(1, "Elder Gargaroth"),
            new SampleCard(1, "Hydroid Krasis"),
            new SampleCard(4, "Primeval Titan"),
            new SampleCard(4, "Sakura-Tribe Elder"),
            new SampleCard(2, "Uro, Titan of Nature's Wrath"),
            new SampleCard(4, "Explore"),
            new SampleCard(4, "Summoner's Pact"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(2, "Castle Garenbrig"),
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(1, "Field of Ruin"),
            new SampleCard(2, "Field of the Dead"),
            new SampleCard(1, "Forest"),
            new SampleCard(1, "Island"),
            new SampleCard(1, "Ketria Triome"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Island"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(2, "Valakut, the Molten Pinnacle"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ancient Grudge"),
            new SampleCard(1, "Anger of the Gods"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Engineered Explosives"),
            new SampleCard(1, "Obstinate Baloth"),
            new SampleCard(1, "Reclamation Sage"),
            new SampleCard(2, "Tireless Tracker"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}