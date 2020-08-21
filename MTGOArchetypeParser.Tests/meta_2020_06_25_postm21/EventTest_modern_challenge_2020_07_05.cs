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
#01 ZYURYO: Jund (BRG)
#02 Darkiundsa: SnowControl (WUG, Yorion)
#03 TSPJendrek: SultaiSnow (UBG)
#04 LORiWWA: ETron (C)
#05 A22en: Miracles (WU)
#06 Busterbrown52: Elementals (WUBRG)
#07 Shorak123: SnowReclamation (UBG)
#08 1yo2yo: ThopterUrza (UBR)
#09 TheTunnelingCat: ETron (C)
#10 Zxrogue: TraverseShadow (UBRG)
#11 bobthedog: SultaiSnow (UBG)
#12 PvtEnormous: SultaiSnow (UBG)
#13 TerminalJustice: GiftsStorm (UR)
#14 katoriarch123: SnowControl (WUG)
#15 hdyer: ETron (C)
#16 yamakiller: ETron (C)
#17 renatoaraujo: ETron (C)
#18 HouseOfManaMTG: AmuletTitan (WUBRG)
#19 indianpancake: Devoted (WG, Lurrus)
#20 Sodeq: AdNauseam (WUB)
#21 ManuelJacob: SnowControl (WUG)
#22 pbarrrgh: TemurSnow (URG)
#23 MasterA: SnoopGoblins (BRG)
#24 Graciasportanto: Dredge (WBRG)
#25 Lord_Beerus: Burn (WR)
#26 Mzfroste: SnoopGoblins (BR)
#27 Kuhb: GrindingBreach (WURG)
#28 D00mwake: IzzetProwess (UR)
#29 tuhoajatane: TemurSnow (URG)
#30 MadMaxErnst: SultaiSnow (UBRG)
#31 SungilWang: Devoted (WG, Lurrus)
#32 Capitano_CL: Dredge (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_challenge_2020_07_05 : EventTest
    {
        [Test]
        public void Deck01_ZYURYO_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",0),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck02_Darkiundsa_SnowControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",1),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck03_TSPJendrek_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",2),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck04_LORiWWA_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",3),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck05_A22en_AzoriusControl_Miracles_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",4),
                new PostM21(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(Miracles),
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
        public void Deck07_Shorak123_SnowControl_SnowReclamation_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",6),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SnowReclamation),
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
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck09_TheTunnelingCat_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",8),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Zxrogue_DeathsShadow_TraverseShadow_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",9),
                new PostM21(),
                ArchetypeColor.UBRG,
                typeof(DeathsShadow),
                typeof(TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck11_bobthedog_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",10),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck12_PvtEnormous_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",11),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
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
        public void Deck14_katoriarch123_SnowControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",13),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_hdyer_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",14),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck16_yamakiller_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",15),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck17_renatoaraujo_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",16),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck18_HouseOfManaMTG_PrimevalTitan_AmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",17),
                new PostM21(),
                ArchetypeColor.WUBRG,
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
        public void Deck21_ManuelJacob_SnowControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",20),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck22_pbarrrgh_SnowControl_TemurSnow_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",21),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(TemurSnow),
                null
            );
        }

        [Test]
        public void Deck23_MasterA_Goblins_SnoopGoblins_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",22),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Goblins),
                typeof(SnoopGoblins),
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
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Mzfroste_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",25),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
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
        public void Deck28_D00mwake_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",27),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck29_tuhoajatane_SnowControl_TemurSnow_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",28),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(TemurSnow),
                null
            );
        }

        [Test]
        public void Deck30_MadMaxErnst_SnowControl_SultaiSnow_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-05",29),
                new PostM21(),
                ArchetypeColor.UBRG,
                typeof(SnowControl),
                typeof(SultaiSnow),
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
