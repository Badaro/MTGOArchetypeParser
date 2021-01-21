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
#01 Metcalf23: Mono White Taxes (W)
#02 Jaberwocki: Jund Midrange (BRG)
#03 WorstNewbEver: Shadow Prowess (BR, Lurrus)
#04 fried-liver-attack: Burn (WR)
#05 jacobricher: Humans (WUBRG)
#06 TSPJendrek: Sultai Control (UBG)
#07 Curtisaxel: Blue Tron (U)
#08 Munich_Casual: Spirits (WUG)
#09 Jositoshekel: Heliod Combo (WG)
#10 NHA37: Heliod Combo (W)
#11 yamakiller: Reclaimer Titan (WRG)
#12 SknerusMcKwacz: Oops All Spells (WUBG)
#13 Parrit: Mono White Taxes (W)
#14 Edel: Rakdos Midrange (BR)
#15 Mlgb92: Orzhov Midrange (WB)
#16 ice_nine_: Land Destruction (WR)
#17 Rav104: Izzet Prowess (UR)
#18 fingers1991: Shadow Prowess (BR, Lurrus)
#19 MiguelCaster: Mono White Taxes (W)
#20 shir kahn: Jeskai Control (WUR)
#21 ChironTheMage: WURG Control (WURG)
#22 GideonRavensword: Dredge (BRG)
#23 bigjc00: Amulet Titan (RG)
#24 fabee1: Bant Midrange (WUG)
#25 Doomenstein: Mono White Taxes (W)
#26 Gobern: Niv To Light (WUBRG, Yorion)
#27 Andreas_Mueller: Dredge (BRG)
#28 Elnitzo: Mill (UB, Lurrus)
#29 MHayashi: Obosh Aggro (R, Obosh)
#30 staffmat1992: Spirits (WUG)
#31 Johnny_Hobbs: WURG Control (WURG)
#32 thephatz: Mono White Taxes (W)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_10_11 : EventTest
    {
        [Test]
        public void Deck01_Metcalf23_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",0),
                "PostZendikarRising",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Jaberwocki_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",1),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck03_WorstNewbEver_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",2),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_friedliverattack_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",3),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck05_jacobricher_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",4),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck06_TSPJendrek_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",5),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Curtisaxel_BlueTron_U()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",6),
                "PostZendikarRising",
                ArchetypeColor.U,
                "Tron",
                "BlueTron",
                null
            );
        }

        [Test]
        public void Deck08_MunichCasual_Spirits_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",7),
                "PostZendikarRising",
                ArchetypeColor.WUG,
                "Spirits",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Jositoshekel_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",8),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck10_NHA37_HeliodCombo_W()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",9),
                "PostZendikarRising",
                ArchetypeColor.W,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck11_yamakiller_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",10),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck12_SknerusMcKwacz_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",11),
                "PostZendikarRising",
                ArchetypeColor.WUBG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Parrit_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",12),
                "PostZendikarRising",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck14_Edel_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",13),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck15_Mlgb92_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",14),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck16_icenine_LandDestruction_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",15),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "LandDestruction",
                null,
                null
            );
        }

        [Test]
        public void Deck17_Rav104_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",16),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck18_fingers1991_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",17),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_MiguelCaster_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",18),
                "PostZendikarRising",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck20_shirkahn_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",19),
                "PostZendikarRising",
                ArchetypeColor.WUR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck21_ChironTheMage_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",20),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck22_GideonRavensword_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",21),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck23_bigjc00_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",22),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck24_fabee1_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",23),
                "PostZendikarRising",
                ArchetypeColor.WUG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck25_Doomenstein_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",24),
                "PostZendikarRising",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck26_Gobern_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",25),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck27_AndreasMueller_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",26),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck28_Elnitzo_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",27),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "Mill",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_MHayashi_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",28),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck30_staffmat1992_Spirits_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",29),
                "PostZendikarRising",
                ArchetypeColor.WUG,
                "Spirits",
                null,
                null
            );
        }

        [Test]
        public void Deck31_JohnnyHobbs_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",30),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck32_thephatz_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",31),
                "PostZendikarRising",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }


    }
}
