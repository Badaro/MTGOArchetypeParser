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
#01 TSPJendrek: WUBG Control (WUBG)
#02 ZYURYO: WUBG Control (WUBG)
#03 JB2002: Bant Blink (WUG, Yorion)
#04 Yanti: Humans (WUBRG)
#05 Blitzlion27: Mill (UB)
#06 AstralPlane: Burn (WR)
#07 SvenSvenSven: Izzet Control (UR)
#08 signblindman: Gruul Midrange (RG)
#09 hugo87: Gifts Storm (UR)
#10 Tw33Ty: Eldrazi Tron (C)
#11 Cherryxman: Bant Control (WUG)
#12 Trid0n: Humans (WUBRG)
#13 Laplasjan: Devoted (WG, Lurrus)
#14 Ryan100495: Dredge (BRG)
#15 Lord_Beerus: Burn (WR, Lurrus)
#16 _Batutinha_: Bant Control (WUG)
#17 ScreenwriterNY: WUBG Control (WUBG, Yorion)
#18 Erik157751: Eldrazi Tron (C)
#19 sff_mtg: Green Tron (G)
#20 Scacco Malto: Mono Red Prowess (R)
#21 mosskami: Amulet Titan (G)
#22 indianpancake: Devoted (WG)
#23 Koso: Eldrazi Tron (C)
#24 WeareVenom: Bant Control (WUG)
#25 robb93: Eldrazi Tron (C)
#26 leclairandy: Bant Control (WUG)
#27 Math_God: Gifts Storm (UR)
#28 Wartico1: Devoted (WG, Lurrus)
#29 Nightblue: Burn (WR)
#30 ilsecco14: Neobrand (UG)
#31 Moniz0801: Amulet Titan (UG)
#32 Oscar_Franco: Eldrazi Tron (C)
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
                "PostCompanionChange",
                ArchetypeColor.WUBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_ZYURYO_WUBGControl_WUBG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",1),
                "PostCompanionChange",
                ArchetypeColor.WUBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_JB2002_BantBlink_WUG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",2),
                "PostCompanionChange",
                ArchetypeColor.WUG,
                "GenericBlink",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_Yanti_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",3),
                "PostCompanionChange",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck05_Blitzlion27_Mill_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",4),
                "PostCompanionChange",
                ArchetypeColor.UB,
                "Mill",
                null,
                null
            );
        }

        [Test]
        public void Deck06_AstralPlane_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",5),
                "PostCompanionChange",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck07_SvenSvenSven_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",6),
                "PostCompanionChange",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck08_signblindman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",7),
                "PostCompanionChange",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck09_hugo87_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",8),
                "PostCompanionChange",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Tw33Ty_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",9),
                "PostCompanionChange",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck11_Cherryxman_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",10),
                "PostCompanionChange",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck12_Trid0n_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",11),
                "PostCompanionChange",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",12),
                "PostCompanionChange",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_Ryan100495_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",13),
                "PostCompanionChange",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck15_LordBeerus_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",14),
                "PostCompanionChange",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_Batutinha_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",15),
                "PostCompanionChange",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck17_ScreenwriterNY_WUBGControl_WUBG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",16),
                "PostCompanionChange",
                ArchetypeColor.WUBG,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck18_Erik157751_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",17),
                "PostCompanionChange",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck19_sffmtg_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",18),
                "PostCompanionChange",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck20_ScaccoMalto_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",19),
                "PostCompanionChange",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck21_mosskami_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",20),
                "PostCompanionChange",
                ArchetypeColor.G,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck22_indianpancake_Devoted_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",21),
                "PostCompanionChange",
                ArchetypeColor.WG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck23_Koso_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",22),
                "PostCompanionChange",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck24_WeareVenom_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",23),
                "PostCompanionChange",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck25_robb93_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",24),
                "PostCompanionChange",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck26_leclairandy_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",25),
                "PostCompanionChange",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck27_MathGod_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",26),
                "PostCompanionChange",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck28_Wartico1_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",27),
                "PostCompanionChange",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_Nightblue_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",28),
                "PostCompanionChange",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck30_ilsecco14_Neobrand_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",29),
                "PostCompanionChange",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck31_Moniz0801_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",30),
                "PostCompanionChange",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck32_OscarFranco_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",31),
                "PostCompanionChange",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }


    }
}
