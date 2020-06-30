using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_10
{
    public class Deck08_FabriceK_NinjaFaeries_UB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Changeling Outcast"),
            new SampleCard(4, "Faerie Seer"),
            new SampleCard(4, "Ingenious Infiltrator"),
            new SampleCard(3, "Mist-Syndicate Naga"),
            new SampleCard(4, "Ninja of the Deep Hours"),
            new SampleCard(1, "Snapcaster Mage"),
            new SampleCard(3, "Spectral Sailor"),
            new SampleCard(2, "Spellstutter Sprite"),
            new SampleCard(2, "Dismember"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(1, "Heartless Act"),
            new SampleCard(1, "Logic Knot"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(3, "Darkslick Shores"),
            new SampleCard(4, "Drowned Catacomb"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "Scalding Tarn"),
            new SampleCard(6, "Snow-Covered Island"),
            new SampleCard(2, "Snow-Covered Swamp"),
            new SampleCard(2, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Heartless Act"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(3, "Ceremonious Rejection"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(1, "Countersquall"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(2, "Flusterstorm"),
            new SampleCard(3, "Relic of Progenitus") 
        };
    }
}