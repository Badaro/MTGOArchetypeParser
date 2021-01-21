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
#02 Adam_Hen: Jund Midrange (BRG, Lurrus)
#03 Gsy: Boros Prowess (WR, Lurrus)
#04 ColletClow: Burn (WR, Lurrus)
#05 SknerusMcKwacz: Boros Prowess (WR, Lurrus)
#06 tabulartony1: Bant Control (WUG)
#07 Larry11: Devoted (WG, Lurrus)
#08 Kenzaburo: Abzan Midrange (WBG, Lurrus)
#09 shellington5385: Boros Prowess (WR, Lurrus)
#10 C_E.L: 5 C Midrange (WUBRG, Umori)
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
#23 Shorak123: Sultai Reclamation (UBG)
#24 ZYURYO: WURG Control (WURG, Yorion)
#25 MrZarukai: Gruul Midrange (RG, Obosh)
#26 azatoyellow: Izzet Control (UR, Lutri)
#27 NorrathDecay: Green Tron (G)
#28 mitchieee: Orzhov Taxes (WB, Lurrus)
#29 Biednarccio: Amulet Titan (RG)
#30 Louisbach: Zirda Combo (WBG, Zirda)
#31 Naisirc: Mono White Taxes (W)
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
                new PostIkoria(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck02_AdamHen_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",1),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_Gsy_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",2),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_ColletClow_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",3),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_SknerusMcKwacz_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",4),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_tabulartony1_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",5),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Larry11_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",6),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_Kenzaburo_AbzanMidrange_WBG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",7),
                new PostIkoria(),
                ArchetypeColor.WBG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_shellington5385_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",8),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_CEL_5CMidrange_WUBRG_Umori()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",9),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Umori
            );
        }

        [Test]
        public void Deck11_Butakov_Humans_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",10),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck12_coert_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",11),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_CitrusD_HammerTime_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",12),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",13),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_Jadecavy_KinnanLegends_WUG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",14),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(KinnanLegends),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck16_Tenshi_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",15),
                new PostIkoria(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck17_kaikalbuquerque_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",16),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_triosk_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",17),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_bcs8995_GrixisShadow_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",18),
                new PostIkoria(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_ImmanuelKantrolGod_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",19),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck21_ziofrancone_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",20),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck22_aps_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",21),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck23_Shorak123_SultaiReclamation_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",22),
                new PostIkoria(),
                ArchetypeColor.UBG,
                typeof(Reclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck24_ZYURYO_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",23),
                new PostIkoria(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck25_MrZarukai_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",24),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck26_azatoyellow_IzzetControl_UR_Lutri()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",25),
                new PostIkoria(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Lutri
            );
        }

        [Test]
        public void Deck27_NorrathDecay_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",26),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck28_mitchieee_OrzhovTaxes_WB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",27),
                new PostIkoria(),
                ArchetypeColor.WB,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_Biednarccio_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",28),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck30_Louisbach_ZirdaCombo_WBG_Zirda()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",29),
                new PostIkoria(),
                ArchetypeColor.WBG,
                typeof(ZirdaCombo),
                null,
                ArchetypeCompanion.Zirda
            );
        }

        [Test]
        public void Deck31_Naisirc_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",30),
                new PostIkoria(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck32_XxShuicunexX_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-04",31),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
