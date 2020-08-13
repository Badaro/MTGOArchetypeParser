using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07
{
    public class Deck03_busso9494_IzzetFreeSpells_IzzetRestoreBalance_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Greater Gargadon"),
            new SampleCard(4, "Simian Spirit Guide"),
            new SampleCard(3, "Ancestral Vision"),
            new SampleCard(4, "Crashing Footfalls"),
            new SampleCard(1, "Finale of Promise"),
            new SampleCard(4, "Restore Balance"),
            new SampleCard(3, "Serum Visions"),
            new SampleCard(1, "Abrade"),
            new SampleCard(1, "Echoing Truth"),
            new SampleCard(4, "Electrodominance"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(1, "Izzet Charm"),
            new SampleCard(3, "Lightning Bolt"),
            new SampleCard(3, "Opt"),
            new SampleCard(1, "Spell Pierce"),
            new SampleCard(1, "Spell Snare"),
            new SampleCard(4, "As Foretold"),
            new SampleCard(3, "Fiery Islet"),
            new SampleCard(3, "Scalding Tarn"),
            new SampleCard(1, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(4, "Spirebluff Canal"),
            new SampleCard(3, "Steam Vents"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(1, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(3, "Grafdigger's Cage"),
            new SampleCard(4, "Leyline of Sanctity"),
            new SampleCard(2, "Shattering Spree"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}