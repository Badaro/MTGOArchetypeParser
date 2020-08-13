using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_14
{
    public class Deck44_Sonkerz_Delver_TemurDelver_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Delver of Secrets"),
            new SampleCard(3, "Jolrael, Mwonvuli Recluse"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(4, "Young Pyromancer"),
            new SampleCard(1, "Flame Slash"),
            new SampleCard(3, "Of One Mind"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(2, "Deprive"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(1, "Izzet Charm"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(1, "Magmatic Sinkhole"),
            new SampleCard(4, "Opt"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(4, "Island"),
            new SampleCard(1, "Ketria Triome"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(3, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Abrade"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(1, "Huntmaster of the Fells"),
            new SampleCard(2, "Narset, Parter of Veils"),
            new SampleCard(1, "Relic of Progenitus"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}