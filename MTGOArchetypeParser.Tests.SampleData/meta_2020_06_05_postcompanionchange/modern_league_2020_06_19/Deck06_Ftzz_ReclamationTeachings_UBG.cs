using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_19
{
    public class Deck06_Ftzz_ReclamationTeachings_UBG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ice-Fang Coatl"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(1, "Abrupt Decay"),
            new SampleCard(1, "Assassin's Trophy"),
            new SampleCard(1, "Blue Sun's Zenith"),
            new SampleCard(4, "Cryptic Command"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(4, "Growth Spiral"),
            new SampleCard(1, "Logic Knot"),
            new SampleCard(3, "Mystical Teachings"),
            new SampleCard(1, "Nexus of Fate"),
            new SampleCard(4, "Opt"),
            new SampleCard(1, "Pulse of Murasa"),
            new SampleCard(4, "Remand"),
            new SampleCard(3, "Wilderness Reclamation"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(1, "Castle Vantress"),
            new SampleCard(2, "Creeping Tar Pit"),
            new SampleCard(1, "Field of Ruin"),
            new SampleCard(2, "Hinterland Harbor"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(1, "Mystic Sanctuary"),
            new SampleCard(3, "Polluted Delta"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(4, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(2, "Watery Grave"),
            new SampleCard(1, "Zagoth Triome") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Ice-Fang Coatl"),
            new SampleCard(1, "Fatal Push"),
            new SampleCard(2, "Aether Gust"),
            new SampleCard(1, "Ceremonious Rejection"),
            new SampleCard(1, "Consume the Meek"),
            new SampleCard(1, "Dispel"),
            new SampleCard(1, "Echoing Decay"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(1, "Ravenous Trap"),
            new SampleCard(1, "Surgical Extraction"),
            new SampleCard(1, "Veil of Summer"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}