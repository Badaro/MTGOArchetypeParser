using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_league_2020_07_07 : EventTest
    {
        [Test]
        public void Deck01_FreshKale_Prowess_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck01_FreshKale_Prowess_UR(),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Jedermann_Goblins_SnoopGoblins_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck02_Jedermann_Goblins_SnoopGoblins_BR(),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck03_busso9494_IzzetFreeSpells_IzzetRestoreBalance_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck03_busso9494_IzzetFreeSpells_IzzetRestoreBalance_URG(),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck04_Tarmofir3_Rock_BG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck04_Tarmofir3_Rock_BG(),
                new PostM21(),
                ArchetypeColor.BG,
                typeof(Rock),
                null,
                null
            );
        }

        [Test]
        public void Deck05_JMoney8771_Infect_UG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck05_JMoney8771_Infect_UG(),
                new PostM21(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck06_WhiteFish_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck06_WhiteFish_DeathsShadow_GrixisShadow_UBR(),
                new PostM21(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck07_AZN7_PrimevalTitan_AmuletTitan_WURG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck07_AZN7_PrimevalTitan_AmuletTitan_WURG(),
                new PostM21(),
                ArchetypeColor.WURG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck08_twilightSSparkle_Neobrand_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck08_twilightSSparkle_Neobrand_WUG(),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Parrit_HardenedScales_BG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck09_Parrit_HardenedScales_BG_Lurrus(),
                new PostM21(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_Termahgerf_Uroza_WUG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck10_Termahgerf_Uroza_WUG_Yorion(),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck11_Ennuixd_DeathsShadow_TraverseShadow_UBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck11_Ennuixd_DeathsShadow_TraverseShadow_UBRG(),
                new PostM21(),
                ArchetypeColor.UBRG,
                typeof(DeathsShadow),
                typeof(TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck12_Ayzkub_SnowControl_SultaiSnow_UBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck12_Ayzkub_SnowControl_SultaiSnow_UBRG(),
                new PostM21(),
                ArchetypeColor.UBRG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck13_ArchaeusDota_GTron_GreenEldraziTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck13_ArchaeusDota_GTron_GreenEldraziTron_G(),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(GreenEldraziTron),
                null
            );
        }

        [Test]
        public void Deck14_MrJayngles_RedPrison_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck14_MrJayngles_RedPrison_R(),
                new PostM21(),
                ArchetypeColor.R,
                typeof(RedPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck15_equites_Burn_IncineratorBurn_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck15_equites_Burn_IncineratorBurn_R(),
                new PostM21(),
                ArchetypeColor.R,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck16_UrbanPope_Prowess_RakdosProwess_BR_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck16_UrbanPope_Prowess_RakdosProwess_BR_Lurrus(),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_number1pwnr_UTron_U()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck17_number1pwnr_UTron_U(),
                new PostM21(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck18_rojanosa_Tokens_OrzhovTokens_WB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck18_rojanosa_Tokens_OrzhovTokens_WB(),
                new PostM21(),
                ArchetypeColor.WB,
                typeof(Tokens),
                typeof(OrzhovTokens),
                null
            );
        }

        [Test]
        public void Deck19_mikeyg43_SnowControl_SnowBlade_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck19_mikeyg43_SnowControl_SnowBlade_WUG(),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowBlade),
                null
            );
        }

        [Test]
        public void Deck20_Kotva_NinjaFaeries_UB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck20_Kotva_NinjaFaeries_UB(),
                new PostM21(),
                ArchetypeColor.UB,
                typeof(NinjaFaeries),
                null,
                null
            );
        }

        [Test]
        public void Deck21_gazmon48_Prowess_IzzetProwess_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck21_gazmon48_Prowess_IzzetProwess_UR(),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck22_zMunkeyXz_Mill_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck22_zMunkeyXz_Mill_UBG(),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck23_TheDogFish_Merfolk_UG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck23_TheDogFish_Merfolk_UG(),
                new PostM21(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Metcalf23_DeathAndTaxes_WR_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck24_Metcalf23_DeathAndTaxes_WR_Lurrus(),
                new PostM21(),
                ArchetypeColor.WR,
                typeof(DeathAndTaxes),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_Asoen_RakdosMidrange_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck25_Asoen_RakdosMidrange_BR(),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(RakdosMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck26_maear_IzzetControl_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck26_maear_IzzetControl_UR(),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_JFKDefiedBolas_MartyrProc_W()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck27_JFKDefiedBolas_MartyrProc_W(),
                new PostM21(),
                ArchetypeColor.W,
                typeof(MartyrProc),
                null,
                null
            );
        }

        [Test]
        public void Deck28_B4nn3D22_Goblins_SnoopGoblins_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck28_B4nn3D22_Goblins_SnoopGoblins_BR(),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck29_umeboshijiisan_Goblins_SnoopGoblins_WBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck29_umeboshijiisan_Goblins_SnoopGoblins_WBR(),
                new PostM21(),
                ArchetypeColor.WBR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck30_RENDGT_SnowControl_WURG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck30_RENDGT_SnowControl_WURG_Yorion(),
                new PostM21(),
                ArchetypeColor.WURG,
                typeof(SnowControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck31_MegaMollt_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck31_MegaMollt_GiftsStorm_UR(),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck32_TheWonderLord_Rock_BG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck32_TheWonderLord_Rock_BG(),
                new PostM21(),
                ArchetypeColor.BG,
                typeof(Rock),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Boin_Goblins_SnoopGoblins_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck33_Boin_Goblins_SnoopGoblins_BR(),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck34_ArchaeusDota_ETron_BG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck34_ArchaeusDota_ETron_BG(),
                new PostM21(),
                ArchetypeColor.BG,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck35_ToniCalzoni_AdNauseam_WUB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck35_ToniCalzoni_AdNauseam_WUB(),
                new PostM21(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck36_andresambiaze_Dredge_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck36_andresambiaze_Dredge_BRG(),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck37_Janh_SnowControl_SnowShift_URG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck37_Janh_SnowControl_SnowShift_URG_Yorion(),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(SnowShift),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck38_freneticefreet_Ponza_LiquimetalPonza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck38_freneticefreet_Ponza_LiquimetalPonza_RG(),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(Ponza),
                typeof(LiquimetalPonza),
                null
            );
        }

        [Test]
        public void Deck39_CloakedAlvis_GTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck39_CloakedAlvis_GTron_G(),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                null,
                null
            );
        }

        [Test]
        public void Deck40_Musagete_DeathAndTaxes_EldraziTaxes_WB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck40_Musagete_DeathAndTaxes_EldraziTaxes_WB(),
                new PostM21(),
                ArchetypeColor.WB,
                typeof(DeathAndTaxes),
                typeof(EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck41_mac121711_SnowControl_SultaiSnow_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck41_mac121711_SnowControl_SultaiSnow_UBG(),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck42_DFrank_ThopterUrza_WUB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck42_DFrank_ThopterUrza_WUB(),
                new PostM21(),
                ArchetypeColor.WUB,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck43_DoniDominaria_Burn_IncineratorBurn_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck43_DoniDominaria_Burn_IncineratorBurn_BR(),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck44_Jiggywiggy_KinnanUrza_WURG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck44_Jiggywiggy_KinnanUrza_WURG_Yorion(),
                new PostM21(),
                ArchetypeColor.WURG,
                typeof(KinnanUrza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck45_Trellon_UTron_U()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck45_Trellon_UTron_U(),
                new PostM21(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck46_kensportsfan_Prowess_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck46_kensportsfan_Prowess_R(),
                new PostM21(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck47_Taracogenius_PrimevalTitan_TitanShift_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck47_Taracogenius_PrimevalTitan_TitanShift_RG(),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck48_TscheggschDePoegg_SnowControl_TemurSnow_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck48_TscheggschDePoegg_SnowControl_TemurSnow_URG(),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(TemurSnow),
                null
            );
        }

        [Test]
        public void Deck49_Ivan1227_AzoriusControl_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck49_Ivan1227_AzoriusControl_WU(),
                new PostM21(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                null,
                null
            );
        }

        [Test]
        public void Deck50_musasabi_JundSmallpox_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck50_musasabi_JundSmallpox_BRG(),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(JundSmallpox),
                null,
                null
            );
        }

        [Test]
        public void Deck51_Brunister_Dredge_WBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck51_Brunister_Dredge_WBR(),
                new PostM21(),
                ArchetypeColor.WBR,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck52_MadRamon_SnowControl_SnowReclamation_URG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck52_MadRamon_SnowControl_SnowReclamation_URG_Yorion(),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck53_osk4_BringToNiv_WUBRG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck53_osk4_BringToNiv_WUBRG_Yorion(),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck54_BanjoCaveman_Polymorph_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck54_BanjoCaveman_Polymorph_RG(),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(Polymorph),
                null,
                null
            );
        }

        [Test]
        public void Deck55_kumuhl00_Elementals_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck55_kumuhl00_Elementals_WUBRG(),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck56_TBagTom_SnowControl_SultaiSnow_UBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck56_TBagTom_SnowControl_SultaiSnow_UBRG(),
                new PostM21(),
                ArchetypeColor.UBRG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck57_RealJoy_DeathsShadow_SuicideShadow_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck57_RealJoy_DeathsShadow_SuicideShadow_BRG(),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(DeathsShadow),
                typeof(SuicideShadow),
                null
            );
        }

        [Test]
        public void Deck58_albert62_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck58_albert62_Rock_Jund_BRG(),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck59_JoaoAndrade_RedDeckWins_R_Jegantha()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck59_JoaoAndrade_RedDeckWins_R_Jegantha(),
                new PostM21(),
                ArchetypeColor.R,
                typeof(RedDeckWins),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck60_SeventhProphet_Uroza_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck60_SeventhProphet_Uroza_URG(),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck61_TuggaNaxos_SnowControl_SnowTurns_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck61_TuggaNaxos_SnowControl_SnowTurns_URG(),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(SnowTurns),
                null
            );
        }

        [Test]
        public void Deck62_victgobra10_Burn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck62_victgobra10_Burn_WR(),
                new PostM21(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck63_yutya_SnowControl_SnowTurns_WUG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck63_yutya_SnowControl_SnowTurns_WUG_Yorion(),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowTurns),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck64_Simpleliquid_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck64_Simpleliquid_Humans_WUBRG(),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck65_sten626_Devoted_WG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck65_sten626_Devoted_WG_Lurrus(),
                new PostM21(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck66_Traft_SnowControl_WURG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck66_Traft_SnowControl_WURG(),
                new PostM21(),
                ArchetypeColor.WURG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck67_gogogadgetblunt_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07.Deck67_gogogadgetblunt_Ponza_RG(),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }


    }
}
