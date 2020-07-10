using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests
{
    public class EventTest_modern_league_2020_07_10 : EventTest
    {
        [Test]
        public void Deck01_psych4tog_Elementals_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck01_psych4tog_Elementals_WUBRG(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck02_tcgshin_PrimevalTitan_TitanShift_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck02_tcgshin_PrimevalTitan_TitanShift_RG(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.TitanShift),
                null
            );
        }

        [Test]
        public void Deck03_PanCementJP_Spirits_BantSpirits_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck03_PanCementJP_Spirits_BantSpirits_WUG(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Spirits),
                typeof(MTGOArchetypeParser.Archetypes.Modern.BantSpirits),
                null
            );
        }

        [Test]
        public void Deck04_saccij92_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck04_saccij92_Humans_WUBRG(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck05_yPrincipe_BringToNiv_WUBRG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck05_yPrincipe_BringToNiv_WUBRG_Yorion(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck06_ArchaeusDota_GTron_KGCTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck06_ArchaeusDota_GTron_KGCTron_G(),
                ArchetypeColor.G,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GTron),
                typeof(MTGOArchetypeParser.Archetypes.Modern.KGCTron),
                null
            );
        }

        [Test]
        public void Deck07_BigAndEasy_Prowess_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck07_BigAndEasy_Prowess_R(),
                ArchetypeColor.R,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Rossello_Burn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck08_Rossello_Burn_WR(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck09_meanfannypack_DeathsShadow_MarduShadow_WB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck09_meanfannypack_DeathsShadow_MarduShadow_WB(),
                ArchetypeColor.WB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.MarduShadow),
                null
            );
        }

        [Test]
        public void Deck10_DoniDominaria_Prowess_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck10_DoniDominaria_Prowess_BR(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck11_AndersPovirk_Dredge_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck11_AndersPovirk_Dredge_BRG(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Polikasoll_Burn_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck12_Polikasoll_Burn_R(),
                ArchetypeColor.R,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Parrit_HardenedScales_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck13_Parrit_HardenedScales_G(),
                ArchetypeColor.G,
                typeof(MTGOArchetypeParser.Archetypes.Modern.HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck14_kogamo_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck14_kogamo_ETron_C(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Phyziks42_Ponza_WRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck15_Phyziks42_Ponza_WRG(),
                ArchetypeColor.WRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck16_musasabi_Goblins_SnoopGoblins_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck16_musasabi_Goblins_SnoopGoblins_BR(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Goblins),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck17_Silence9428_Infect_UG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck17_Silence9428_Infect_UG(),
                ArchetypeColor.UG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Do0mSwitch_SnowControl_SultaiSnow_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck18_Do0mSwitch_SnowControl_SultaiSnow_UBG(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck19_mauricio998_Mill_UB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck19_mauricio998_Mill_UB(),
                ArchetypeColor.UB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Shatun_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck20_Shatun_Ponza_RG(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck21_PanicDaddy_AdNauseam_WUB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck21_PanicDaddy_AdNauseam_WUB(),
                ArchetypeColor.WUB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck22_MrRaeb_Uroza_UBG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck22_MrRaeb_Uroza_UBG_Yorion(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck23_Pendragon15038_Merfolk_U()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck23_Pendragon15038_Merfolk_U(),
                ArchetypeColor.U,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck24_babamm_ElectroBalance_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck24_babamm_ElectroBalance_URG(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ElectroBalance),
                null,
                null
            );
        }

        [Test]
        public void Deck25_HiroHsiang_Prowess_IzzetProwess_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck25_HiroHsiang_Prowess_IzzetProwess_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck26_Curveiganhei_Prowess_R_Jegantha()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck26_Curveiganhei_Prowess_R_Jegantha(),
                ArchetypeColor.R,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck27_KieranT_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck27_KieranT_Rock_Jund_BRG(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Jund),
                null
            );
        }

        [Test]
        public void Deck28_yPrincipe_SnowControl_SnowTitan_WUG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck28_yPrincipe_SnowControl_SnowTitan_WUG_Yorion(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowTitan),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck29_SvenSveeterSven_IzzetControl_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck29_SvenSveeterSven_IzzetControl_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck30_wefald_Inverter_UB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck30_wefald_Inverter_UB(),
                ArchetypeColor.UB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Inverter),
                null,
                null
            );
        }

        [Test]
        public void Deck31_scvslayer_SnowControl_SnowShift_URG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck31_scvslayer_SnowControl_SnowShift_URG_Yorion(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowShift),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck32_MartinezDP_BantBlink_WUG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck32_MartinezDP_BantBlink_WUG_Yorion(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.BantBlink),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck33_maear_IzzetControl_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck33_maear_IzzetControl_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck34_Loreington_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck34_Loreington_GiftsStorm_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck35_Evaros_DeathAndTaxes_W()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck35_Evaros_DeathAndTaxes_W(),
                ArchetypeColor.W,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathAndTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck36_yumad3988_HollowOne_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck36_yumad3988_HollowOne_BR(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.HollowOne),
                null,
                null
            );
        }

        [Test]
        public void Deck37_gobboboy_DeathAndTaxes_EldraziTaxes_WB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck37_gobboboy_DeathAndTaxes_EldraziTaxes_WB(),
                ArchetypeColor.WB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathAndTaxes),
                typeof(MTGOArchetypeParser.Archetypes.Modern.EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck38_osmanozguney_DimirControl_UB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck38_osmanozguney_DimirControl_UB(),
                ArchetypeColor.UB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DimirControl),
                null,
                null
            );
        }

        [Test]
        public void Deck39_AnneLivleysD3ath_PrimevalTitan_KGCAmuletTitan_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck39_AnneLivleysD3ath_PrimevalTitan_KGCAmuletTitan_WUBRG(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck40_SiDa1991_UTron_U()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck40_SiDa1991_UTron_U(),
                ArchetypeColor.U,
                typeof(MTGOArchetypeParser.Archetypes.Modern.UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck41_DylanMTG_Neobrand_UG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck41_DylanMTG_Neobrand_UG(),
                ArchetypeColor.UG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck42_BossBr_DeathAndTaxes_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_07_10.Deck42_BossBr_DeathAndTaxes_WU(),
                ArchetypeColor.WU,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathAndTaxes),
                null,
                null
            );
        }


    }
}
