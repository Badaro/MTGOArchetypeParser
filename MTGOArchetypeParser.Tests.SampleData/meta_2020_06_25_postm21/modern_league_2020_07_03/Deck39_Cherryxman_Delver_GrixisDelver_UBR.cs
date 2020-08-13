using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_03
{
    public class Deck39_Cherryxman_Delver_GrixisDelver_UBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Brazen Borrower"),
            new SampleCard(4, "Delver of Secrets"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(4, "Thieves' Guild Enforcer"),
            new SampleCard(3, "Vantress Gargoyle"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(1, "Thoughtseize"),
            new SampleCard(4, "Drown in the Loch"),
            new SampleCard(1, "Force of Negation"),
            new SampleCard(1, "Into the Story"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(1, "Spell Pierce"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(1, "Mystic Sanctuary"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(1, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(2, "Steam Vents"),
            new SampleCard(3, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Spell Snare"),
            new SampleCard(2, "Bitterblossom"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(3, "Collective Brutality"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(3, "Surgical Extraction") 
        };
    }
}