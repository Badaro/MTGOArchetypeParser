using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_31
{
    public class Deck36_Galanator_IzzetControl_IzzetBreach_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Emrakul, the Aeons Torn"),
            new SampleCard(2, "Snapcaster Mage"),
            new SampleCard(1, "Vendilion Clique"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(1, "Magmatic Sinkhole"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Remand"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(4, "Through the Breach"),
            new SampleCard(4, "Omen of the Sea"),
            new SampleCard(1, "Shark Typhoon"),
            new SampleCard(2, "Flooded Strand"),
            new SampleCard(7, "Island"),
            new SampleCard(2, "Misty Rainforest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(3, "Mystic Sanctuary"),
            new SampleCard(1, "Polluted Delta"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(3, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Force of Negation"),
            new SampleCard(2, "Shark Typhoon"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(3, "Dragon's Claw"),
            new SampleCard(2, "Flusterstorm") 
        };
    }
}