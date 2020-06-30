using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21
{
    public class Deck19_Erik157751_ETron_C : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(2, "Ugin, the Ineffable"),
            new SampleCard(4, "Matter Reshaper"),
            new SampleCard(4, "Reality Smasher"),
            new SampleCard(4, "Simian Spirit Guide"),
            new SampleCard(4, "Thought-Knot Seer"),
            new SampleCard(3, "Walking Ballista"),
            new SampleCard(1, "All Is Dust"),
            new SampleCard(2, "Dismember"),
            new SampleCard(4, "Chalice of the Void"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(2, "Mind Stone"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(4, "Eldrazi Temple"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(1, "Scavenger Grounds"),
            new SampleCard(4, "Urza's Mine"),
            new SampleCard(4, "Urza's Power Plant"),
            new SampleCard(4, "Urza's Tower"),
            new SampleCard(2, "Wastes") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(1, "All Is Dust"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(2, "Spellskite"),
            new SampleCard(1, "Tormod's Crypt"),
            new SampleCard(1, "Torpor Orb"),
            new SampleCard(1, "Trinisphere"),
            new SampleCard(1, "Witchbane Orb"),
            new SampleCard(1, "Wurmcoil Engine") 
        };
    }
}