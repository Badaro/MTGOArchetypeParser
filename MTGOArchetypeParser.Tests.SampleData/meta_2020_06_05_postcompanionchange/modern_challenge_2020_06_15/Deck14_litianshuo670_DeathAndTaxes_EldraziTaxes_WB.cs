using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_15
{
    public class Deck14_litianshuo670_DeathAndTaxes_EldraziTaxes_WB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Kaya, Orzhov Usurper"),
            new SampleCard(2, "Charming Prince"),
            new SampleCard(4, "Eldrazi Displacer"),
            new SampleCard(4, "Flickerwisp"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(4, "Thalia, Guardian of Thraben"),
            new SampleCard(4, "Thought-Knot Seer"),
            new SampleCard(4, "Tidehollow Sculler"),
            new SampleCard(3, "Wasteland Strangler"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(4, "Caves of Koilos"),
            new SampleCard(4, "Concealed Courtyard"),
            new SampleCard(4, "Eldrazi Temple"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(3, "Plains"),
            new SampleCard(2, "Silent Clearing"),
            new SampleCard(1, "Swamp") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Kaya, Orzhov Usurper"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(1, "Gideon, Ally of Zendikar"),
            new SampleCard(2, "Kor Firewalker"),
            new SampleCard(1, "Kunoros, Hound of Athreos"),
            new SampleCard(1, "Orzhov Pontiff"),
            new SampleCard(3, "Rest in Peace"),
            new SampleCard(2, "Spirit of the Labyrinth"),
            new SampleCard(2, "Stony Silence") 
        };
    }
}