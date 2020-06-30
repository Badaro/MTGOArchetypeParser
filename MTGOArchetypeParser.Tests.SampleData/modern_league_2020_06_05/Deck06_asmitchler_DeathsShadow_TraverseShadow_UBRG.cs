using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05
{
    public class Deck06_asmitchler_DeathsShadow_TraverseShadow_UBRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Death's Shadow"),(1, "Ghor-Clan Rampager"),(1, "Lurrus of the Dream Den"),(3, "Snapcaster Mage"),(4, "Street Wraith"),(4, "Tarmogoyf"),(3, "Inquisition of Kozilek"),(4, "Thoughtseize"),(3, "Traverse the Ulvenwald"),(2, "Unearth"),(1, "Assassin's Trophy"),(1, "Dismember"),(4, "Fatal Push"),(3, "Stubborn Denial"),(2, "Thought Scour"),(4, "Mishra's Bauble"),(1, "Blood Crypt"),(1, "Breeding Pool"),(1, "Forest"),(1, "Nurturing Peatland"),(1, "Overgrown Tomb"),(4, "Polluted Delta"),(1, "Swamp"),(4, "Verdant Catacombs"),(2, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Assassin's Trophy"),(1, "Stubborn Denial"),(3, "Collective Brutality"),(1, "Damping Sphere"),(2, "Disdainful Stroke"),(1, "Fulminator Mage"),(2, "Nihil Spellbomb"),(1, "Plague Engineer"),(2, "Temur Battle Rage"),(1, "Veil of Summer") }; } }
    }
}