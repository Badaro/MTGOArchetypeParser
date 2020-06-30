using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_28
{
    public class Deck11_Trisky_DeathsShadow_TraverseShadow_BRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Liliana of the Veil"),(4, "Death's Shadow"),(1, "Plague Engineer"),(4, "Street Wraith"),(4, "Tarmogoyf"),(4, "Inquisition of Kozilek"),(4, "Thoughtseize"),(4, "Traverse the Ulvenwald"),(2, "Assassin's Trophy"),(2, "Dismember"),(4, "Fatal Push"),(2, "Temur Battle Rage"),(4, "Mishra's Bauble"),(2, "Blood Crypt"),(2, "Bloodstained Mire"),(1, "Forest"),(4, "Nurturing Peatland"),(2, "Overgrown Tomb"),(1, "Swamp"),(4, "Verdant Catacombs"),(2, "Wooded Foothills"),(1, "Lurrus of the Dream-Den") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Plague Engineer"),(1, "Assassin's Trophy"),(3, "Collective Brutality"),(1, "Collector Ouphe"),(1, "Fulminator Mage"),(1, "Grafdigger's Cage"),(1, "Kolaghan's Command"),(1, "Magus of the Moon"),(1, "Reclamation Sage"),(1, "Surgical Extraction"),(2, "Veil of Summer"),(1, "Yixlid Jailer") }; } }
    }
}