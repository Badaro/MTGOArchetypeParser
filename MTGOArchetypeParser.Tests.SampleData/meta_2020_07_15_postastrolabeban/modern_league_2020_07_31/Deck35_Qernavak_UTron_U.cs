using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_31
{
    public class Deck35_Qernavak_UTron_U : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Karn, the Great Creator"),
            new SampleCard(1, "Ulamog, the Ceaseless Hunger"),
            new SampleCard(2, "Walking Ballista"),
            new SampleCard(2, "Wurmcoil Engine"),
            new SampleCard(2, "Condescend"),
            new SampleCard(2, "Dismember"),
            new SampleCard(2, "Force of Negation"),
            new SampleCard(4, "Remand"),
            new SampleCard(2, "Repeal"),
            new SampleCard(4, "Thirst for Knowledge"),
            new SampleCard(4, "Expedition Map"),
            new SampleCard(3, "Mazemind Tome"),
            new SampleCard(2, "Talisman of Dominance"),
            new SampleCard(2, "Shark Typhoon"),
            new SampleCard(1, "Academy Ruins"),
            new SampleCard(1, "Arch of Orazca"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(3, "Island"),
            new SampleCard(3, "Snow-Covered Island"),
            new SampleCard(2, "Tolaria West"),
            new SampleCard(4, "Urza's Mine"),
            new SampleCard(4, "Urza's Power Plant"),
            new SampleCard(4, "Urza's Tower") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Walking Ballista"),
            new SampleCard(1, "Mazemind Tome"),
            new SampleCard(1, "Amulet of Safekeeping"),
            new SampleCard(2, "Ensnaring Bridge"),
            new SampleCard(1, "Liquimetal Coating"),
            new SampleCard(1, "Mindslaver"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(1, "Oblivion Stone"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(1, "Tormod's Crypt"),
            new SampleCard(1, "Torpor Orb"),
            new SampleCard(1, "Torrential Gearhulk") 
        };
    }
}