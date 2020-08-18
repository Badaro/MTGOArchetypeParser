using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck33_hizakura_Polymorph_RG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Koth of the Hammer"),
            new SampleCard(3, "Emrakul, the Aeons Torn"),
            new SampleCard(4, "Primeval Titan"),
            new SampleCard(4, "Explore"),
            new SampleCard(4, "Farseek"),
            new SampleCard(4, "Indomitable Creativity"),
            new SampleCard(4, "Search for Tomorrow"),
            new SampleCard(3, "Transmogrify"),
            new SampleCard(4, "Through the Breach"),
            new SampleCard(4, "Arid Mesa"),
            new SampleCard(3, "Bloodstained Mire"),
            new SampleCard(1, "Cinder Glade"),
            new SampleCard(3, "Dwarven Mine"),
            new SampleCard(1, "Field of the Dead"),
            new SampleCard(3, "Mountain"),
            new SampleCard(1, "Sheltered Thicket"),
            new SampleCard(2, "Snow-Covered Mountain"),
            new SampleCard(4, "Stomping Ground"),
            new SampleCard(2, "Valakut, the Molten Pinnacle"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Anger of the Gods"),
            new SampleCard(1, "Beast Within"),
            new SampleCard(2, "Boil"),
            new SampleCard(1, "Chandra, Awakened Inferno"),
            new SampleCard(2, "Force of Vigor"),
            new SampleCard(2, "Fry"),
            new SampleCard(1, "Thrun, the Last Troll"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}