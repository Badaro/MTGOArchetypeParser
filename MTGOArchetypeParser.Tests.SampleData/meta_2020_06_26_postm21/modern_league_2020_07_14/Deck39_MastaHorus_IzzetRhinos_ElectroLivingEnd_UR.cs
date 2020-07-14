using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_14
{
    public class Deck39_MastaHorus_IzzetRhinos_ElectroLivingEnd_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Curator of Mysteries"),
            new SampleCard(4, "Desert Cerodon"),
            new SampleCard(3, "Street Wraith"),
            new SampleCard(4, "Striped Riverwinder"),
            new SampleCard(4, "Crashing Footfalls"),
            new SampleCard(4, "Living End"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(4, "Electrodominance"),
            new SampleCard(4, "Force of Negation"),
            new SampleCard(4, "Remand"),
            new SampleCard(4, "As Foretold"),
            new SampleCard(1, "Cascade Bluffs"),
            new SampleCard(2, "Fiery Islet"),
            new SampleCard(3, "Island"),
            new SampleCard(2, "Mountain"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(4, "Spirebluff Canal"),
            new SampleCard(2, "Steam Vents"),
            new SampleCard(1, "Tolaria West") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Anger of the Gods"),
            new SampleCard(3, "Blood Moon"),
            new SampleCard(4, "Dragon's Claw"),
            new SampleCard(2, "Ingot Chewer"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(2, "Tormod's Crypt") 
        };
    }
}