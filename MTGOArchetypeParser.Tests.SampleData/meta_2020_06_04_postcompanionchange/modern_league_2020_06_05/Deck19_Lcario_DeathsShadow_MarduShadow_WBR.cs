using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_05
{
    public class Deck19_Lcario_DeathsShadow_MarduShadow_WBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Death's Shadow"),
            new SampleCard(1, "Gurmag Angler"),
            new SampleCard(1, "Hex Parasite"),
            new SampleCard(4, "Ranger-Captain of Eos"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(4, "Tidehollow Sculler"),
            new SampleCard(2, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(2, "Unearth"),
            new SampleCard(2, "Dismember"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(2, "Temur Battle Rage"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(2, "Arid Mesa"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(3, "Bloodstained Mire"),
            new SampleCard(2, "Godless Shrine"),
            new SampleCard(4, "Marsh Flats"),
            new SampleCard(1, "Plains"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(4, "Silent Clearing"),
            new SampleCard(1, "Swamp") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Fatal Push"),
            new SampleCard(1, "Kolaghan's Command"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Collective Brutality"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Duress"),
            new SampleCard(2, "Gideon, Ally of Zendikar"),
            new SampleCard(2, "Kaya's Guile"),
            new SampleCard(1, "Plague Engineer"),
            new SampleCard(2, "Rest in Peace") 
        };
    }
}