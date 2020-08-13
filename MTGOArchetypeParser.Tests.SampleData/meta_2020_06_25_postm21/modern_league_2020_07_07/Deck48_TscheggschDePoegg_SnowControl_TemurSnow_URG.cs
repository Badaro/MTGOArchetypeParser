using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07
{
    public class Deck48_TscheggschDePoegg_SnowControl_TemurSnow_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Jace, the Mind Sculptor"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(2, "Seasoned Pyromancer"),
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(1, "Abrade"),
            new SampleCard(2, "Archmage's Charm"),
            new SampleCard(1, "Burst Lightning"),
            new SampleCard(1, "Censor"),
            new SampleCard(2, "Deprive"),
            new SampleCard(1, "Force of Negation"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(1, "Remand"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(4, "Arcum's Astrolabe"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(1, "Flooded Strand"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(4, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(1, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Abrade"),
            new SampleCard(1, "Remand"),
            new SampleCard(3, "Aether Gust"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(2, "Crumble to Dust"),
            new SampleCard(1, "Fry"),
            new SampleCard(3, "Izzet Staticaster"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(1, "Negate") 
        };
    }
}