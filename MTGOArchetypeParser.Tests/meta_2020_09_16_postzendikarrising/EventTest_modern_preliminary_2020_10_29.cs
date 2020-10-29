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
#01 PTarts2win: PrimevalTitan (WRG)
#02 Theo_Jung: PrimevalTitan (WRG)
#03 cftsoc3: BantBlink (WUG)
#04 Jaberwocki: JundMidrange (BRG)
#05 Bruno_Mineiro: JundMidrange (BRG, Lurrus)
#06 _a.c.a.i_2007_: HeliodCombo (WG)
#07 Mulldrifter: ShadowProwess (WBR, Lurrus)
#08 Redgy: JeskaiControl (WUR)
#09 _Shatun_: MonoRedProwess (R)
#10 waffl3haos: MonoWhiteTaxes (W)
#11 Redgy819: AmuletTitan (UBRG)
#12 EskimoJoe: MonoWhiteTaxes (W)
#13 Xwhale: PrimevalTitan (WRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_10_29 : EventTest
    {
        [Test]
        public void Deck01_PTarts2win_PrimevalTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-29",0),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck02_TheoJung_PrimevalTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-29",1),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck03_cftsoc3_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-29",2),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Jaberwocki_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-29",3),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_BrunoMineiro_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-29",4),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_acai2007_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-29",5),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Mulldrifter_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-29",6),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_Redgy_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-29",7),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Shatun_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-29",8),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck10_waffl3haos_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-29",9),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Redgy819_AmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-29",10),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck12_EskimoJoe_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-29",11),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Xwhale_PrimevalTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-29",12),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }


    }
}
