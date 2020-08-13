using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_07_23
{
    public class Deck09_yashimoro_DeathsShadow_EsperShadow_WUBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Death's Shadow"),
            new SampleCard(2, "Gurmag Angler"),
            new SampleCard(3, "Ranger-Captain of Eos"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(2, "Inquisition of Kozilek"),
            new SampleCard(4, "Serum Visions"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(1, "Unearth"),
            new SampleCard(1, "Cling to Dust"),
            new SampleCard(2, "Dismember"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(2, "Opt"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(3, "Stubborn Denial"),
            new SampleCard(1, "Temur Battle Rage"),
            new SampleCard(3, "Flooded Strand"),
            new SampleCard(1, "Godless Shrine"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(3, "Marsh Flats"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(2, "Silent Clearing"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Swamp"),
            new SampleCard(2, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Stubborn Denial"),
            new SampleCard(1, "Temur Battle Rage"),
            new SampleCard(1, "Celestial Purge"),
            new SampleCard(2, "Ceremonious Rejection"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(1, "Disenchant"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(1, "Gideon, Ally of Zendikar"),
            new SampleCard(3, "Leyline of the Void"),
            new SampleCard(2, "Lingering Souls"),
            new SampleCard(1, "Surgical Extraction") 
        };
    }
}