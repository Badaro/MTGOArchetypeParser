using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07
{
    public class Deck21_osmanozguney_Smallpox_B : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Liliana of the Veil"),
            new SampleCard(2, "Liliana, Waker of the Dead"),
            new SampleCard(3, "Murderous Rider"),
            new SampleCard(4, "Nether Spirit"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(4, "Smallpox"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(4, "Cling to Dust"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(2, "Ratchet Bomb"),
            new SampleCard(2, "Blast Zone"),
            new SampleCard(1, "Bloodstained Mire"),
            new SampleCard(3, "Castle Locthwain"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(1, "Marsh Flats"),
            new SampleCard(4, "Mutavault"),
            new SampleCard(1, "Polluted Delta"),
            new SampleCard(6, "Swamp"),
            new SampleCard(4, "Urborg, Tomb of Yawgmoth") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(2, "Damnation"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(1, "Night of Souls' Betrayal"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(2, "Plague Engineer"),
            new SampleCard(1, "Sorcerous Spyglass") 
        };
    }
}