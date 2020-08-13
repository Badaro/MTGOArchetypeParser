using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_14
{
    public class Deck56_Julgrahn_RestoreBalance_WURG_Jegantha : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Teferi, Time Raveler"),
            new SampleCard(3, "Bonecrusher Giant"),
            new SampleCard(4, "Greater Gargadon"),
            new SampleCard(2, "Klothys, God of Destiny"),
            new SampleCard(4, "Simian Spirit Guide"),
            new SampleCard(3, "Restore Balance"),
            new SampleCard(3, "Generous Gift"),
            new SampleCard(3, "Supreme Will"),
            new SampleCard(4, "Violent Outburst"),
            new SampleCard(4, "Fieldmist Borderpost"),
            new SampleCard(1, "Firewild Borderpost"),
            new SampleCard(4, "Wildfield Borderpost"),
            new SampleCard(4, "Ardent Plea"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(2, "Arid Mesa"),
            new SampleCard(1, "Forest"),
            new SampleCard(1, "Island"),
            new SampleCard(1, "Mistveil Plains"),
            new SampleCard(1, "Mountain"),
            new SampleCard(1, "Plains"),
            new SampleCard(4, "Prismatic Vista"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(1, "Steam Vents"),
            new SampleCard(1, "Stomping Ground") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Blood Moon"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(1, "Detention Sphere"),
            new SampleCard(1, "Jegantha, the Wellspring"),
            new SampleCard(4, "Leyline of Sanctity"),
            new SampleCard(2, "Mystical Dispute"),
            new SampleCard(1, "Ricochet Trap"),
            new SampleCard(3, "Wear // Tear") 
        };
    }
}