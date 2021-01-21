using FluentAssertions;
using MTGOArchetypeParser.Model;
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
#07 CitrusD: Yawgmoth (WBG)
#08 mariogomes097: Grixis Shadow (UBR)
#09 TSPJendrek: Sultai Control (UBG)
#10 NuBlkAu: Grixis Shadow (UBR)
#11 Mzfroste: Amulet Titan (RG)
#12 MIkepick7: Eldrazi Tron (C)
#13 pootisgodsamongus: Gruul Midrange (RG)
#14 genmatsu: Uroza (UBG)
#15 SebastianStueckl: Obosh Aggro (R, Obosh)
#16 Sodeq: Ad Nauseam (WUB)
#17 tribalmaster: Humans (WUR)
#18 calheiros: Amulet Titan (G)
#19 DaniMRebel: Spirits (WU)
#20 Tsubasa_Cat: Izzet Prowess (UR)
#21 eggybenny: Grixis Shadow (UBR)
#22 Saviall: Green Tron (G)
#23 bcs8995: Obosh Aggro (R, Obosh)
#24 Fluorspar: Humans (WUBRG)
#25 nahuel10: Izzet Prowess (UR)
#26 iggkrajc: Green Tron (G)
#27 t1griselbrand: Neobrand (UG)
#28 Patapon20: Dredge (BRG)
#29 Trellon: Blue Tron (U)
#30 ice_nine_: Land Destruction (WR)
#31 BigPanda_559: Burn (WR)
#32 Predicted: Yawgmoth (WBG)
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
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericBlink",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Kuhb_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",1),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_qbturtle15_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",2),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck04_azax_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",3),
                "PostAstrolabeBan",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck05_yumemana_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",4),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck06_mRichi_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",5),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck07_CitrusD_Yawgmoth_WBG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",6),
                "PostAstrolabeBan",
                ArchetypeColor.WBG,
                "Yawgmoth",
                null,
                null
            );
        }

        [Test]
        public void Deck08_mariogomes097_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",7),
                "PostAstrolabeBan",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck09_TSPJendrek_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",8),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck10_NuBlkAu_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",9),
                "PostAstrolabeBan",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck11_Mzfroste_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",10),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck12_MIkepick7_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",11),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck13_pootisgodsamongus_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",12),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck14_genmatsu_Uroza_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",13),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck15_SebastianStueckl_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",14),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck16_Sodeq_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",15),
                "PostAstrolabeBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck17_tribalmaster_Humans_WUR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",16),
                "PostAstrolabeBan",
                ArchetypeColor.WUR,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck18_calheiros_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",17),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck19_DaniMRebel_Spirits_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",18),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "Spirits",
                null,
                null
            );
        }

        [Test]
        public void Deck20_TsubasaCat_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",19),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck21_eggybenny_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",20),
                "PostAstrolabeBan",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck22_Saviall_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",21),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck23_bcs8995_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",22),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck24_Fluorspar_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",23),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck25_nahuel10_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",24),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck26_iggkrajc_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",25),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck27_t1griselbrand_Neobrand_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",26),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck28_Patapon20_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",27),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck29_Trellon_BlueTron_U()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",28),
                "PostAstrolabeBan",
                ArchetypeColor.U,
                "Tron",
                "BlueTron",
                null
            );
        }

        [Test]
        public void Deck30_icenine_LandDestruction_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",29),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "LandDestruction",
                null,
                null
            );
        }

        [Test]
        public void Deck31_BigPanda559_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",30),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck32_Predicted_Yawgmoth_WBG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-13",31),
                "PostAstrolabeBan",
                ArchetypeColor.WBG,
                "Yawgmoth",
                null,
                null
            );
        }


    }
}
