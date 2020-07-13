using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_03
{
    public class Deck17_npercario_ElectroBalance_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Greater Gargadon"),
            new SampleCard(3, "Simian Spirit Guide"),
            new SampleCard(4, "Ancestral Vision"),
            new SampleCard(4, "Crashing Footfalls"),
            new SampleCard(4, "Restore Balance"),
            new SampleCard(2, "Abrade"),
            new SampleCard(4, "Electrodominance"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(3, "Lightning Bolt"),
            new SampleCard(4, "Opt"),
            new SampleCard(4, "Remand"),
            new SampleCard(3, "As Foretold"),
            new SampleCard(1, "Cascade Bluffs"),
            new SampleCard(2, "Fiery Islet"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(2, "Island"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(3, "Spirebluff Canal"),
            new SampleCard(2, "Steam Vents") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Alpine Moon"),
            new SampleCard(3, "Anger of the Gods"),
            new SampleCard(2, "Flusterstorm"),
            new SampleCard(3, "Madcap Experiment"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(1, "Platinum Emperion") 
        };
    }
}