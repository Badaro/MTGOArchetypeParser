using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_16
{
    public class Deck24_Ambaro15_WildernessReclamation_ReclamationTeachings_UBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Tamiyo, Collector of Tales"),
            new SampleCard(2, "Snapcaster Mage"),
            new SampleCard(3, "Uro, Titan of Nature's Wrath"),
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(2, "Archmage's Charm"),
            new SampleCard(1, "Blue Sun's Zenith"),
            new SampleCard(1, "Cling to Dust"),
            new SampleCard(3, "Cryptic Command"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(1, "Force of Negation"),
            new SampleCard(4, "Growth Spiral"),
            new SampleCard(2, "Mystical Teachings"),
            new SampleCard(1, "Nexus of Fate"),
            new SampleCard(3, "Opt"),
            new SampleCard(3, "Remand"),
            new SampleCard(3, "Wilderness Reclamation"),
            new SampleCard(3, "Breeding Pool"),
            new SampleCard(1, "Creeping Tar Pit"),
            new SampleCard(1, "Field of Ruin"),
            new SampleCard(2, "Forest"),
            new SampleCard(1, "Hinterland Harbor"),
            new SampleCard(5, "Island"),
            new SampleCard(2, "Misty Rainforest"),
            new SampleCard(2, "Mystic Sanctuary"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(1, "Swamp"),
            new SampleCard(1, "Watery Grave"),
            new SampleCard(1, "Zagoth Triome") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Aether Gust"),
            new SampleCard(1, "Ashiok, Dream Render"),
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(2, "Nihil Spellbomb"),
            new SampleCard(1, "Plague Engineer"),
            new SampleCard(3, "Veil of Summer"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}