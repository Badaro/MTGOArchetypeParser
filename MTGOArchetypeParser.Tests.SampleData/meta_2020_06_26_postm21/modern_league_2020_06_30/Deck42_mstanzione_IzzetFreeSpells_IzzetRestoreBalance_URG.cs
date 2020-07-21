using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_06_30
{
    public class Deck42_mstanzione_IzzetFreeSpells_IzzetRestoreBalance_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Greater Gargadon"),
            new SampleCard(4, "Simian Spirit Guide"),
            new SampleCard(3, "Ancestral Vision"),
            new SampleCard(4, "Crashing Footfalls"),
            new SampleCard(3, "Finale of Promise"),
            new SampleCard(4, "Restore Balance"),
            new SampleCard(3, "Serum Visions"),
            new SampleCard(4, "Electrodominance"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Izzet Charm"),
            new SampleCard(3, "Opt"),
            new SampleCard(2, "Spell Pierce"),
            new SampleCard(4, "As Foretold"),
            new SampleCard(1, "Bloodstained Mire"),
            new SampleCard(4, "Fiery Islet"),
            new SampleCard(1, "Island"),
            new SampleCard(1, "Mountain"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(4, "Spirebluff Canal"),
            new SampleCard(2, "Steam Vents"),
            new SampleCard(1, "Stomping Ground") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Force of Negation"),
            new SampleCard(3, "Abrade"),
            new SampleCard(4, "Goblin Rabblemaster"),
            new SampleCard(3, "Leyline of Sanctity"),
            new SampleCard(2, "Leyline of the Void"),
            new SampleCard(2, "Mystical Dispute") 
        };
    }
}