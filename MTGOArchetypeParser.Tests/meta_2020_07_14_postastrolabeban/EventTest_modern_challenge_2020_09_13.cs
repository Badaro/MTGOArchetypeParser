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
#01 _Logic_: Bant Blink (WUG)
#02 Kuhb: Devoted (WG, Lurrus)
#03 qbturtle15: Gruul Midrange (RG)
#04 azax: Grixis Shadow (UBR)
#05 yume-mana: Bant Midrange (WUG)
#06 mRichi: Gruul Midrange (RG)
#07 CitrusD: Yawgmoth (BG)
#08 mariogomes097: Grixis Shadow (UBR)
#09 TSPJendrek: Sultai Control (UBG)
#10 NuBlkAu: Grixis Shadow (UBR)
#11 Mzfroste: Amulet Titan (RG)
#12 MIkepick7: E Tron (C)
#13 pootisgodsamongus: Gruul Midrange (RG)
#14 genmatsu: Uroza (UBG)
#15 SebastianStueckl: Obosh Aggro (R, Obosh)
#16 Sodeq: Ad Nauseam (WUB)
#17 tribalmaster: Humans (WUR)
#18 calheiros: KGC Amulet Titan (G)
#19 DaniMRebel: Spirits (WU)
#20 Tsubasa_Cat: Izzet Prowess (UR)
#21 eggybenny: Grixis Shadow (UBR)
#22 Saviall: KGC Tron (G)
#23 bcs8995: Obosh Aggro (R, Obosh)
#24 Fluorspar: Humans (WUBRG)
#25 nahuel10: Izzet Prowess (UR)
#26 iggkrajc: KGC Tron (G)
#27 t1griselbrand: Neobrand (UG)
#28 Patapon20: Dredge (BRG)
#29 Trellon: U Tron (U)
#30 ice_nine_: Boros Land Destruction (WR)
#31 BigPanda_559: Burn (WR)
#32 Predicted: Yawgmoth (BG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_challenge_2020_09_13 : EventTest
    {
        [Test]
        public void Deck01_Logic_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",0),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Kuhb_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_qbturtle15_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",2),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck04_azax_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",3),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck05_yumemana_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_mRichi_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",5),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_CitrusD_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",6),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck08_mariogomes097_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",7),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck09_TSPJendrek_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",8),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_NuBlkAu_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",9),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Mzfroste_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",10),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck12_MIkepick7_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",11),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck13_pootisgodsamongus_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",12),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck14_genmatsu_Uroza_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",13),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck15_SebastianStueckl_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",14),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck16_Sodeq_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",15),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck17_tribalmaster_Humans_WUR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",16),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck18_calheiros_KGCAmuletTitan_G()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",17),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck19_DaniMRebel_Spirits_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",18),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck20_TsubasaCat_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",19),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck21_eggybenny_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",20),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Saviall_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",21),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck23_bcs8995_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",22),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck24_Fluorspar_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",23),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck25_nahuel10_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",24),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck26_iggkrajc_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",25),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck27_t1griselbrand_Neobrand_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",26),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Patapon20_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",27),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Trellon_UTron_U()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",28),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(Tron),
typeof(BlueTron),
                null
            );
        }

        [Test]
        public void Deck30_icenine_BorosLandDestruction_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",29),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(LandDestruction),
                null,
                null
            );
        }

        [Test]
        public void Deck31_BigPanda559_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",30),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Predicted_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",31),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }


    }
}
