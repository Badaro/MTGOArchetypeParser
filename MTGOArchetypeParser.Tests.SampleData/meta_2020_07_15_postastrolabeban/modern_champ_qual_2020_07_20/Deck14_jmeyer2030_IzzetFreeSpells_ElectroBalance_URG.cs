using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20
{
    public class Deck14_jmeyer2030_IzzetFreeSpells_ElectroBalance_URG : ISampleDeck
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
            new SampleCard(1, "Izzet Charm"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Opt"),
            new SampleCard(1, "Spell Pierce"),
            new SampleCard(4, "As Foretold"),
            new SampleCard(2, "Fiery Islet"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(4, "Spirebluff Canal"),
            new SampleCard(2, "Steam Vents"),
            new SampleCard(1, "Stomping Ground") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Abrade"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(4, "Madcap Experiment"),
            new SampleCard(1, "Platinum Emperion"),
            new SampleCard(4, "Veil of Summer") 
        };
    }
}