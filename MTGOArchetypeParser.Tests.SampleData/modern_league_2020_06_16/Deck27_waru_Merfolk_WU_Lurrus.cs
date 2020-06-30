using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck27_waru_Merfolk_WU_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Benthic Biomancer"),
            new SampleCard(2, "Harbinger of the Tides"),
            new SampleCard(4, "Lord of Atlantis"),
            new SampleCard(4, "Master of the Pearl Trident"),
            new SampleCard(4, "Merfolk Trickster"),
            new SampleCard(4, "Silvergill Adept"),
            new SampleCard(4, "Unsettled Mariner"),
            new SampleCard(1, "Cryptic Command"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Spreading Seas"),
            new SampleCard(2, "Hallowed Fountain"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(4, "Mutavault"),
            new SampleCard(4, "Seachrome Coast"),
            new SampleCard(5, "Snow-Covered Island"),
            new SampleCard(4, "Wanderwine Hub") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Lurrus of the Dream Den"),
            new SampleCard(1, "Phyrexian Revoker"),
            new SampleCard(1, "Spellskite"),
            new SampleCard(2, "Stony Silence"),
            new SampleCard(4, "Tidebinder Mage"),
            new SampleCard(4, "Tormod's Crypt"),
            new SampleCard(2, "Wizard's Retort") 
        };
    }
}