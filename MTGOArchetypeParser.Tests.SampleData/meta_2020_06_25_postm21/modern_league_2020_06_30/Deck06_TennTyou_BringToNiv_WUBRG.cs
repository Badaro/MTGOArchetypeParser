using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_06_30
{
    public class Deck06_TennTyou_BringToNiv_WUBRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Nahiri, the Harbinger"),
            new SampleCard(2, "Teferi, Time Raveler"),
            new SampleCard(4, "Wrenn and Six"),
            new SampleCard(4, "Birds of Paradise"),
            new SampleCard(2, "Klothys, God of Destiny"),
            new SampleCard(3, "Niv-Mizzet Reborn"),
            new SampleCard(3, "Bring to Light"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(1, "Supreme Verdict"),
            new SampleCard(1, "Thought Erasure"),
            new SampleCard(1, "Unmoored Ego"),
            new SampleCard(3, "Assassin's Trophy"),
            new SampleCard(1, "Eladamri's Call"),
            new SampleCard(2, "Izzet Charm"),
            new SampleCard(3, "Kaya's Guile"),
            new SampleCard(1, "Kolaghan's Command"),
            new SampleCard(2, "Lightning Helix"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Godless Shrine"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(2, "Marsh Flats"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(4, "Pillar of the Paruns"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(3, "Verdant Catacombs"),
            new SampleCard(4, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Kolaghan's Command"),
            new SampleCard(1, "Unmoored Ego"),
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(1, "Boil"),
            new SampleCard(1, "Firespout"),
            new SampleCard(1, "Fulminator Mage"),
            new SampleCard(1, "Kaya, Orzhov Usurper"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(1, "Kunoros, Hound of Athreos"),
            new SampleCard(1, "Lavinia, Azorius Renegade"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}