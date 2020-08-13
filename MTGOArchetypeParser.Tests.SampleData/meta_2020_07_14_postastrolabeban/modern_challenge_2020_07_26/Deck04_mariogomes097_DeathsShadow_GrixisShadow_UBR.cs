using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_challenge_2020_07_26
{
    public class Deck04_mariogomes097_DeathsShadow_GrixisShadow_UBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "The Royal Scions"),
            new SampleCard(4, "Death's Shadow"),
            new SampleCard(4, "Gurmag Angler"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(2, "Young Pyromancer"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(3, "Cling to Dust"),
            new SampleCard(2, "Dismember"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(1, "Kolaghan's Command"),
            new SampleCard(1, "Lightning Bolt"),
            new SampleCard(3, "Stubborn Denial"),
            new SampleCard(2, "Temur Battle Rage"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(1, "Fiery Islet"),
            new SampleCard(1, "Island"),
            new SampleCard(1, "Marsh Flats"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "Silent Clearing"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Young Pyromancer"),
            new SampleCard(1, "Fatal Push"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(3, "Ceremonious Rejection"),
            new SampleCard(3, "Mana Leak"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(1, "Tasigur, the Golden Fang"),
            new SampleCard(2, "Terminate") 
        };
    }
}