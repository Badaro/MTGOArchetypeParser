using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_champ_qual_2020_07_27
{
    public class Deck23_MadRamon_WildernessReclamation_TemurReclamation_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Snapcaster Mage"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(1, "Expansion // Explosion"),
            new SampleCard(3, "Fact or Fiction"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Growth Spiral"),
            new SampleCard(3, "Lightning Bolt"),
            new SampleCard(1, "Nexus of Fate"),
            new SampleCard(4, "Remand"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(2, "Wilderness Reclamation"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(2, "Flooded Strand"),
            new SampleCard(2, "Ketria Triome"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(7, "Snow-Covered Island"),
            new SampleCard(1, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Aether Gust"),
            new SampleCard(3, "Ashiok, Dream Render"),
            new SampleCard(1, "Fry"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(1, "Sweltering Suns"),
            new SampleCard(3, "Veil of Summer"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}