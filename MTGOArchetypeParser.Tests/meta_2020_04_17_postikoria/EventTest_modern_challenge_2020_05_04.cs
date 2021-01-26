using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 patheus_84: Ad Nauseam (WUB)
#02 Adam_Hen: Jund Midrange (BRG, Lurrus)
#03 Gsy: Boros Prowess (WR, Lurrus)
#04 ColletClow: Burn (WR, Lurrus)
#05 SknerusMcKwacz: Boros Prowess (WR, Lurrus)
#06 tabulartony1: Bant Control (WUG)
#07 Larry11: Devoted (WG, Lurrus)
#08 Kenzaburo: Abzan Midrange (WBG, Lurrus)
#09 shellington5385: Boros Prowess (WR, Lurrus)
#10 C_E.L: 5 Color Midrange (WUBRG, Umori)
#11 Butakov: Humans (WUBRG, Jegantha)
#12 coert: Burn (WR, Lurrus)
#13 CitrusD: Hammer Time (WR, Lurrus)
#14 Laplasjan: Devoted (WG, Lurrus)
#15 Jadecavy: Kinnan Legends (WUG, Yorion)
#16 Tenshi: Grixis Shadow (UBR)
#17 kaikalbuquerque: Bogles (WG, Lurrus)
#18 triosk: Jund Midrange (BRG, Lurrus)
#19 bcs8995: Grixis Shadow (UBR, Lurrus)
#20 ImmanuelKantrolGod: Bant Control (WUG)
#21 ziofrancone: Amulet Titan (UG)
#22 a_p_s: Burn (WR, Lurrus)
#23 Shorak123: Reclamation (UBG)
#24 ZYURYO: WURG Control (WURG, Yorion)
#25 MrZarukai: Gruul Midrange (RG, Obosh)
#26 azatoyellow: Izzet Control (UR, Lutri)
#27 NorrathDecay: Green Tron (G)
#28 mitchieee: Orzhov Taxes (WB, Lurrus)
#29 Biednarccio: Amulet Titan (RG)
#30 Louisbach: Zirda Combo (WBG, Zirda)
#31 Naisirc: Mono White Eldrazi Taxes (W)
#32 XxShuicunexX: Burn (WR, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_challenge_2020_05_04 : EventTest
    {
        [Test]
        public void Deck01_patheus84_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",0),
                "PostIkoria",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck02_AdamHen_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",1),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_Gsy_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",2),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_ColletClow_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",3),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_SknerusMcKwacz_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",4),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_tabulartony1_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",5),
                "PostIkoria",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Larry11_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",6),
                "PostIkoria",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_Kenzaburo_AbzanMidrange_WBG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",7),
                "PostIkoria",
                ArchetypeColor.WBG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_shellington5385_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",8),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_CEL_5ColorMidrange_WUBRG_Umori()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",9),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Umori
            );
        }

        [Test]
        public void Deck11_Butakov_Humans_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",10),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck12_coert_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",11),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_CitrusD_HammerTime_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",12),
                "PostIkoria",
                ArchetypeColor.WR,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",13),
                "PostIkoria",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_Jadecavy_KinnanLegends_WUG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",14),
                "PostIkoria",
                ArchetypeColor.WUG,
                "KinnanLegends",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck16_Tenshi_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",15),
                "PostIkoria",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck17_kaikalbuquerque_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",16),
                "PostIkoria",
                ArchetypeColor.WG,
                "Bogles",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_triosk_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",17),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_bcs8995_GrixisShadow_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",18),
                "PostIkoria",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_ImmanuelKantrolGod_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",19),
                "PostIkoria",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck21_ziofrancone_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",20),
                "PostIkoria",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck22_aps_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",21),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck23_Shorak123_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",22),
                "PostIkoria",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck24_ZYURYO_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",23),
                "PostIkoria",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck25_MrZarukai_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",24),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck26_azatoyellow_IzzetControl_UR_Lutri()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",25),
                "PostIkoria",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                ArchetypeCompanion.Lutri
            );
        }

        [Test]
        public void Deck27_NorrathDecay_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",26),
                "PostIkoria",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck28_mitchieee_OrzhovTaxes_WB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",27),
                "PostIkoria",
                ArchetypeColor.WB,
                "Taxes",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_Biednarccio_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",28),
                "PostIkoria",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck30_Louisbach_ZirdaCombo_WBG_Zirda()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",29),
                "PostIkoria",
                ArchetypeColor.WBG,
                "ZirdaCombo",
                null,
                ArchetypeCompanion.Zirda
            );
        }

        [Test]
        public void Deck31_Naisirc_MonoWhiteEldraziTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",30),
                "PostIkoria",
                ArchetypeColor.W,
                "Taxes",
                "EldraziTaxes",
                null
            );
        }

        [Test]
        public void Deck32_XxShuicunexX_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",31),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
