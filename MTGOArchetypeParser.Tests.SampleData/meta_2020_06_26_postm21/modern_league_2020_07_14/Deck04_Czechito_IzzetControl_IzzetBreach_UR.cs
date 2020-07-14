using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_14
{
    public class Deck04_Czechito_IzzetControl_IzzetBreach_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Emrakul, the Aeons Torn"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(1, "Vendilion Clique"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(1, "Izzet Charm"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Remand"),
            new SampleCard(4, "Through the Breach"),
            new SampleCard(4, "Omen of the Sea"),
            new SampleCard(3, "Flooded Strand"),
            new SampleCard(7, "Island"),
            new SampleCard(3, "Misty Rainforest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(3, "Mystic Sanctuary"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Abrade"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(3, "Ashiok, Dream Render"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(2, "Flusterstorm"),
            new SampleCard(3, "Madcap Experiment"),
            new SampleCard(2, "Platinum Emperion") 
        };
    }
}