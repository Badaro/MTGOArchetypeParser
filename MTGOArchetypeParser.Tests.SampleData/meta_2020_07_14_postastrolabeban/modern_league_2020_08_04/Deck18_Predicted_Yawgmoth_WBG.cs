using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_04
{
    public class Deck18_Predicted_Yawgmoth_WBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Birds of Paradise"),
            new SampleCard(1, "Blood Artist"),
            new SampleCard(1, "Cavalier of Night"),
            new SampleCard(3, "Geralf's Messenger"),
            new SampleCard(1, "Noble Hierarch"),
            new SampleCard(1, "Phyrexian Revoker"),
            new SampleCard(4, "Strangleroot Geist"),
            new SampleCard(4, "Wall of Roots"),
            new SampleCard(4, "Yawgmoth, Thran Physician"),
            new SampleCard(4, "Young Wolf"),
            new SampleCard(4, "Eldritch Evolution"),
            new SampleCard(4, "Chord of Calling"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(3, "Blooming Marsh"),
            new SampleCard(1, "Dryad Arbor"),
            new SampleCard(2, "Forest"),
            new SampleCard(1, "Khalni Garden"),
            new SampleCard(1, "Nurturing Peatland"),
            new SampleCard(2, "Overgrown Tomb"),
            new SampleCard(1, "Swamp"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(4, "Twilight Mire"),
            new SampleCard(1, "Urborg, Tomb of Yawgmoth"),
            new SampleCard(4, "Verdant Catacombs") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(1, "Aven Mindcensor"),
            new SampleCard(1, "Collector Ouphe"),
            new SampleCard(1, "Eidolon of Rhetoric"),
            new SampleCard(1, "Grand Abolisher"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(2, "Leyline of Sanctity"),
            new SampleCard(1, "Plague Engineer"),
            new SampleCard(1, "Scavenging Ooze"),
            new SampleCard(1, "Thoughtseize"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(1, "Zulaport Cutthroat") 
        };
    }
}