using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_28
{
    public class Deck70_Mistakenn_PrimevalTitan_AmuletTitan_URG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Arboreal Grazer"),
            new SampleCard(1, "Azusa, Lost but Seeking"),
            new SampleCard(4, "Dryad of the Ilysian Grove"),
            new SampleCard(2, "Emrakul, the Aeons Torn"),
            new SampleCard(2, "Fierce Empath"),
            new SampleCard(4, "Primeval Titan"),
            new SampleCard(2, "Explore"),
            new SampleCard(4, "Summoner's Pact"),
            new SampleCard(4, "Through the Breach"),
            new SampleCard(4, "Amulet of Vigor"),
            new SampleCard(1, "Bojuka Bog"),
            new SampleCard(3, "Castle Garenbrig"),
            new SampleCard(2, "Cavern of Souls"),
            new SampleCard(1, "Field of the Dead"),
            new SampleCard(2, "Forest"),
            new SampleCard(2, "Gemstone Mine"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(1, "Grove of the Burnwillows"),
            new SampleCard(4, "Gruul Turf"),
            new SampleCard(1, "Hanweir Battlements"),
            new SampleCard(1, "Radiant Fountain"),
            new SampleCard(4, "Simic Growth Chamber"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(2, "Tolaria West"),
            new SampleCard(2, "Valakut, the Molten Pinnacle"),
            new SampleCard(1, "Vesuva") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Abrade"),
            new SampleCard(2, "Beast Within"),
            new SampleCard(1, "Boseiju, Who Shelters All"),
            new SampleCard(2, "Firespout"),
            new SampleCard(2, "Fry"),
            new SampleCard(1, "Hornet Queen"),
            new SampleCard(2, "Negate"),
            new SampleCard(1, "Terastodon"),
            new SampleCard(1, "Tireless Tracker"),
            new SampleCard(1, "Wurmcoil Engine") 
        };
    }
}