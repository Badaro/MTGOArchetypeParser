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
#01 kanister: Omnath Saheeli (WURG, Jegantha)
#02 taruto1212: WURG Control (WURG)
#03 NosonosaN: WURG Control (WURG)
#04 coert: Heliod Combo (WG)
#05 Danker: Azorius Control (WU)
#06 pmk: Humans (WUBRG)
#07 Wyern: Belcher (RG)
#08 Vansguy: WURG Control (WURG)
#09 Jack_Kashtan: Ad Nauseam (WUB)
#10 Mateusf34: E Tron (C)
#11 axk2: Neobrand (UG)
#12 Ajani89: KGC Amulet Titan (RG)
#13 JustJack: Humans (WUBRG)
#14 drVendigo: Jund Midrange (BRG)
#15 excel0679: Obosh Aggro (R, Obosh)
#16 nedyahiske: WURG Control (WURG)
#17 Rav104: Shadow Prowess (BR, Lurrus)
#18 WeareVenom: WURG Control (WURG)
#19 Kurusu: Kiki Chord (WRG, Yorion)
#20 FriskiFraska: Mono White Taxes (W)
#21 Tiemuuu: Izzet Control (UR)
#22 Karnesis93: Amulet Titan (UG)
#23 hawnkable: Gifts Storm (UR)
#24 NorrathDecay: E Tron (C)
#25 staffmat1992: Bant Spirits (WUG)
#26 ZYURYO: WURG Control (WURG)
#27 SebastianStueckl: Mono White Taxes (W)
#28 Rinko: Enduring Ideal (WR)
#29 josetorr87: Reclaimer Titan (WRG)
#30 Delthar: Infect (BG)
#31 Selami: Ad Nauseam (WUB)
#32 LORiWWA: E Tron (C)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_10_12 : EventTest
    {
        [Test]
        public void Deck01_kanister_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",0),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
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
        public void Deck12_Ajani89_KGCAmuletTitan_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",11),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
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
        public void Deck15_excel0679_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",14),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
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
        public void Deck22_Karnesis93_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",21),
                new PostZendikarRising(),
                ArchetypeColor.UG,
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
                null,
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
        public void Deck29_josetorr87_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-12",28),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
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
