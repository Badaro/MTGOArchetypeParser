using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck28_Copilot11_IzzetControl_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Bonecrusher Giant"),
            new SampleCard(1, "Brazen Borrower"),
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(3, "Thing in the Ice"),
            new SampleCard(3, "Serum Visions"),
            new SampleCard(1, "Abrade"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(1, "Magmatic Sinkhole"),
            new SampleCard(1, "Mana Leak"),
            new SampleCard(4, "Opt"),
            new SampleCard(3, "Remand"),
            new SampleCard(1, "Spell Pierce"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(8, "Island"),
            new SampleCard(1, "Mountain"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(3, "Steam Vents"),
            new SampleCard(1, "Sulfur Falls") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Abrade"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(2, "Cerulean Drake"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(1, "Flusterstorm"),
            new SampleCard(2, "Relic of Progenitus") 
        };
    }
}