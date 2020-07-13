using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23
{
    public class Deck19_aspiringspike_GrixisLurrus_UBR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Lurrus of the Dream Den"),
            new SampleCard(3, "Snapcaster Mage"),
            new SampleCard(4, "Sprite Dragon"),
            new SampleCard(2, "Unearth"),
            new SampleCard(3, "Archmage's Charm"),
            new SampleCard(1, "Cling to Dust"),
            new SampleCard(2, "Drown in the Loch"),
            new SampleCard(4, "Force of Negation"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Mana Leak"),
            new SampleCard(2, "Spell Snare"),
            new SampleCard(4, "Thought Scour"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(1, "Seal of Fire"),
            new SampleCard(1, "Blood Crypt"),
            new SampleCard(3, "Darkslick Shores"),
            new SampleCard(2, "Island"),
            new SampleCard(4, "Polluted Delta"),
            new SampleCard(4, "Scalding Tarn"),
            new SampleCard(2, "Spirebluff Canal"),
            new SampleCard(2, "Steam Vents"),
            new SampleCard(3, "Watery Grave") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Seal of Fire"),
            new SampleCard(1, "Unearth"),
            new SampleCard(3, "Aether Gust"),
            new SampleCard(3, "Collective Brutality"),
            new SampleCard(1, "Fatal Push"),
            new SampleCard(2, "Flusterstorm"),
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(2, "Tormod's Crypt") 
        };
    }
}