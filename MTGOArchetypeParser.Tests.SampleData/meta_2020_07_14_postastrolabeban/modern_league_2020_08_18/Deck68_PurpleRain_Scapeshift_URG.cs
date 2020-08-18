using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck68_PurpleRain_Scapeshift_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Jace, the Mind Sculptor"),
            new SampleCard(4, "Sakura-Tribe Elder"),
            new SampleCard(2, "Uro, Titan of Nature's Wrath"),
            new SampleCard(4, "Scapeshift"),
            new SampleCard(4, "Search for Tomorrow"),
            new SampleCard(4, "Cryptic Command"),
            new SampleCard(3, "Growth Spiral"),
            new SampleCard(2, "Izzet Charm"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Remand"),
            new SampleCard(4, "Botanical Sanctum"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(2, "Ketria Triome"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(3, "Prismatic Vista"),
            new SampleCard(3, "Snow-Covered Forest"),
            new SampleCard(3, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(4, "Steam Vents"),
            new SampleCard(4, "Stomping Ground"),
            new SampleCard(2, "Valakut, the Molten Pinnacle") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Aether Gust"),
            new SampleCard(4, "Damping Sphere"),
            new SampleCard(4, "Madcap Experiment"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(2, "Platinum Emperion"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}