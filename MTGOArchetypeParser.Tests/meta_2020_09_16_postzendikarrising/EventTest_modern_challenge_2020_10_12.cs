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
#01 kanister: SaheeliCombo (WURG, Jegantha)
#02 taruto1212: WURGControl (WURG)
#03 NosonosaN: WURGControl (WURG)
#04 coert: HeliodCombo (WG)
#05 Danker: AzoriusControl (WU)
#06 pmk: Humans (WUBRG)
#07 Wyern: Belcher (RG)
#08 Vansguy: WURGControl (WURG)
#09 Jack_Kashtan: AdNauseam (WUB)
#10 Mateusf34: ETron (C)
#11 axk2: Neobrand (UG)
#12 Ajani89: KGCAmuletTitan (WURG)
#13 JustJack: Humans (WUBRG)
#14 drVendigo: JundMidrange (BRG)
#15 excel0679: MonoRedProwess (R, Obosh)
#16 nedyahiske: WURGControl (WURG)
#17 Rav104: ShadowProwess (BR, Lurrus)
#18 WeareVenom: WURGControl (WURG)
#19 Kurusu: KikiChord (WRG, Yorion)
#20 FriskiFraska: MonoWhiteTaxes (W)
#21 Tiemuuu: IzzetControl (UR)
#22 Karnesis93: AmuletTitan (WUBRG)
#23 hawnkable: GiftsStorm (UR)
#24 NorrathDecay: ETron (C)
#25 staffmat1992: BantSpirits (WUG)
#26 ZYURYO: WURGControl (WURG)
#27 SebastianStueckl: MonoWhiteTaxes (W)
#28 Rinko: EnduringIdeal (WR)
#29 josetorr87: PrimevalTitan (WRG)
#30 Delthar: Infect (BG)
#31 Selami: AdNauseam (WUB)
#32 LORiWWA: ETron (C)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_10_12 : EventTest
    {
        [Test]
        public void Deck01_kanister_SaheeliCombo_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",0),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck02_taruto1212_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",1),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_NosonosaN_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",2),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_coert_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",3),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Danker_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",4),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_pmk_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",5),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Wyern_Belcher_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",6),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Vansguy_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",7),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_JackKashtan_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",8),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Mateusf34_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",9),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck11_axk2_Neobrand_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",10),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Ajani89_KGCAmuletTitan_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",11),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck13_JustJack_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",12),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck14_drVendigo_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",13),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck15_excel0679_MonoRedProwess_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",14),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck16_nedyahiske_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",15),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Rav104_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",16),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_WeareVenom_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",17),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck19_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",18),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck20_FriskiFraska_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",19),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",20),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Karnesis93_AmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",21),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck23_hawnkable_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",22),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck24_NorrathDecay_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",23),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck25_staffmat1992_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",24),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck26_ZYURYO_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",25),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_SebastianStueckl_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",26),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Rinko_EnduringIdeal_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",27),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(EnduringIdeal),
                null,
                null
            );
        }

        [Test]
        public void Deck29_josetorr87_PrimevalTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",28),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Delthar_Infect_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",29),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Selami_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",30),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck32_LORiWWA_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",31),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }


    }
}
