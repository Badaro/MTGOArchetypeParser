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
#01 Mcleskey: Humans (WUBRG)
#02 Xwhale: Reclaimer Titan (WRG)
#03 exoticherman: Jund Shadow (BRG)
#04 OptimusBro: Humans (WUBRG)
#05 DrDree: Shadow Prowess (BR, Lurrus)
#06 fingers1991: Shadow Prowess (BR, Lurrus)
#07 creepypasta: Mill (UB)
#08 SKK: Shadow Prowess (BR, Lurrus)
#09 BigPanda_559: Gruul Midrange (RG)
#10 JUJUBEAN__2004: UBRG Control (UBRG)
#11 rodeo: Burn (WR)
#12 waffl3haos: Mono White Taxes (W)
#13 yPrincipe: Eldrazi Tron (R)
#14 Lordzedane: Humans (WUBRG)
#15 2radMTG: Humans (WUBRG)
#16 hauterho: Obosh Aggro (R, Obosh)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_10_17 : EventTest
    {
        [Test]
        public void Deck01_Mcleskey_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-17",0),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Xwhale_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-17",1),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck03_exoticherman_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-17",2),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck04_OptimusBro_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-17",3),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck05_DrDree_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-17",4),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_fingers1991_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-17",5),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_creepypasta_Mill_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-17",6),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck08_SKK_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-17",7),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_BigPanda559_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-17",8),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck10_JUJUBEAN2004_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-17",9),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_rodeo_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-17",10),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck12_waffl3haos_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-17",11),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck13_yPrincipe_EldraziTron_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-17",12),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck14_Lordzedane_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-17",13),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck15_2radMTG_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-17",14),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck16_hauterho_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-17",15),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }


    }
}
