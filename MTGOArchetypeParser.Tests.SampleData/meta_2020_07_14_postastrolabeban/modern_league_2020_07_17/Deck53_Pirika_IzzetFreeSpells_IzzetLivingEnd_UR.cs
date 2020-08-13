using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_17
{
    public class Deck53_Pirika_IzzetFreeSpells_IzzetLivingEnd_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Brazen Borrower"),
            new SampleCard(4, "Chancellor of the Annex"),
            new SampleCard(4, "Striped Riverwinder"),
            new SampleCard(4, "Waker of Waves"),
            new SampleCard(3, "Ancestral Vision"),
            new SampleCard(4, "Living End"),
            new SampleCard(2, "Electrodominance"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(4, "Izzet Charm"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "As Foretold"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(4, "Island"),
            new SampleCard(1, "Mountain"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(4, "Spirebluff Canal"),
            new SampleCard(3, "Steam Vents"),
            new SampleCard(2, "Tolaria West") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(3, "Madcap Experiment"),
            new SampleCard(2, "Platinum Emperion"),
            new SampleCard(2, "Teferi, Mage of Zhalfir") 
        };
    }
}