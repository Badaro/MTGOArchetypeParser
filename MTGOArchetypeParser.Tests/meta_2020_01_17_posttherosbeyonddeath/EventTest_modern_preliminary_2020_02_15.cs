using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Dafne17: Gruul Midrange (RG)
#02 exoticherman: Infect (UG)
#03 Marxelo: Humans (WUBRG)
#04 bntrusty14: Mardu Midrange (WBR)
#05 bradyoo: Green Tron (G)
#06 ZYURYO: Azorius Control (WU)
#07 _goblinlackey: Green Tron (G)
#08 tia05: Primeval Titan (RG)
#09 3HDgamers: Eldrazi Tron (G)
#10 crazy_c_403: Orzhov Taxes (WB)
#11 SourceOdin: Amulet Titan (UG)
#12 sandydogmtg: Burn (R)
#13 PRGJJAR: Dredge (BRG)
#14 Tyerube1618: Gifts Storm (UR)
#15 Finalnub: Neobrand (UG)
#16 GutsMTG: Taking Turns (UR)
#17 Punkah: Humans (WUBRG)
#18 JustBurn420: Burn (WBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_02_15 : EventTest
    {
        [Test]
        public void Deck01_Dafne17_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-15",0),
                new PostTherosBeyondDeath(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck02_exoticherman_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-15",1),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Marxelo_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-15",2),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck04_bntrusty14_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-15",3),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_bradyoo_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-15",4),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck06_ZYURYO_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-15",5),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_goblinlackey_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-15",6),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck08_tia05_PrimevalTitan_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-15",7),
                new PostTherosBeyondDeath(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck09_3HDgamers_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-15",8),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck10_crazyc403_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-15",9),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WB,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck11_SourceOdin_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-15",10),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck12_sandydogmtg_Burn_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-15",11),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck13_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-15",12),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Tyerube1618_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-15",13),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Finalnub_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-15",14),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck16_GutsMTG_TakingTurns_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-15",15),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UR,
                typeof(TakingTurns),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Punkah_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-15",16),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck18_JustBurn420_Burn_WBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-15",17),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WBRG,
                typeof(Burn),
                null,
                null
            );
        }


    }
}
