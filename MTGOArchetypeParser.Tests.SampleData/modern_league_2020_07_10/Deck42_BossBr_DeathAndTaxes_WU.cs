using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10
{
    public class Deck42_BossBr_DeathAndTaxes_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(2, "Deputy of Detention"),
            new SampleCard(3, "Flickerwisp"),
            new SampleCard(1, "Geist of Saint Traft"),
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(1, "Restoration Angel"),
            new SampleCard(4, "Spell Queller"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Thalia, Guardian of Thraben"),
            new SampleCard(1, "Unsettled Mariner"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(3, "Field of Ruin"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(3, "Hallowed Fountain"),
            new SampleCard(3, "Horizon Canopy"),
            new SampleCard(1, "Island"),
            new SampleCard(1, "Moorland Haunt"),
            new SampleCard(3, "Plains"),
            new SampleCard(4, "Seachrome Coast") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Deputy of Detention"),
            new SampleCard(1, "Geist of Saint Traft"),
            new SampleCard(1, "Unsettled Mariner"),
            new SampleCard(1, "Path to Exile"),
            new SampleCard(1, "Teferi, Time Raveler"),
            new SampleCard(1, "Aven Mindcensor"),
            new SampleCard(1, "Celestial Purge"),
            new SampleCard(2, "Kor Firewalker"),
            new SampleCard(2, "Phyrexian Revoker"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(1, "Settle the Wreckage"),
            new SampleCard(1, "Sword of Light and Shadow") 
        };
    }
}