using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_21
{
    public class Deck60_Albyz_IzzetFreeSpells_IzzetRestoreBalance_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Brazen Borrower"),
            new SampleCard(3, "Greater Gargadon"),
            new SampleCard(4, "Simian Spirit Guide"),
            new SampleCard(3, "Ancestral Vision"),
            new SampleCard(4, "Crashing Footfalls"),
            new SampleCard(1, "Finale of Promise"),
            new SampleCard(4, "Restore Balance"),
            new SampleCard(3, "Serum Visions"),
            new SampleCard(1, "Abrade"),
            new SampleCard(4, "Electrodominance"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(1, "Izzet Charm"),
            new SampleCard(3, "Lightning Bolt"),
            new SampleCard(3, "Opt"),
            new SampleCard(2, "Spell Snare"),
            new SampleCard(4, "As Foretold"),
            new SampleCard(3, "Fiery Islet"),
            new SampleCard(1, "Mountain"),
            new SampleCard(3, "Scalding Tarn"),
            new SampleCard(1, "Snow-Covered Island"),
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