using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_28
{
    public class Deck29_Logic_DeathsShadow_MarduShadow_WBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Death's Shadow"),
            new SampleCard(3, "Dreadhorde Arcanist"),
            new SampleCard(2, "Giver of Runes"),
            new SampleCard(4, "Ranger-Captain of Eos"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(2, "Unearth"),
            new SampleCard(2, "Cling to Dust"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(2, "Temur Battle Rage"),
            new SampleCard(1, "Arid Mesa"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(2, "Godless Shrine"),
            new SampleCard(4, "Marsh Flats"),
            new SampleCard(1, "Plains"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(4, "Silent Clearing"),
            new SampleCard(1, "Swamp") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Boil"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(2, "Fulminator Mage"),
            new SampleCard(3, "Nihil Spellbomb"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(2, "Wear // Tear") 
        };
    }
}