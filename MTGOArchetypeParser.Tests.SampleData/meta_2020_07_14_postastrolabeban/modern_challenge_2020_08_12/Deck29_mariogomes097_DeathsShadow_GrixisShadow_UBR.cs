using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_challenge_2020_08_12
{
    public class Deck29_mariogomes097_DeathsShadow_GrixisShadow_UBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "The Royal Scions"),
            new SampleCard(4, "Death's Shadow"),
            new SampleCard(4, "Gurmag Angler"),
            new SampleCard(2, "Jace, Vryn's Prodigy"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(2, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(3, "Cling to Dust"),
            new SampleCard(2, "Dismember"),
            new SampleCard(2, "Drown in the Loch"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(1, "Kolaghan's Command"),
            new SampleCard(3, "Stubborn Denial"),
            new SampleCard(2, "Temur Battle Rage"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(1, "Fiery Islet"),
            new SampleCard(1, "Island"),
            new SampleCard(1, "Marsh Flats"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "Scalding Tarn"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Fatal Push"),
            new SampleCard(1, "Kolaghan's Command"),
            new SampleCard(3, "Ceremonious Rejection"),
            new SampleCard(2, "Dreadbore"),
            new SampleCard(1, "Entrancing Melody"),
            new SampleCard(3, "Mana Leak"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(2, "Seasoned Pyromancer") 
        };
    }
}