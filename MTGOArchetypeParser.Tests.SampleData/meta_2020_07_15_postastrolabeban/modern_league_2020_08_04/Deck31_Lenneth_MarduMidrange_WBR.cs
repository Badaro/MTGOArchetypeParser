using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_04
{
    public class Deck31_Lenneth_MarduMidrange_WBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Kaya, Orzhov Usurper"),
            new SampleCard(3, "Liliana of the Veil"),
            new SampleCard(3, "Nahiri, the Harbinger"),
            new SampleCard(1, "Emrakul, the Aeons Torn"),
            new SampleCard(3, "Kroxa, Titan of Death's Hunger"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(1, "Lingering Souls"),
            new SampleCard(1, "Thoughtseize"),
            new SampleCard(3, "Cling to Dust"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(1, "Kaya's Guile"),
            new SampleCard(1, "Kolaghan's Command"),
            new SampleCard(3, "Lightning Bolt"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(1, "Terminate"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(2, "Blackcleave Cliffs"),
            new SampleCard(2, "Blood Crypt"),
            new SampleCard(3, "Bloodstained Mire"),
            new SampleCard(2, "Concealed Courtyard"),
            new SampleCard(2, "Godless Shrine"),
            new SampleCard(4, "Marsh Flats"),
            new SampleCard(1, "Mountain"),
            new SampleCard(1, "Plains"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(2, "Shambling Vent"),
            new SampleCard(1, "Silent Clearing"),
            new SampleCard(2, "Swamp") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Anger of the Gods"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Damnation"),
            new SampleCard(3, "Fulminator Mage"),
            new SampleCard(3, "Lightning Helix"),
            new SampleCard(3, "Rest in Peace"),
            new SampleCard(2, "Wear // Tear") 
        };
    }
}