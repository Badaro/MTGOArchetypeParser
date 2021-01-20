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
#01 ZYURYO: Jund Midrange (BRG)
#02 Darkiundsa: Bant Control (WUG, Yorion)
#03 TSPJendrek: Sultai Control (UBG)
#04 LORiWWA: Eldrazi Tron (C)
#05 A22en: Azorius Control (WU)
#06 Busterbrown52: Elementals (WUBRG)
#07 Shorak123: Sultai Control (UBG)
#08 1yo2yo: Thopter Urza (UBR)
#09 TheTunnelingCat: Eldrazi Tron (C)
#10 Zxrogue: UBRG Shadow (UBRG)
#11 bobthedog: Sultai Control (UBG)
#12 PvtEnormous: Sultai Control (UBG)
#13 TerminalJustice: Gifts Storm (UR)
#14 katoriarch123: Bant Control (WUG)
#15 hdyer: Eldrazi Tron (C)
#16 yamakiller: Eldrazi Tron (C)
#17 renatoaraujo: Eldrazi Tron (C)
#18 HouseOfManaMTG: Amulet Titan (UG)
#19 indianpancake: Devoted (WG, Lurrus)
#20 Sodeq: Ad Nauseam (WUB)
#21 ManuelJacob: Bant Control (WUG)
#22 pbarrrgh: Temur Control (URG)
#23 MasterA: Goblins (BRG)
#24 Graciasportanto: Dredge (WBRG)
#25 Lord_Beerus: Burn (WR)
#26 Mzfroste: Goblins (BR)
#27 Kuhb: Grinding Breach (WURG)
#28 D00mwake: Izzet Prowess (UR)
#29 tuhoajatane: Temur Control (URG)
#30 MadMaxErnst: UBRG Control (UBRG)
#31 SungilWang: Devoted (WG, Lurrus)
#32 Capitano_CL: Dredge (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_challenge_2020_07_05 : EventTest
    {
        [Test]
        public void Deck01_ZYURYO_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",0),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Darkiundsa_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",1),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck03_TSPJendrek_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",2),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_LORiWWA_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",3),
                new PostM21(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck05_A22en_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",4),
                new PostM21(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Busterbrown52_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",5),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Shorak123_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",6),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_1yo2yo_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",7),
                new PostM21(),
                ArchetypeColor.UBR,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck09_TheTunnelingCat_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",8),
                new PostM21(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck10_Zxrogue_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",9),
                new PostM21(),
                ArchetypeColor.UBRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck11_bobthedog_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",10),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_PvtEnormous_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",11),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_TerminalJustice_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",12),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck14_katoriarch123_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",13),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_hdyer_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",14),
                new PostM21(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck16_yamakiller_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",15),
                new PostM21(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck17_renatoaraujo_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",16),
                new PostM21(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck18_HouseOfManaMTG_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",17),
                new PostM21(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck19_indianpancake_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",18),
                new PostM21(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_Sodeq_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",19),
                new PostM21(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck21_ManuelJacob_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",20),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck22_pbarrrgh_TemurControl_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",21),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck23_MasterA_Goblins_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",22),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Graciasportanto_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",23),
                new PostM21(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck25_LordBeerus_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",24),
                new PostM21(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck26_Mzfroste_Goblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",25),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Kuhb_GrindingBreach_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",26),
                new PostM21(),
                ArchetypeColor.WURG,
                typeof(GrindingBreach),
                null,
                null
            );
        }

        [Test]
        public void Deck28_D00mwake_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",27),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck29_tuhoajatane_TemurControl_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",28),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck30_MadMaxErnst_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",29),
                new PostM21(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_SungilWang_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",30),
                new PostM21(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck32_CapitanoCL_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",31),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }


    }
}
