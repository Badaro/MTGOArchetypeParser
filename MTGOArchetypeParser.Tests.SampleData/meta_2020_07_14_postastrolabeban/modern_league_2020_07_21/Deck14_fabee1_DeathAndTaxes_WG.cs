using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_21
{
    public class Deck14_fabee1_DeathAndTaxes_WG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Flickerwisp"),
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(1, "Selfless Savior"),
            new SampleCard(1, "Serra Avenger"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Thalia, Guardian of Thraben"),
            new SampleCard(3, "Voice of Resurgence"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(1, "Field of Ruin"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(3, "Horizon Canopy"),
            new SampleCard(4, "Razorverge Thicket"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(5, "Snow-Covered Plains"),
            new SampleCard(3, "Temple Garden"),
            new SampleCard(2, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Knight of Autumn"),
            new SampleCard(2, "Burrenton Forge-Tender"),
            new SampleCard(2, "Celestial Purge"),
            new SampleCard(1, "Collector Ouphe"),
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(1, "Gideon, Ally of Zendikar"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(1, "Scavenging Ooze") 
        };
    }
}