using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_showcase_last_chance_2020_08_11
{
    public class Deck10_TSPJendrek_SultaiControl_UBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Jace, the Mind Sculptor"),
            new SampleCard(2, "Snapcaster Mage"),
            new SampleCard(2, "Tarmogoyf"),
            new SampleCard(4, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Wall of Blossoms"),
            new SampleCard(2, "Abrupt Decay"),
            new SampleCard(1, "Archmage's Charm"),
            new SampleCard(1, "Cling to Dust"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(2, "Dismember"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(4, "Force of Negation"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(2, "Remand"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(2, "Field of Ruin"),
            new SampleCard(1, "Flooded Strand"),
            new SampleCard(2, "Forest"),
            new SampleCard(3, "Island"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(3, "Mystic Sanctuary"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "Scalding Tarn"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Watery Grave"),
            new SampleCard(1, "Zagoth Triome") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(1, "Ceremonious Rejection"),
            new SampleCard(2, "Collector Ouphe"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(1, "Scavenging Ooze"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(2, "Vendilion Clique") 
        };
    }
}