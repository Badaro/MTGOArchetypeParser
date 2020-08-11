using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_11
{
    public class Deck20_ferrum0728_DeathsShadow_MarduShadow_WBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Death's Shadow"),
            new SampleCard(2, "Dreadhorde Arcanist"),
            new SampleCard(2, "Giver of Runes"),
            new SampleCard(4, "Ranger-Captain of Eos"),
            new SampleCard(1, "Selfless Savior"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(4, "Tidehollow Sculler"),
            new SampleCard(2, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(2, "Unearth"),
            new SampleCard(2, "Dismember"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(3, "Lightning Bolt"),
            new SampleCard(2, "Temur Battle Rage"),
            new SampleCard(1, "Arid Mesa"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(2, "Bloodstained Mire"),
            new SampleCard(3, "Godless Shrine"),
            new SampleCard(4, "Marsh Flats"),
            new SampleCard(1, "Plains"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(4, "Silent Clearing"),
            new SampleCard(1, "Swamp") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Celestial Purge"),
            new SampleCard(1, "Collective Brutality"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(3, "Fulminator Mage"),
            new SampleCard(2, "Goblin Cratermaker"),
            new SampleCard(1, "Healing Grace"),
            new SampleCard(1, "Kaya, Orzhov Usurper"),
            new SampleCard(1, "Stony Silence"),
            new SampleCard(2, "Surgical Extraction"),
            new SampleCard(2, "Wear // Tear") 
        };
    }
}