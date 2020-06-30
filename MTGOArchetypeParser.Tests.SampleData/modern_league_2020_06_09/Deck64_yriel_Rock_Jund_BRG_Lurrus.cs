using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck64_yriel_Rock_Jund_BRG_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Dark Confidant"),
            new SampleCard(3, "Kroxa, Titan of Death's Hunger"),
            new SampleCard(3, "Scavenging Ooze"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(4, "Inquisition of Kozilek"),
            new SampleCard(4, "Thoughtseize"),
            new SampleCard(4, "Assassin's Trophy"),
            new SampleCard(4, "Kolaghan's Command"),
            new SampleCard(2, "Lightning Bolt"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(3, "Seal of Fire"),
            new SampleCard(4, "Blackcleave Cliffs"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(2, "Bloodstained Mire"),
            new SampleCard(1, "Copperline Gorge"),
            new SampleCard(1, "Nurturing Peatland"),
            new SampleCard(1, "Overgrown Tomb"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(1, "Twilight Mire"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Scavenging Ooze"),
            new SampleCard(3, "Collective Brutality"),
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(1, "Engineered Explosives"),
            new SampleCard(1, "Fatal Push"),
            new SampleCard(1, "Lurrus of the Dream Den"),
            new SampleCard(2, "Nature's Claim"),
            new SampleCard(3, "Nihil Spellbomb") 
        };
    }
}