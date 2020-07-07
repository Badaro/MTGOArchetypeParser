using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_07
{
    public class Deck40_Musagete_DeathAndTaxes_EldraziTaxes_WB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Charming Prince"),
            new SampleCard(3, "Dark Confidant"),
            new SampleCard(4, "Eldrazi Displacer"),
            new SampleCard(4, "Flickerwisp"),
            new SampleCard(3, "Giver of Runes"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(1, "Luminous Broodmoth"),
            new SampleCard(1, "Spirit of the Labyrinth"),
            new SampleCard(2, "Thought-Knot Seer"),
            new SampleCard(3, "Tidehollow Sculler"),
            new SampleCard(3, "Wasteland Strangler"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Caves of Koilos"),
            new SampleCard(4, "Concealed Courtyard"),
            new SampleCard(4, "Eldrazi Temple"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(2, "Plains"),
            new SampleCard(3, "Silent Clearing"),
            new SampleCard(1, "Swamp") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Spirit of the Labyrinth"),
            new SampleCard(2, "Burrenton Forge-Tender"),
            new SampleCard(2, "Containment Priest"),
            new SampleCard(1, "Gideon, Ally of Zendikar"),
            new SampleCard(1, "Kambal, Consul of Allocation"),
            new SampleCard(1, "Kaya, Orzhov Usurper"),
            new SampleCard(1, "Kunoros, Hound of Athreos"),
            new SampleCard(3, "Plague Engineer"),
            new SampleCard(3, "Rest in Peace") 
        };
    }
}