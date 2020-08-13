using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_preliminary_2020_07_01
{
    public class Deck01_PaengPaeng_Merfolk_U : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Benthic Biomancer"),
            new SampleCard(4, "Harbinger of the Tides"),
            new SampleCard(4, "Lord of Atlantis"),
            new SampleCard(4, "Master of the Pearl Trident"),
            new SampleCard(4, "Merfolk Trickster"),
            new SampleCard(4, "Merrow Reejerey"),
            new SampleCard(4, "Silvergill Adept"),
            new SampleCard(3, "Dismember"),
            new SampleCard(2, "Spell Pierce"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Spreading Seas"),
            new SampleCard(1, "Castle Vantress"),
            new SampleCard(12, "Island"),
            new SampleCard(1, "Minamo, School at Water's Edge"),
            new SampleCard(4, "Mutavault"),
            new SampleCard(1, "Oboro, Palace in the Clouds") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Aether Gust"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(3, "Damping Matrix"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Deprive"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Kira, Great Glass-Spinner"),
            new SampleCard(1, "Relic of Progenitus"),
            new SampleCard(2, "Tidebinder Mage") 
        };
    }
}