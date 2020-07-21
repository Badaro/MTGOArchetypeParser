using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_06_26_postm21
{
    public class EventTest_modern_league_2020_07_07 : EventTest
    {
        [Test]
        public void Deck01_FreshKale_Prowess_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck01_FreshKale_Prowess_UR(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Jedermann_Goblins_SnoopGoblins_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck02_Jedermann_Goblins_SnoopGoblins_BR(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Goblins),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck03_busso9494_IzzetFreeSpells_ElectroBalance_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck03_busso9494_IzzetFreeSpells_ElectroBalance_URG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetFreeSpells),
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck04_Tarmofir3_Rock_BG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck04_Tarmofir3_Rock_BG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.BG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                null,
                null
            );
        }

        [Test]
        public void Deck05_JMoney8771_Infect_UG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck05_JMoney8771_Infect_UG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.UG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck06_WhiteFish_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck06_WhiteFish_DeathsShadow_GrixisShadow_UBR(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.UBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck07_AZN7_PrimevalTitan_AmuletTitan_WURG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck07_AZN7_PrimevalTitan_AmuletTitan_WURG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.WURG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck08_twilightSSparkle_Neobrand_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck08_twilightSSparkle_Neobrand_WUG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Parrit_HardenedScales_BG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck09_Parrit_HardenedScales_BG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.BG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Termahgerf_Uroza_WUG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck10_Termahgerf_Uroza_WUG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck11_Ennuixd_DeathsShadow_TraverseShadow_UBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck11_Ennuixd_DeathsShadow_TraverseShadow_UBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.UBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck12_Ayzkub_SnowControl_SultaiSnow_UBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck12_Ayzkub_SnowControl_SultaiSnow_UBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.UBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck13_ArchaeusDota_GTron_GreenEldraziTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck13_ArchaeusDota_GTron_GreenEldraziTron_G(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.G,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GTron),
                typeof(MTGOArchetypeParser.Archetypes.Modern.GreenEldraziTron),
                null
            );
        }

        [Test]
        public void Deck14_MrJayngles_RedPrison_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck14_MrJayngles_RedPrison_R(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.R,
                typeof(MTGOArchetypeParser.Archetypes.Modern.RedPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck15_equites_Burn_IncineratorBurn_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck15_equites_Burn_IncineratorBurn_R(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.R,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                typeof(MTGOArchetypeParser.Archetypes.Modern.IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck16_UrbanPope_Prowess_RakdosProwess_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck16_UrbanPope_Prowess_RakdosProwess_BR(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                typeof(MTGOArchetypeParser.Archetypes.Modern.RakdosProwess),
                null
            );
        }

        [Test]
        public void Deck17_number1pwnr_UTron_U()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck17_number1pwnr_UTron_U(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.U,
                typeof(MTGOArchetypeParser.Archetypes.Modern.UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck18_rojanosa_Tokens_OrzhovTokens_WB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck18_rojanosa_Tokens_OrzhovTokens_WB(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.WB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Tokens),
                typeof(MTGOArchetypeParser.Archetypes.Modern.OrzhovTokens),
                null
            );
        }

        [Test]
        public void Deck19_mikeyg43_SnowControl_SnowBlade_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck19_mikeyg43_SnowControl_SnowBlade_WUG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowBlade),
                null
            );
        }

        [Test]
        public void Deck20_Kotva_NinjaFaeries_UB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck20_Kotva_NinjaFaeries_UB(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.UB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.NinjaFaeries),
                null,
                null
            );
        }

        [Test]
        public void Deck21_gazmon48_Prowess_IzzetProwess_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck21_gazmon48_Prowess_IzzetProwess_UR(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck22_zMunkeyXz_Mill_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck22_zMunkeyXz_Mill_UBG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck23_TheDogFish_Merfolk_UG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck23_TheDogFish_Merfolk_UG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.UG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Metcalf23_DeathAndTaxes_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck24_Metcalf23_DeathAndTaxes_WR(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathAndTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Asoen_Skelementals_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck25_Asoen_Skelementals_BR(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Skelementals),
                null,
                null
            );
        }

        [Test]
        public void Deck26_maear_IzzetControl_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck26_maear_IzzetControl_UR(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_JFKDefiedBolas_MartyrProc_W()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck27_JFKDefiedBolas_MartyrProc_W(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.W,
                typeof(MTGOArchetypeParser.Archetypes.Modern.MartyrProc),
                null,
                null
            );
        }

        [Test]
        public void Deck28_B4nn3D22_Goblins_SnoopGoblins_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck28_B4nn3D22_Goblins_SnoopGoblins_BR(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Goblins),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck29_umeboshijiisan_Goblins_SnoopGoblins_WBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck29_umeboshijiisan_Goblins_SnoopGoblins_WBR(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.WBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Goblins),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck30_RENDGT_SnowControl_WURG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck30_RENDGT_SnowControl_WURG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.WURG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck31_MegaMollt_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck31_MegaMollt_GiftsStorm_UR(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck32_TheWonderLord_Rock_BG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck32_TheWonderLord_Rock_BG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.BG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Boin_Goblins_SnoopGoblins_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck33_Boin_Goblins_SnoopGoblins_BR(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Goblins),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck34_ArchaeusDota_ETron_BG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck34_ArchaeusDota_ETron_BG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.BG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck35_ToniCalzoni_AdNauseam_WUB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck35_ToniCalzoni_AdNauseam_WUB(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.WUB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck36_andresambiaze_Dredge_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck36_andresambiaze_Dredge_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck37_Janh_SnowControl_SnowShift_URG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck37_Janh_SnowControl_SnowShift_URG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowShift),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck38_freneticefreet_Ponza_LiquimetalPonza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck38_freneticefreet_Ponza_LiquimetalPonza_RG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                typeof(MTGOArchetypeParser.Archetypes.Modern.LiquimetalPonza),
                null
            );
        }

        [Test]
        public void Deck39_CloakedAlvis_GTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck39_CloakedAlvis_GTron_G(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.G,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GTron),
                null,
                null
            );
        }

        [Test]
        public void Deck40_Musagete_DeathAndTaxes_EldraziTaxes_WB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck40_Musagete_DeathAndTaxes_EldraziTaxes_WB(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.WB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathAndTaxes),
                typeof(MTGOArchetypeParser.Archetypes.Modern.EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck41_mac121711_SnowControl_SultaiSnow_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck41_mac121711_SnowControl_SultaiSnow_UBG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck42_DFrank_ThopterUrza_WUB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck42_DFrank_ThopterUrza_WUB(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.WUB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck43_DoniDominaria_Burn_IncineratorBurn_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck43_DoniDominaria_Burn_IncineratorBurn_BR(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                typeof(MTGOArchetypeParser.Archetypes.Modern.IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck44_Jiggywiggy_KinnanUrza_WURG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck44_Jiggywiggy_KinnanUrza_WURG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.WURG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.KinnanUrza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck45_Trellon_UTron_U()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck45_Trellon_UTron_U(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.U,
                typeof(MTGOArchetypeParser.Archetypes.Modern.UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck46_kensportsfan_Prowess_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck46_kensportsfan_Prowess_R(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.R,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck47_Taracogenius_PrimevalTitan_TitanShift_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck47_Taracogenius_PrimevalTitan_TitanShift_RG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.TitanShift),
                null
            );
        }

        [Test]
        public void Deck48_TscheggschDePoegg_SnowControl_TemurSnow_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck48_TscheggschDePoegg_SnowControl_TemurSnow_URG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.TemurSnow),
                null
            );
        }

        [Test]
        public void Deck49_Ivan1227_AzoriusControl_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck49_Ivan1227_AzoriusControl_WU(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.WU,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AzoriusControl),
                null,
                null
            );
        }

        [Test]
        public void Deck50_musasabi_JundSmallpox_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck50_musasabi_JundSmallpox_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.JundSmallpox),
                null,
                null
            );
        }

        [Test]
        public void Deck51_Brunister_Dredge_WBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck51_Brunister_Dredge_WBR(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.WBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck52_MadRamon_SnowControl_SnowReclamation_URG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck52_MadRamon_SnowControl_SnowReclamation_URG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowReclamation),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck53_osk4_BringToNiv_WUBRG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck53_osk4_BringToNiv_WUBRG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck54_BanjoCaveman_Polymorph_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck54_BanjoCaveman_Polymorph_RG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Polymorph),
                null,
                null
            );
        }

        [Test]
        public void Deck55_kumuhl00_Elementals_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck55_kumuhl00_Elementals_WUBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck56_TBagTom_SnowControl_UBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck56_TBagTom_SnowControl_UBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.UBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck57_RealJoy_DeathsShadow_SuicideShadow_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck57_RealJoy_DeathsShadow_SuicideShadow_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SuicideShadow),
                null
            );
        }

        [Test]
        public void Deck58_albert62_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck58_albert62_Rock_Jund_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Jund),
                null
            );
        }

        [Test]
        public void Deck59_JoaoAndrade_RedDeckWins_R_Jegantha()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck59_JoaoAndrade_RedDeckWins_R_Jegantha(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.R,
                typeof(MTGOArchetypeParser.Archetypes.Modern.RedDeckWins),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck60_SeventhProphet_Uroza_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck60_SeventhProphet_Uroza_URG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck61_TuggaNaxos_SnowControl_SnowTurns_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck61_TuggaNaxos_SnowControl_SnowTurns_URG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowTurns),
                null
            );
        }

        [Test]
        public void Deck62_victgobra10_Burn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck62_victgobra10_Burn_WR(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck63_yutya_SnowControl_SnowTurns_WUG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck63_yutya_SnowControl_SnowTurns_WUG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowTurns),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck64_Simpleliquid_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck64_Simpleliquid_Humans_WUBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck65_sten626_Devoted_WG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck65_sten626_Devoted_WG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.WG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck66_Traft_SnowControl_WURG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck66_Traft_SnowControl_WURG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.WURG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck67_gogogadgetblunt_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_07.Deck67_gogogadgetblunt_Ponza_RG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }


    }
}
