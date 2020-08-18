using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck53_SpikeYou_IzzetFreeSpells_IzzetRestoreBalance_UR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Brazen Borrower"),
            new SampleCard(3, "Greater Gargadon"),
            new SampleCard(4, "Simian Spirit Guide"),
            new SampleCard(3, "Ancestral Vision"),
            new SampleCard(4, "Crashing Footfalls"),
            new SampleCard(4, "Restore Balance"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(2, "Abrade"),
            new SampleCard(4, "Electrodominance"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(3, "Lightning Bolt"),
            new SampleCard(3, "Opt"),
            new SampleCard(4, "As Foretold"),
            new SampleCard(3, "Cascade Bluffs"),
            new SampleCard(3, "Fiery Islet"),
            new SampleCard(1, "Minamo, School at Water's Edge"),
            new SampleCard(1, "Mountain"),
            new SampleCard(1, "Oboro, Palace in the Clouds"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(4, "Spirebluff Canal"),
            new SampleCard(4, "Temple of Epiphany") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Anger of the Gods"),
            new SampleCard(2, "Boil"),
            new SampleCard(4, "Leyline of Sanctity"),
            new SampleCard(4, "Madcap Experiment"),
            new SampleCard(2, "Platinum Emperion") 
        };
    }
}