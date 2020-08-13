using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_24
{
    public class Deck60_GulDukat_Prowess_GruulProwess_RG_Jegantha : ISampleDeck
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
            new SampleCard(2, "Arid Mesa"),
            new SampleCard(4, "Copperline Gorge"),
            new SampleCard(3, "Mountain"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(3, "Stomping Ground"),
            new SampleCard(1, "Sunbaked Canyon"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Abrade"),
            new SampleCard(1, "Ancient Grudge"),
            new SampleCard(1, "Boil"),
            new SampleCard(1, "Choke"),
            new SampleCard(2, "Flame Slash"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Hazoret the Fervent"),
            new SampleCard(1, "Jegantha, the Wellspring"),
            new SampleCard(2, "Klothys, God of Destiny"),
            new SampleCard(1, "Magus of the Moon"),
            new SampleCard(2, "Tormod's Crypt") 
        };
    }
}