using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_07_17
{
    public class Deck07_SwordHunter_SaheeliCombo_SnowSaheeli_WURG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Jace, the Mind Sculptor"),
            new SampleCard(4, "Saheeli Rai"),
            new SampleCard(3, "Teferi, Time Raveler"),
            new SampleCard(4, "Birds of Paradise"),
            new SampleCard(4, "Felidar Guardian"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(1, "Yorion, Sky Nomad"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(3, "Lightning Bolt"),
            new SampleCard(3, "Spell Pierce"),
            new SampleCard(4, "Abundant Growth"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(4, "On Thin Ice"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(1, "Ketria Triome"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(2, "Prismatic Vista"),
            new SampleCard(3, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(2, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Blood Moon"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(2, "Knight of Autumn"),
            new SampleCard(1, "Oath of Chandra"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(2, "Stony Silence"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}