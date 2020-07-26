using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_challenge_2020_07_26
{
    public class Deck29_Jok87_IzzetControl_IzzetBreach_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Brineborn Cutthroat"),
            new SampleCard(3, "Emrakul, the Aeons Torn"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(3, "Serum Visions"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(2, "Fire Prophecy"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(3, "Remand"),
            new SampleCard(3, "Through the Breach"),
            new SampleCard(2, "Omen of the Sea"),
            new SampleCard(1, "Field of Ruin"),
            new SampleCard(3, "Flooded Strand"),
            new SampleCard(7, "Island"),
            new SampleCard(1, "Mountain"),
            new SampleCard(3, "Mystic Sanctuary"),
            new SampleCard(3, "Scalding Tarn"),
            new SampleCard(4, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(3, "Leyline of Sanctity"),
            new SampleCard(3, "Madcap Experiment"),
            new SampleCard(2, "Platinum Emperion") 
        };
    }
}