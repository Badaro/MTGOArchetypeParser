using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_06_26
{
    public class Deck34_Sonkerz_IzzetControl_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Narset, Parter of Veils"),
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(4, "Thing in the Ice"),
            new SampleCard(1, "Vendilion Clique"),
            new SampleCard(1, "Flame Slash"),
            new SampleCard(3, "Serum Visions"),
            new SampleCard(1, "Abrade"),
            new SampleCard(2, "Archmage's Charm"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(1, "Electrolyze"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(1, "Magmatic Sinkhole"),
            new SampleCard(1, "Mana Leak"),
            new SampleCard(4, "Opt"),
            new SampleCard(3, "Remand"),
            new SampleCard(2, "Spell Snare"),
            new SampleCard(2, "Cascade Bluffs"),
            new SampleCard(7, "Island"),
            new SampleCard(1, "Mountain"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Flame Slash"),
            new SampleCard(3, "Aether Gust"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(1, "Dragon's Claw"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(1, "Flusterstorm"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(2, "Relic of Progenitus") 
        };
    }
}