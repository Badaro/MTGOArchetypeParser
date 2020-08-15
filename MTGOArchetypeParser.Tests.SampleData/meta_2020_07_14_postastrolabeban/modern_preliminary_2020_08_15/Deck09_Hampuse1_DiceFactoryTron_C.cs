using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_15
{
    public class Deck09_Hampuse1_DiceFactoryTron_C : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(1, "Ugin, the Ineffable"),
            new SampleCard(4, "Coretapper"),
            new SampleCard(4, "Astral Cornucopia"),
            new SampleCard(4, "Chalice of the Void"),
            new SampleCard(3, "Ensnaring Bridge"),
            new SampleCard(4, "Everflowing Chalice"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(4, "Mazemind Tome"),
            new SampleCard(3, "Mystic Forge"),
            new SampleCard(1, "Sorcerous Spyglass"),
            new SampleCard(4, "Surge Node"),
            new SampleCard(1, "Welding Jar"),
            new SampleCard(2, "Blast Zone"),
            new SampleCard(1, "Buried Ruin"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(1, "Inventors' Fair"),
            new SampleCard(1, "Scavenger Grounds"),
            new SampleCard(4, "Urza's Mine"),
            new SampleCard(4, "Urza's Power Plant"),
            new SampleCard(4, "Urza's Tower"),
            new SampleCard(1, "Wastes") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(1, "Mystic Forge"),
            new SampleCard(1, "Sorcerous Spyglass"),
            new SampleCard(1, "Welding Jar"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(1, "Paradox Engine"),
            new SampleCard(1, "Relic of Progenitus"),
            new SampleCard(3, "Spatial Contortion"),
            new SampleCard(1, "Tormod's Crypt"),
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(1, "Witchbane Orb"),
            new SampleCard(1, "Wurmcoil Engine") 
        };
    }
}