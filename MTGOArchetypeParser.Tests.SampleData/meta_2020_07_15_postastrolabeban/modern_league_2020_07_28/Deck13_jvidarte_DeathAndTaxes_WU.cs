using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_28
{
    public class Deck13_jvidarte_DeathAndTaxes_WU : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Geist of Saint Traft"),
            new SampleCard(4, "Giver of Runes"),
            new SampleCard(4, "Leonin Arbiter"),
            new SampleCard(2, "Remorseful Cleric"),
            new SampleCard(2, "Selfless Savior"),
            new SampleCard(4, "Spell Queller"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Thalia, Guardian of Thraben"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Aether Vial"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(3, "Adarkar Wastes"),
            new SampleCard(1, "Eiganjo Castle"),
            new SampleCard(4, "Field of Ruin"),
            new SampleCard(4, "Ghost Quarter"),
            new SampleCard(1, "Island"),
            new SampleCard(2, "Plains"),
            new SampleCard(4, "Seachrome Coast"),
            new SampleCard(4, "Silent Clearing"),
            new SampleCard(2, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Geist of Saint Traft"),
            new SampleCard(2, "Remorseful Cleric"),
            new SampleCard(3, "Burrenton Forge-Tender"),
            new SampleCard(2, "Deputy of Detention"),
            new SampleCard(3, "Leonin Relic-Warder"),
            new SampleCard(2, "Phyrexian Revoker"),
            new SampleCard(2, "Tocatli Honor Guard") 
        };
    }
}