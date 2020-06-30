using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck52_TscheggschDePoegg_Rock_Sultai_UBG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Narnam Renegade"),(4, "Snapcaster Mage"),(3, "Tarmogoyf"),(4, "Uro, Titan of Nature's Wrath"),(2, "Inquisition of Kozilek"),(1, "Serum Visions"),(2, "Abrupt Decay"),(2, "Cling to Dust"),(2, "Deprive"),(3, "Drown in the Loch"),(3, "Fatal Push"),(3, "Force of Negation"),(4, "Thought Scour"),(2, "Mishra's Bauble"),(2, "Breeding Pool"),(1, "Darkslick Shores"),(1, "Flooded Strand"),(4, "Misty Rainforest"),(2, "Mystic Sanctuary"),(1, "Overgrown Tomb"),(4, "Polluted Delta"),(1, "Snow-Covered Forest"),(2, "Snow-Covered Island"),(1, "Snow-Covered Swamp"),(2, "Verdant Catacombs"),(1, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Fatal Push"),(2, "Aether Gust"),(2, "Ceremonious Rejection"),(3, "Collective Brutality"),(1, "Deglamer"),(1, "Disdainful Stroke"),(2, "Flusterstorm"),(1, "Liliana, the Last Hope"),(1, "Mystical Dispute"),(1, "Unravel the Aether") }; } }
    }
}