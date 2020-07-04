using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_07_04
{
    public class Deck01_lilianaofthevess_SongStorm_URG_Jegantha : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Baral, Chief of Compliance"),
            new SampleCard(1, "Grapeshot"),
            new SampleCard(1, "Past in Flames"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(4, "Desperate Ritual"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(4, "Pyretic Ritual"),
            new SampleCard(4, "Thrill of Possibility"),
            new SampleCard(2, "Engineered Explosives"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(4, "Pentad Prism"),
            new SampleCard(1, "Aria of Flame"),
            new SampleCard(4, "Song of Creation"),
            new SampleCard(2, "Breeding Pool"),
            new SampleCard(3, "Flooded Strand"),
            new SampleCard(3, "Island"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(1, "Mystic Sanctuary"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(2, "Steam Vents"),
            new SampleCard(1, "Stomping Ground") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(2, "Abrade"),
            new SampleCard(2, "Cryptic Command"),
            new SampleCard(1, "Jegantha, the Wellspring"),
            new SampleCard(1, "Laboratory Maniac"),
            new SampleCard(2, "Lightning Bolt"),
            new SampleCard(4, "Veil of Summer"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}