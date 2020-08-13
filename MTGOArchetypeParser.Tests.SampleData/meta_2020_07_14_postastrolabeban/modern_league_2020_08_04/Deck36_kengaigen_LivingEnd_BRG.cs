using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_04
{
    public class Deck36_kengaigen_LivingEnd_BRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Archfiend of Ifnir"),
            new SampleCard(4, "Desert Cerodon"),
            new SampleCard(2, "Faerie Macabre"),
            new SampleCard(3, "Fulminator Mage"),
            new SampleCard(4, "Horror of the Broken Lands"),
            new SampleCard(4, "Monstrous Carabid"),
            new SampleCard(4, "Simian Spirit Guide"),
            new SampleCard(4, "Street Wraith"),
            new SampleCard(4, "Demonic Dread"),
            new SampleCard(3, "Living End"),
            new SampleCard(3, "Beast Within"),
            new SampleCard(4, "Violent Outburst"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(1, "Blooming Marsh"),
            new SampleCard(1, "Forest"),
            new SampleCard(4, "Grove of the Burnwillows"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(2, "Swamp"),
            new SampleCard(4, "Verdant Catacombs") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Ashiok, Dream Render"),
            new SampleCard(2, "Brindle Boar"),
            new SampleCard(4, "Ingot Chewer"),
            new SampleCard(3, "Ricochet Trap"),
            new SampleCard(3, "Shriekmaw"),
            new SampleCard(1, "Thrun, the Last Troll") 
        };
    }
}