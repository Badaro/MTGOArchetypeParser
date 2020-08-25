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
#01 TSPJendrek: WUBGControl (WUBG)
#02 ZYURYO: WUBGControl (WUBG)
#03 JB2002: BantBlink (WUG, Yorion)
#04 Yanti: Humans (WUBRG)
#05 Blitzlion27: Mill (UB)
#06 AstralPlane: Burn (WR)
#07 SvenSvenSven: IzzetControl (UR)
#08 signblindman: GruulMidrange (RG)
#09 hugo87: GiftsStorm (UR)
#10 Tw33Ty: ETron (C)
#11 Cherryxman: BantControl (WUG)
#12 Trid0n: Humans (WUBRG)
#13 Laplasjan: Devoted (WG, Lurrus)
#14 Ryan100495: Dredge (BRG)
#15 Lord_Beerus: Burn (WR, Lurrus)
#16 _Batutinha_: BantControl (WUG)
#17 ScreenwriterNY: WUBGControl (WUBG, Yorion)
#18 Erik157751: ETron (C)
#19 sff_mtg: KGCTron (G)
#20 Scacco Malto: MonoRedProwess (R)
#21 mosskami: KGCAmuletTitan (WUBRG)
#22 indianpancake: Devoted (WG)
#23 Koso: ETron (C)
#24 WeareVenom: BantControl (WUG)
#25 robb93: ETron (C)
#26 leclairandy: BantControl (WUG)
#27 Math_God: GiftsStorm (UR)
#28 Wartico1: Devoted (WG, Lurrus)
#29 Nightblue: Burn (WR)
#30 ilsecco14: Neobrand (UG)
#31 Moniz0801: KGCAmuletTitan (WUBRG)
#32 Oscar_Franco: ETron (C)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_challenge_2020_06_08 : EventTest
    {
        [Test]
        public void Deck01_TSPJendrek_WUBGControl_WUBG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",0),
                new PostCompanionChange(),
                ArchetypeColor.WUBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_ZYURYO_WUBGControl_WUBG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",1),
                new PostCompanionChange(),
                ArchetypeColor.WUBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_JB2002_BantBlink_WUG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",2),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_Yanti_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",3),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Blitzlion27_Mill_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",4),
                new PostCompanionChange(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck06_AstralPlane_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",5),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck07_SvenSvenSven_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",6),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_signblindman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",7),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_hugo87_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",8),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Tw33Ty_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",9),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Cherryxman_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",10),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Trid0n_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",11),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",12),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_Ryan100495_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",13),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck15_LordBeerus_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",14),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_Batutinha_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",15),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_ScreenwriterNY_WUBGControl_WUBG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",16),
                new PostCompanionChange(),
                ArchetypeColor.WUBG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck18_Erik157751_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",17),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck19_sffmtg_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",18),
                new PostCompanionChange(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck20_ScaccoMalto_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",19),
                new PostCompanionChange(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck21_mosskami_KGCAmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",20),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck22_indianpancake_Devoted_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",21),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Koso_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",22),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck24_WeareVenom_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",23),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck25_robb93_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",24),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck26_leclairandy_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",25),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_MathGod_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",26),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Wartico1_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",27),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_Nightblue_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",28),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck30_ilsecco14_Neobrand_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",29),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Moniz0801_KGCAmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",30),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck32_OscarFranco_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",31),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }


    }
}
