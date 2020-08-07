using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_07
{
    public class Deck44_sepomon_Smallpox_WB : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Liliana of the Veil"),
            new SampleCard(4, "Bloodghast"),
            new SampleCard(2, "Haakon, Stromgald Scourge"),
            new SampleCard(2, "Murderous Rider"),
            new SampleCard(2, "Rankle, Master of Pranks"),
            new SampleCard(4, "Collective Brutality"),
            new SampleCard(3, "Inquisition of Kozilek"),
            new SampleCard(4, "Lingering Souls"),
            new SampleCard(4, "Smallpox"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(2, "Fatal Push"),
            new SampleCard(1, "Crucible of Worlds"),
            new SampleCard(1, "Castle Locthwain"),
            new SampleCard(2, "Fetid Heath"),
            new SampleCard(3, "Flagstones of Trokair"),
            new SampleCard(3, "Ghost Quarter"),
            new SampleCard(2, "Godless Shrine"),
            new SampleCard(2, "Marsh Flats"),
            new SampleCard(1, "Plains"),
            new SampleCard(2, "Shambling Vent"),
            new SampleCard(2, "Silent Clearing"),
            new SampleCard(3, "Snow-Covered Swamp"),
            new SampleCard(3, "Urborg, Tomb of Yawgmoth"),
            new SampleCard(2, "Nameless Inversion") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Crucible of Worlds"),
            new SampleCard(2, "Cry of the Carnarium"),
            new SampleCard(2, "Damnation"),
            new SampleCard(4, "Leyline of the Void"),
            new SampleCard(2, "Revoke Existence"),
            new SampleCard(2, "Stony Silence"),
            new SampleCard(2, "Surgical Extraction") 
        };
    }
}