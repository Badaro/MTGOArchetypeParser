using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_07_25
{
    public class Deck11_Toastxp_Prowess_GruulProwess_RG_Jegantha : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Abbot of Keral Keep"),
            new SampleCard(3, "Hooting Mandrills"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(4, "Light Up the Stage"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(4, "Seal of Fire"),
            new SampleCard(4, "Arid Mesa"),
            new SampleCard(4, "Copperline Gorge"),
            new SampleCard(3, "Mountain"),
            new SampleCard(3, "Stomping Ground"),
            new SampleCard(1, "Sunbaked Canyon"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Abrade"),
            new SampleCard(1, "Ancient Grudge"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(2, "Choke"),
            new SampleCard(2, "Flame Slash"),
            new SampleCard(1, "Jegantha, the Wellspring"),
            new SampleCard(2, "Klothys, God of Destiny"),
            new SampleCard(3, "Tormod's Crypt") 
        };
    }
}