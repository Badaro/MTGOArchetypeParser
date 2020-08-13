using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_28
{
    public class Deck66_xXLogosXx_SnowControl_TemurSnow_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Jace, the Mind Sculptor"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(1, "Abrade"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(1, "Logic Knot"),
            new SampleCard(1, "Magmatic Sinkhole"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(3, "Opt"),
            new SampleCard(1, "Remand"),
            new SampleCard(2, "Spell Snare"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(2, "Shark Typhoon"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Ketria Triome"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(1, "Mystic Sanctuary"),
            new SampleCard(2, "Prismatic Vista"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(8, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(1, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(2, "Engineered Explosives"),
            new SampleCard(1, "Flusterstorm"),
            new SampleCard(1, "Huntmaster of the Fells"),
            new SampleCard(1, "Krosan Grip"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}