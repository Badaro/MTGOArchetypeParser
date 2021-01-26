using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 PTarts2win: Reclaimer Titan (WRG)
#02 Theo_Jung: Reclaimer Titan (WRG)
#03 cftsoc3: Bant Blink (WUG)
#04 Jaberwocki: Jund Midrange (BRG)
#05 Bruno_Mineiro: Jund Midrange (BRG, Lurrus)
#06 _a.c.a.i_2007_: Heliod Combo (WG)
#07 Mulldrifter: Shadow Prowess (WBR, Lurrus)
#08 Redgy: Jeskai Control (WUR)
#09 _Shatun_: Mono Red Prowess (R)
#10 waffl3haos: Mono White Taxes (W)
#11 Redgy819: Amulet Titan (G)
#12 EskimoJoe: Mono White Taxes (W)
#13 Xwhale: Reclaimer Titan (WRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_10_29 : EventTest
    {
        [Test]
        public void Deck01_PTarts2win_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-29",0),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck02_TheoJung_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-29",1),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck03_cftsoc3_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-29",2),
                "PostZendikarRising",
                ArchetypeColor.WUG,
                "GenericBlink",
                null,
                null
            );
        }

        [Test]
        public void Deck04_Jaberwocki_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-29",3),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck05_BrunoMineiro_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-29",4),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_acai2007_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-29",5),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Mulldrifter_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-29",6),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_Redgy_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-29",7),
                "PostZendikarRising",
                ArchetypeColor.WUR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Shatun_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-29",8),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck10_waffl3haos_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-29",9),
                "PostZendikarRising",
                ArchetypeColor.W,
                "Taxes",
                null,
                null
            );
        }

        [Test]
        public void Deck11_Redgy819_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-29",10),
                "PostZendikarRising",
                ArchetypeColor.G,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck12_EskimoJoe_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-29",11),
                "PostZendikarRising",
                ArchetypeColor.W,
                "Taxes",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Xwhale_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-29",12),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }


    }
}
