using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12
{
    public class Deck20_B1gDan_DeathsShadow_MarduShadow_WBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Dark Confidant"),
            new SampleCard(4, "Death's Shadow"),
            new SampleCard(2, "Giver of Runes"),
            new SampleCard(4, "Ranger-Captain of Eos"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(4, "Tidehollow Sculler"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(1, "Anguished Unmaking"),
            new SampleCard(2, "Dismember"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(2, "Lightning Bolt"),
            new SampleCard(2, "Temur Battle Rage"),
            new SampleCard(2, "Arid Mesa"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(3, "Godless Shrine"),
            new SampleCard(4, "Marsh Flats"),
            new SampleCard(1, "Plains"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(2, "Silent Clearing"),
            new SampleCard(1, "Swamp") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Boil"),
            new SampleCard(1, "Celestial Purge"),
            new SampleCard(3, "Fulminator Mage"),
            new SampleCard(1, "Kaya, Orzhov Usurper"),
            new SampleCard(3, "Kaya's Guile"),
            new SampleCard(1, "Plague Engineer"),
            new SampleCard(3, "Surgical Extraction"),
            new SampleCard(1, "Wear // Tear") 
        };
    }
}