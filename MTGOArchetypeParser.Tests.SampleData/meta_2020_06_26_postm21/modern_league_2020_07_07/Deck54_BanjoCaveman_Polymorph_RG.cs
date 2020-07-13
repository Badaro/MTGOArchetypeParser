using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07
{
    public class Deck54_BanjoCaveman_Polymorph_RG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Emrakul, the Aeons Torn"),
            new SampleCard(4, "Primeval Titan"),
            new SampleCard(4, "Explore"),
            new SampleCard(4, "Farseek"),
            new SampleCard(4, "Indomitable Creativity"),
            new SampleCard(4, "Search for Tomorrow"),
            new SampleCard(3, "Transmogrify"),
            new SampleCard(1, "Lightning Bolt"),
            new SampleCard(4, "Through the Breach"),
            new SampleCard(3, "Arid Mesa"),
            new SampleCard(2, "Bloodstained Mire"),
            new SampleCard(3, "Dwarven Mine"),
            new SampleCard(3, "Mountain"),
            new SampleCard(3, "Scalding Tarn"),
            new SampleCard(1, "Sheltered Thicket"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(2, "Snow-Covered Mountain"),
            new SampleCard(4, "Stomping Ground"),
            new SampleCard(2, "Valakut, the Molten Pinnacle"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Lightning Bolt"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(2, "Boil"),
            new SampleCard(2, "Force of Vigor"),
            new SampleCard(3, "Veil of Summer"),
            new SampleCard(1, "Weather the Storm"),
            new SampleCard(2, "Wheel of Sun and Moon"),
            new SampleCard(1, "Wrenn and Six") 
        };
    }
}