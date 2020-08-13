using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_24
{
    public class Deck34_Werepigs_DeathsShadow_MarduShadow_WBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Death's Shadow"),
            new SampleCard(2, "Gurmag Angler"),
            new SampleCard(4, "Ranger-Captain of Eos"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(4, "Tidehollow Sculler"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(2, "Kaya's Guile"),
            new SampleCard(2, "Kolaghan's Command"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Temur Battle Rage"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(3, "Arid Mesa"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(3, "Bloodstained Mire"),
            new SampleCard(2, "Godless Shrine"),
            new SampleCard(4, "Marsh Flats"),
            new SampleCard(1, "Mountain"),
            new SampleCard(1, "Plains"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(4, "Silent Clearing"),
            new SampleCard(1, "Swamp") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Ashiok, Dream Render"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(2, "Fulminator Mage"),
            new SampleCard(4, "Leyline of the Void"),
            new SampleCard(3, "Plague Engineer") 
        };
    }
}