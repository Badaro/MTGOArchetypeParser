using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_09
{
    public class Deck51_zectrooperdelta_IzzetControl_IzzetBreach_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Emrakul, the Aeons Torn"),
            new SampleCard(2, "Simian Spirit Guide"),
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(1, "Anger of the Gods"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(1, "Abrade"),
            new SampleCard(2, "Archmage's Charm"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(3, "Lightning Bolt"),
            new SampleCard(3, "Opt"),
            new SampleCard(4, "Remand"),
            new SampleCard(2, "Spell Pierce"),
            new SampleCard(4, "Through the Breach"),
            new SampleCard(1, "Fiery Islet"),
            new SampleCard(2, "Island"),
            new SampleCard(1, "Mystic Sanctuary"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(4, "Shivan Reef"),
            new SampleCard(2, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(4, "Steam Vents"),
            new SampleCard(4, "Sulfur Falls") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Simian Spirit Guide"),
            new SampleCard(1, "Anger of the Gods"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(3, "Crackling Drake"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(2, "Niv-Mizzet, Parun"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(1, "Surgical Extraction"),
            new SampleCard(1, "Unsubstantiate") 
        };
    }
}