using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 egadd2894: Scapeshift (URG, Yorion)
#02 unicornparadise: Gruul Midrange (RG, Obosh)
#03 GALL: Jund Midrange (BRG, Lurrus)
#04 GrandDrou: Mardu Prowess (WBR, Lurrus)
#05 kanister: Rakdos Prowess (BR, Lurrus)
#06 nathansteuer: Mardu Prowess (WBR, Lurrus)
#07 HarlanMTG: Bant Control (WUG, Yorion)
#08 Bugsy69: Thopter Urza (WUR, Yorion)
#09 stainerson: Gruul Midrange (RG, Obosh)
#10 ConnorM426: Mardu Prowess (WBR, Lurrus)
#11 DDMeelow: Uroza (URG, Yorion)
#12 MaxMagicer: Scapeshift (URG, Yorion)
#13 LSMD: Boros Prowess (WR, Lurrus)
#14 ecobaronen: Gruul Midrange (RG, Obosh)
#15 pbarrrgh: Jeskai Control (WUR, Yorion)
#16 joetru: Niv To Light (WUBRG, Jegantha)
#17 Numena_Lowallyn: Scapeshift (WUBRG, Yorion)
#18 XxquestionablyawesomexX: Bogles (WG, Lurrus)
#19 1yo2yo: Jund Midrange (BRG, Lurrus)
#20 coert: Burn (WR, Lurrus)
#21 paucr5: Grixis Control (UBR, Lurrus)
#22 staples87: Green Tron (RG, Jegantha)
#23 FestiFan: Saheeli Combo (WURG, Yorion)
#24 Desiver: Amulet Titan (URG)
#25 Souze6: Jund Midrange (BRG, Lurrus)
#26 TSPJendrek: Azorius Control (WU, Yorion)
#27 twinlesstwin: Golgari Midrange (BG, Lurrus)
#28 CharLy: Jund Midrange (BRG, Lurrus)
#29 Sanchez5272: Green Tron (G)
#30 VampireGodric: Reclamation (UBG)
#31 CordoTwin: UBRG Shadow (UBRG, Lurrus)
#32 Biednarccio: Amulet Titan (URG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_challenge_2020_05_17 : EventTest
    {
        [Test]
        public void Deck01_egadd2894_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",0),
                "PostIkoria",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_unicornparadise_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",1),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck03_GALL_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",2),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_GrandDrou_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",3),
                "PostIkoria",
                ArchetypeColor.WBR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_kanister_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",4),
                "PostIkoria",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_nathansteuer_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",5),
                "PostIkoria",
                ArchetypeColor.WBR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_HarlanMTG_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",6),
                "PostIkoria",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck08_Bugsy69_ThopterUrza_WUR_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",7),
                "PostIkoria",
                ArchetypeColor.WUR,
                "ThopterCombo",
                "ThopterUrza",
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck09_stainerson_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",8),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck10_ConnorM426_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",9),
                "PostIkoria",
                ArchetypeColor.WBR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_DDMeelow_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",10),
                "PostIkoria",
                ArchetypeColor.URG,
                "Uroza",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck12_MaxMagicer_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",11),
                "PostIkoria",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck13_LSMD_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",12),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_ecobaronen_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",13),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck15_pbarrrgh_JeskaiControl_WUR_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",14),
                "PostIkoria",
                ArchetypeColor.WUR,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck16_joetru_NivToLight_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",15),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck17_NumenaLowallyn_Scapeshift_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",16),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "Scapeshift",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck18_XxquestionablyawesomexX_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",17),
                "PostIkoria",
                ArchetypeColor.WG,
                "Bogles",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_1yo2yo_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",18),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_coert_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",19),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_paucr5_GrixisControl_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",20),
                "PostIkoria",
                ArchetypeColor.UBR,
                "GenericControl",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_staples87_GreenTron_RG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",21),
                "PostIkoria",
                ArchetypeColor.RG,
                "Tron",
                "GreenTron",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck23_FestiFan_SaheeliCombo_WURG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",22),
                "PostIkoria",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck24_Desiver_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",23),
                "PostIkoria",
                ArchetypeColor.URG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck25_Souze6_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",24),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_TSPJendrek_AzoriusControl_WU_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",25),
                "PostIkoria",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck27_twinlesstwin_GolgariMidrange_BG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",26),
                "PostIkoria",
                ArchetypeColor.BG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_CharLy_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",27),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_Sanchez5272_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",28),
                "PostIkoria",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck30_VampireGodric_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",29),
                "PostIkoria",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck31_CordoTwin_UBRGShadow_UBRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",30),
                "PostIkoria",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck32_Biednarccio_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",31),
                "PostIkoria",
                ArchetypeColor.URG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }


    }
}
