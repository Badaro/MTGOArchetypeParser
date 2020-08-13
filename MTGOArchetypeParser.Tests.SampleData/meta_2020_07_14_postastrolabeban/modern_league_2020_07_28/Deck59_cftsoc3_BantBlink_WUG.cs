using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_28
{
    public class Deck59_cftsoc3_BantBlink_WUG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Charming Prince"),
            new SampleCard(3, "Deputy of Detention"),
            new SampleCard(4, "Eternal Witness"),
            new SampleCard(2, "Fblthp, the Lost"),
            new SampleCard(4, "Flickerwisp"),
            new SampleCard(1, "Meddling Mage"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(4, "Soulherder"),
            new SampleCard(1, "Uro, Titan of Nature's Wrath"),
            new SampleCard(4, "Watcher for Tomorrow"),
            new SampleCard(4, "Collected Company"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Canopy Vista"),
            new SampleCard(4, "Flooded Strand"),
            new SampleCard(1, "Forest"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(1, "Island"),
            new SampleCard(3, "Misty Rainforest"),
            new SampleCard(1, "Plains"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(4, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Meddling Mage"),
            new SampleCard(1, "Uro, Titan of Nature's Wrath"),
            new SampleCard(1, "Collector Ouphe"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(4, "Kor Firewalker"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(3, "Vedalken Plotter") 
        };
    }
}