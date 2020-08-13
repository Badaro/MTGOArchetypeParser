using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_11
{
    public class Deck51_Waumpus_HeliodCombo_WUG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(4, "Birds of Paradise"),
            new SampleCard(1, "Eternal Witness"),
            new SampleCard(2, "Giver of Runes"),
            new SampleCard(4, "Heliod, Sun-Crowned"),
            new SampleCard(2, "Heliod's Pilgrim"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(2, "Ranger-Captain of Eos"),
            new SampleCard(3, "Spike Feeder"),
            new SampleCard(2, "Sylvan Caryatid"),
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(4, "Collected Company"),
            new SampleCard(4, "Eladamri's Call"),
            new SampleCard(2, "Freed from the Real"),
            new SampleCard(4, "Leyline of Abundance"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Dryad Arbor"),
            new SampleCard(2, "Forest"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(1, "Horizon Canopy"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(1, "Plains"),
            new SampleCard(2, "Temple Garden"),
            new SampleCard(4, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ranger-Captain of Eos"),
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(1, "Collector Ouphe"),
            new SampleCard(1, "Eidolon of Rhetoric"),
            new SampleCard(1, "Ensnaring Bridge"),
            new SampleCard(1, "Gaddock Teeg"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(1, "Shalai, Voice of Plenty"),
            new SampleCard(1, "Spellskite"),
            new SampleCard(1, "Tormod's Crypt"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(2, "Worship") 
        };
    }
}