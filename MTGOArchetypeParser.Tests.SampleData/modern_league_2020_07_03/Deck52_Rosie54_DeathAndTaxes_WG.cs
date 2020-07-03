using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_03
{
    public class Deck52_Rosie54_DeathAndTaxes_WG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Birds of Paradise"),
            new SampleCard(2, "Brimaz, King of Oreskos"),
            new SampleCard(3, "Leonin Arbiter"),
            new SampleCard(3, "Pride Sovereign"),
            new SampleCard(3, "Qasali Ambusher"),
            new SampleCard(3, "Qasali Pridemage"),
            new SampleCard(1, "Regal Caracal"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(3, "Thalia, Guardian of Thraben"),
            new SampleCard(2, "Collected Company"),
            new SampleCard(3, "Mana Tithe"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(1, "Castle Ardenvale"),
            new SampleCard(1, "Dryad Arbor"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(2, "Horizon Canopy"),
            new SampleCard(1, "Plains"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(2, "Snow-Covered Plains"),
            new SampleCard(1, "Stirring Wildwood"),
            new SampleCard(4, "Temple Garden"),
            new SampleCard(4, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aven Mindcensor"),
            new SampleCard(1, "Blessed Alliance"),
            new SampleCard(3, "Choke"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(3, "Rest in Peace"),
            new SampleCard(1, "Sword of Light and Shadow"),
            new SampleCard(1, "Vryn Wingmare"),
            new SampleCard(2, "Winds of Abandon") 
        };
    }
}