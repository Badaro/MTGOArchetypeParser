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
#01 Bullz0Eye: E Tron (C)
#02 PTarts2win: Gruul Midrange (RG)
#03 tuhoajatane: Temur Control (URG)
#04 matiaskm: Devoted (WG, Lurrus)
#05 ZYURYO: Bant Control (WUG)
#06 Sodeq: Ad Nauseam (WUB)
#07 Lavaridge: Sultai Control (UBG)
#08 Ouranos139: Snoop Goblins (BR)
#09 Skrown: Dredge (BRG)
#10 iL_Tedesco: Jund Shadow (BRG)
#11 Diatomic: Bant Control (WUG)
#12 gazmon48: Mono Red Prowess (R, Jegantha)
#13 zecarlonxo: Mono Red Prowess (R)
#14 Ryan100495: Dredge (BRG)
#15 WeareVenom: Bant Control (WUG)
#16 TscheggschDePoegg: Temur Control (URG)
#17 aspiringspike: Izzet Control (UR)
#18 sff_mtg: Mono Red Prowess (R)
#19 ArchaeusDota: Bant Control (WUG, Yorion)
#20 Jenara19: Jund Midrange (BRG)
#21 bobthedog: Sultai Control (UBG)
#22 DreamsOfAshiok: E Tron (C)
#23 JB2002: Bant Control (WUG)
#24 renatoaraujo: E Tron (C)
#25 Blitzlion27: Mill (UB)
#26 PvtEnormous: Bant Control (WUG)
#27 HouseOfManaMTG: Amulet Titan (UG)
#28 nuikt: Grinding Breach (UBR)
#29 Laplasjan: Devoted (WG, Lurrus)
#30 Venom1: Sultai Control (UBG)
#31 Phil_Ivey: WURG Control (WURG, Yorion)
#32 SknerusMcKwacz: Snoop Goblins (BR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_challenge_2020_07_06 : EventTest
    {
        [Test]
        public void Deck01_Bullz0Eye_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",0),
                new PostM21(),
                ArchetypeColor.C,
                typeof(Tron),
typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck02_PTarts2win_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",1),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck03_tuhoajatane_TemurControl_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",2),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_matiaskm_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",3),
                new PostM21(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_ZYURYO_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",4),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Sodeq_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",5),
                new PostM21(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Lavaridge_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",6),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Ouranos139_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",7),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Skrown_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",8),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck10_iLTedesco_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",9),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Diatomic_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",10),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_gazmon48_MonoRedProwess_R_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",11),
                new PostM21(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck13_zecarlonxo_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",12),
                new PostM21(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Ryan100495_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",13),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck15_WeareVenom_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",14),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck16_TscheggschDePoegg_TemurControl_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",15),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_aspiringspike_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",16),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck18_sffmtg_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",17),
                new PostM21(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck19_ArchaeusDota_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",18),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck20_Jenara19_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",19),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck21_bobthedog_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",20),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck22_DreamsOfAshiok_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",21),
                new PostM21(),
                ArchetypeColor.C,
                typeof(Tron),
typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck23_JB2002_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",22),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck24_renatoaraujo_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",23),
                new PostM21(),
                ArchetypeColor.C,
                typeof(Tron),
typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck25_Blitzlion27_Mill_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",24),
                new PostM21(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck26_PvtEnormous_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",25),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_HouseOfManaMTG_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",26),
                new PostM21(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck28_nuikt_GrindingBreach_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",27),
                new PostM21(),
                ArchetypeColor.UBR,
                typeof(GrindingBreach),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",28),
                new PostM21(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_Venom1_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",29),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_PhilIvey_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",30),
                new PostM21(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck32_SknerusMcKwacz_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-06",31),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }


    }
}
