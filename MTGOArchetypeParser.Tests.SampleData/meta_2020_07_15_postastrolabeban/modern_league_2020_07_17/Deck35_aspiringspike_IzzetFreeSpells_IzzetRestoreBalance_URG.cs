using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_17
{
    public class Deck35_aspiringspike_IzzetFreeSpells_IzzetRestoreBalance_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Greater Gargadon"),
            new SampleCard(3, "Simian Spirit Guide"),
            new SampleCard(4, "Ancestral Vision"),
            new SampleCard(4, "Crashing Footfalls"),
            new SampleCard(1, "Finale of Promise"),
            new SampleCard(4, "Restore Balance"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(4, "Electrodominance"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Opt"),
            new SampleCard(1, "Spell Pierce"),
            new SampleCard(4, "As Foretold"),
            new SampleCard(2, "Fiery Islet"),
            new SampleCard(1, "Gemstone Caverns"),
            new SampleCard(2, "Island"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(4, "Spirebluff Canal"),
            new SampleCard(2, "Steam Vents"),
            new SampleCard(1, "Stomping Ground") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Abrade"),
            new SampleCard(3, "Anger of the Gods"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(1, "Jace, the Mind Sculptor"),
            new SampleCard(4, "Leyline of Sanctity"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}