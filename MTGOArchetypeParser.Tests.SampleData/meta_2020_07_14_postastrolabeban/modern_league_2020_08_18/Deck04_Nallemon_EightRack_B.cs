using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck04_Nallemon_EightRack_B : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Liliana of the Veil"),
            new SampleCard(1, "Nether Spirit"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(4, "Raven's Crime"),
            new SampleCard(4, "Smallpox"),
            new SampleCard(3, "Thoughtseize"),
            new SampleCard(3, "Wrench Mind"),
            new SampleCard(1, "Cling to Dust"),
            new SampleCard(1, "Dismember"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(1, "Funeral Charm"),
            new SampleCard(4, "The Rack"),
            new SampleCard(4, "Shrieking Affliction"),
            new SampleCard(4, "Castle Locthwain"),
            new SampleCard(2, "Marsh Flats"),
            new SampleCard(4, "Mutavault"),
            new SampleCard(9, "Swamp"),
            new SampleCard(4, "Urborg, Tomb of Yawgmoth") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Bontu's Last Reckoning"),
            new SampleCard(2, "Collective Brutality"),
            new SampleCard(3, "Delirium Skeins"),
            new SampleCard(1, "Murderous Rider"),
            new SampleCard(1, "Pithing Needle"),
            new SampleCard(1, "Plague Engineer"),
            new SampleCard(2, "Ratchet Bomb"),
            new SampleCard(2, "Rotting Regisaur") 
        };
    }
}