using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck07_Jakesbaked_Scapeshift_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Nimble Obstructionist"),
            new SampleCard(2, "Uro, Titan of Nature's Wrath"),
            new SampleCard(4, "Scapeshift"),
            new SampleCard(4, "Search for Tomorrow"),
            new SampleCard(4, "Cryptic Command"),
            new SampleCard(4, "Growth Spiral"),
            new SampleCard(1, "Izzet Charm"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Peer Through Depths"),
            new SampleCard(4, "Remand"),
            new SampleCard(1, "Wilt"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(2, "Forest"),
            new SampleCard(3, "Island"),
            new SampleCard(4, "Ketria Triome"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(4, "Steam Vents"),
            new SampleCard(3, "Stomping Ground"),
            new SampleCard(2, "Valakut, the Molten Pinnacle") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(1, "Delay"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(3, "Veil of Summer"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}