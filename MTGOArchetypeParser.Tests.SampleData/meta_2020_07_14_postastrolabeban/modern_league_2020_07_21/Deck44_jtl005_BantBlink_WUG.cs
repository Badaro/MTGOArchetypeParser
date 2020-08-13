using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_21
{
    public class Deck44_jtl005_BantBlink_WUG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Auriok Champion"),
            new SampleCard(4, "Charming Prince"),
            new SampleCard(3, "Deputy of Detention"),
            new SampleCard(2, "Fblthp, the Lost"),
            new SampleCard(4, "Flickerwisp"),
            new SampleCard(1, "Meddling Mage"),
            new SampleCard(4, "Militia Bugler"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(1, "Scavenging Ooze"),
            new SampleCard(4, "Soulherder"),
            new SampleCard(4, "Watcher for Tomorrow"),
            new SampleCard(4, "Collected Company"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(1, "Botanical Sanctum"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(2, "Razorverge Thicket"),
            new SampleCard(1, "Seachrome Coast"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Island"),
            new SampleCard(3, "Snow-Covered Plains"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(3, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Auriok Champion"),
            new SampleCard(2, "Meddling Mage"),
            new SampleCard(1, "Scavenging Ooze"),
            new SampleCard(1, "Collector Ouphe"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(2, "Remorseful Cleric"),
            new SampleCard(2, "Thalia, Guardian of Thraben"),
            new SampleCard(3, "Vedalken Plotter") 
        };
    }
}