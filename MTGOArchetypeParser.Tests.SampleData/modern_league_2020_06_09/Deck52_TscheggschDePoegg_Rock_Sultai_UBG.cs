using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck52_TscheggschDePoegg_Rock_Sultai_UBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Narnam Renegade"),
            new SampleCard(4, "Snapcaster Mage"),
            new SampleCard(3, "Tarmogoyf"),
            new SampleCard(4, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Inquisition of Kozilek"),
            new SampleCard(1, "Serum Visions"),
            new SampleCard(2, "Abrupt Decay"),
            new SampleCard(2, "Cling to Dust"),
            new SampleCard(2, "Deprive"),
            new SampleCard(3, "Drown in the Loch"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(2, "Mishra's Bauble"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(1, "Darkslick Shores"),
            new SampleCard(1, "Flooded Strand"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(2, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(2, "Verdant Catacombs"),
            new SampleCard(1, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Fatal Push"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(3, "Collective Brutality"),
            new SampleCard(1, "Deglamer"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(2, "Flusterstorm"),
            new SampleCard(1, "Liliana, the Last Hope"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(1, "Unravel the Aether") 
        };
    }
}