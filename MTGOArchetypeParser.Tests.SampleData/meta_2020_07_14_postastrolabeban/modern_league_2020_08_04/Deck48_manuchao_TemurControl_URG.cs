using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_04
{
    public class Deck48_manuchao_TemurControl_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Jace, the Mind Sculptor"),
            new SampleCard(2, "Wrenn and Six"),
            new SampleCard(2, "Primeval Titan"),
            new SampleCard(1, "Snapcaster Mage"),
            new SampleCard(4, "Uro, Titan of Nature's Wrath"),
            new SampleCard(4, "Cryptic Command"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(4, "Growth Spiral"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Remand"),
            new SampleCard(3, "Shark Typhoon"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(1, "Field of Ruin"),
            new SampleCard(2, "Field of the Dead"),
            new SampleCard(1, "Forest"),
            new SampleCard(2, "Island"),
            new SampleCard(2, "Ketria Triome"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(1, "Oboro, Palace in the Clouds"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(2, "Snow-Covered Island"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(1, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Aether Gust"),
            new SampleCard(1, "Anger of the Gods"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Ceremonious Rejection"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Elder Gargaroth"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(1, "Thragtusk"),
            new SampleCard(1, "Tireless Tracker"),
            new SampleCard(1, "Veil of Summer") 
        };
    }
}