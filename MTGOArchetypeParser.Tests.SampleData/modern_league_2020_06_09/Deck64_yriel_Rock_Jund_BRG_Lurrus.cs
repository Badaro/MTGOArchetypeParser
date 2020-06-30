using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck64_yriel_Rock_Jund_BRG_Lurrus : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Dark Confidant"),(3, "Kroxa, Titan of Death's Hunger"),(3, "Scavenging Ooze"),(4, "Tarmogoyf"),(4, "Inquisition of Kozilek"),(4, "Thoughtseize"),(4, "Assassin's Trophy"),(4, "Kolaghan's Command"),(2, "Lightning Bolt"),(4, "Mishra's Bauble"),(3, "Seal of Fire"),(4, "Blackcleave Cliffs"),(1, "Blood Crypt"),(2, "Bloodstained Mire"),(1, "Copperline Gorge"),(1, "Nurturing Peatland"),(1, "Overgrown Tomb"),(1, "Snow-Covered Forest"),(1, "Snow-Covered Mountain"),(1, "Snow-Covered Swamp"),(1, "Stomping Ground"),(1, "Twilight Mire"),(4, "Verdant Catacombs"),(2, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Scavenging Ooze"),(3, "Collective Brutality"),(3, "Damping Sphere"),(1, "Engineered Explosives"),(1, "Fatal Push"),(1, "Lurrus of the Dream Den"),(2, "Nature's Claim"),(3, "Nihil Spellbomb") }; } }
    }
}