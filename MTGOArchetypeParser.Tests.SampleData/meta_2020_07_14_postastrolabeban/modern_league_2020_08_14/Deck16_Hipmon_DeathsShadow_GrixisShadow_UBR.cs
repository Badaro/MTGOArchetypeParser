using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14
{
    public class Deck16_Hipmon_DeathsShadow_GrixisShadow_UBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Death's Shadow"),
            new SampleCard(4, "Gurmag Angler"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(2, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(2, "Dismember"),
            new SampleCard(1, "Eliminate"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(1, "Kolaghan's Command"),
            new SampleCard(1, "Lightning Bolt"),
            new SampleCard(4, "Stubborn Denial"),
            new SampleCard(2, "Temur Battle Rage"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(3, "Flooded Strand"),
            new SampleCard(1, "Island"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Eliminate"),
            new SampleCard(1, "Fatal Push"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(1, "Abrade"),
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(1, "Cling to Dust"),
            new SampleCard(3, "Collective Brutality"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(2, "Nihil Spellbomb") 
        };
    }
}