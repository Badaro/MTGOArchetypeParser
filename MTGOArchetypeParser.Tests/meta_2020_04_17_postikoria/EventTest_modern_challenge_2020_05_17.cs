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
#15 pbarrrgh: Azorius Control (WU, Yorion)
#16 joetru: Niv To Light (WUBRG, Jegantha)
#17 Numena_Lowallyn: Scapeshift (URG, Yorion)
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
#30 VampireGodric: Sultai Control (UBG)
#31 CordoTwin: Jund Shadow (BRG, Lurrus)
#32 Biednarccio: Amulet Titan (UG)
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
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_unicornparadise_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",1),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck03_GALL_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",2),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_GrandDrou_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",3),
                new PostIkoria(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_kanister_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",4),
                new PostIkoria(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_nathansteuer_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",5),
                new PostIkoria(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_HarlanMTG_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",6),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck08_Bugsy69_ThopterUrza_WUR_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",7),
                new PostIkoria(),
                ArchetypeColor.WUR,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck09_stainerson_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",8),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck10_ConnorM426_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",9),
                new PostIkoria(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_DDMeelow_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",10),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck12_MaxMagicer_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",11),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck13_LSMD_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",12),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_ecobaronen_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",13),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck15_pbarrrgh_AzoriusControl_WU_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",14),
                new PostIkoria(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck16_joetru_NivToLight_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",15),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck17_NumenaLowallyn_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",16),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck18_XxquestionablyawesomexX_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",17),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_1yo2yo_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",18),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_coert_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",19),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_paucr5_GrixisControl_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",20),
                new PostIkoria(),
                ArchetypeColor.UBR,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_staples87_GreenTron_RG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",21),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(Tron),
                typeof(GreenTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck23_FestiFan_SaheeliCombo_WURG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",22),
                new PostIkoria(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck24_Desiver_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",23),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck25_Souze6_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",24),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_TSPJendrek_AzoriusControl_WU_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",25),
                new PostIkoria(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck27_twinlesstwin_GolgariMidrange_BG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",26),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_CharLy_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",27),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_Sanchez5272_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",28),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck30_VampireGodric_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",29),
                new PostIkoria(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_CordoTwin_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",30),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck32_Biednarccio_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-17",31),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }


    }
}
