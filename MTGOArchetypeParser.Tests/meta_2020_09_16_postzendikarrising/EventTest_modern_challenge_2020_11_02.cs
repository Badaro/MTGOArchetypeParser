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
#01 patheus_84: Ad Nauseam (WUB)
#02 ZYURYO: WURG Control (WURG)
#03 HouseOfManaMTG: Amulet Titan (RG)
#04 Mogged: Mono Red Prowess (R)
#05 _Batutinha_: Shadow Prowess (BR, Lurrus)
#06 shoktroopa: Blue Tron (U)
#07 Chefen: Gruul Midrange (RG)
#08 maxbv: Mono White Taxes (W)
#09 Blitzlion27: Mill (UB)
#10 Zar0s: UBRG Control (UBRG)
#11 KamiTech: Gruul Midrange (RG)
#12 MrRaeb: UBRG Control (UBRG, Yorion)
#13 __matsugan: Neobrand (UG)
#14 musasabi: Omnath Saheeli (WURG, Jegantha)
#15 Laplasjan: Devoted (WG, Lurrus)
#16 Kurusu: Kiki Chord (WRG, Yorion)
#17 pedrogush: Obosh Aggro (R, Obosh)
#18 NorrathDecay: Burn (WR)
#19 takuto8240: Azorius Control (WU)
#20 Chipsoss: Shadow Prowess (BRG, Lurrus)
#21 yPrincipe: Reclaimer Titan (WRG)
#22 Rinko: Enduring Ideal (WR)
#23 TuggaNaxos: Reclaimer Titan (WRG)
#24 HeisenOink: WURG Control (WURG)
#25 tibalt_of_red_sub: Mill (UB, Lurrus)
#26 Vansguy: WURG Control (WURG, Yorion)
#27 nahuel10: Izzet Prowess (UR)
#28 Samcaster-Mage: Eldrazi Tron (C)
#29 __BMJ__: Reclaimer Titan (WRG)
#30 Do0mSwitch: WURG Control (WURG)
#31 Coly2: Gruul Midrange (RG)
#32 SknerusMcKwacz: Obosh Aggro (R, Obosh)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_11_02 : EventTest
    {
        [Test]
        public void Deck01_patheus84_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",0),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck02_ZYURYO_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",1),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_HouseOfManaMTG_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",2),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck04_Mogged_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",3),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck05_Batutinha_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",4),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_shoktroopa_BlueTron_U()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",5),
                "PostZendikarRising",
                ArchetypeColor.U,
                "Tron",
                "BlueTron",
                null
            );
        }

        [Test]
        public void Deck07_Chefen_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",6),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck08_maxbv_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",7),
                "PostZendikarRising",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Blitzlion27_Mill_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",8),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "Mill",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Zar0s_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",9),
                "PostZendikarRising",
                ArchetypeColor.UBRG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck11_KamiTech_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",10),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck12_MrRaeb_UBRGControl_UBRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",11),
                "PostZendikarRising",
                ArchetypeColor.UBRG,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck13_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",12),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck14_musasabi_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",13),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                "OmnathSaheeli",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck15_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",14),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",15),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "KikiChord",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck17_pedrogush_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",16),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck18_NorrathDecay_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",17),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck19_takuto8240_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",18),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck20_Chipsoss_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",19),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_yPrincipe_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",20),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck22_Rinko_EnduringIdeal_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",21),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "EnduringIdeal",
                null,
                null
            );
        }

        [Test]
        public void Deck23_TuggaNaxos_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",22),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck24_HeisenOink_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",23),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck25_tibaltofredsub_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",24),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "Mill",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_Vansguy_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",25),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck27_nahuel10_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",26),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck28_SamcasterMage_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",27),
                "PostZendikarRising",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck29_BMJ_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",28),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck30_Do0mSwitch_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",29),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck31_Coly2_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",30),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck32_SknerusMcKwacz_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-11-02",31),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }


    }
}
