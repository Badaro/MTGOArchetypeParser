using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_11
{
    public class Deck57_kaktusowysmok_Merfolk_U : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Brazen Borrower"),
            new SampleCard(2, "Harbinger of the Tides"),
            new SampleCard(4, "Lord of Atlantis"),
            new SampleCard(4, "Master of the Pearl Trident"),
            new SampleCard(2, "Master of Waves"),
            new SampleCard(4, "Merfolk Trickster"),
            new SampleCard(4, "Merrow Reejerey"),
            new SampleCard(4, "Silvergill Adept"),
            new SampleCard(1, "Thassa, God of the Sea"),
            new SampleCard(2, "Dismember"),
            new SampleCard(1, "Force of Negation"),
            new SampleCard(2, "Spell Pierce"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Spreading Seas"),
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(11, "Island"),
            new SampleCard(1, "Minamo, School at Water's Edge"),
            new SampleCard(4, "Mutavault"),
            new SampleCard(1, "Oboro, Palace in the Clouds"),
            new SampleCard(2, "Waterlogged Grove") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Force of Negation"),
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(2, "Chalice of the Void"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Deprive"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(2, "Tidebinder Mage"),
            new SampleCard(1, "Venser, Shaper Savant") 
        };
    }
}