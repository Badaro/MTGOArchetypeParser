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
#01 A22en: SultaiControl (UBG)
#02 122pablo: JeskaiAscendancy (WURG, Jegantha)
#03 _Stream: IzzetProwess (UR)
#04 indianpancake: SultaiControl (UBG)
#05 aManatease: ShadowProwess (WBR, Lurrus)
#06 HannoLee: JundShadow (BRG)
#07 NosonosaN: WURGControl (WURG)
#08 Bohnz: WURGControl (WURG)
#09 Turn1Vial: ShadowProwess (WBR, Lurrus)
#10 kokoko098: HeliodCombo (WBG)
#11 Sodeq: AdNauseam (WUB)
#12 ACG88: PrimevalTitan (WRG)
#13 Kazuga: ShadowProwess (WBR, Lurrus)
#14 Draccon136: MonoWhiteTaxes (W)
#15 ilsecco14: ShadowProwess (BR, Lurrus)
#16 medvedev: ShadowProwess (WBR, Lurrus)
#17 Oderus Urungus: PrimevalTitan (WRG)
#18 xElBonk: Humans (WUBRG)
#19 _Falcon_: IzzetProwess (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_10_06 : EventTest
    {
        [Test]
        public void Deck01_A22en_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-06",0),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_122pablo_JeskaiAscendancy_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-06",1),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(JeskaiAscendancy),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck03_Stream_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-06",2),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck04_indianpancake_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-06",3),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_aManatease_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-06",4),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_HannoLee_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-06",5),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck07_NosonosaN_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-06",6),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Bohnz_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-06",7),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Turn1Vial_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-06",8),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_kokoko098_HeliodCombo_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-06",9),
                new PostZendikarRising(),
                ArchetypeColor.WBG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Sodeq_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-06",10),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck12_ACG88_PrimevalTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-06",11),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck13_Kazuga_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-06",12),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_Draccon136_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-06",13),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck15_ilsecco14_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-06",14),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_medvedev_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-06",15),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_OderusUrungus_PrimevalTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-06",16),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck18_xElBonk_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-06",17),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck19_Falcon_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-06",18),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }


    }
}
