using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_07_15_postastrolabeban
{
    public class EventTest_modern_league_2020_07_24 : EventTest
    {
        [Test]
        public void Deck01_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck01_Kurusu_KikiChord_WRG_Yorion(),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_Makaveli_AzoriusControl_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck02_Makaveli_AzoriusControl_WU(),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_BaDzIo_HardenedScales_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck03_BaDzIo_HardenedScales_G(),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck04_kensportsfan_Prowess_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck04_kensportsfan_Prowess_R(),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck05_carlosalmeida_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck05_carlosalmeida_Humans_WUBRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck06_GHash77_BantMidrange_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck06_GHash77_BantMidrange_WUG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Ladon_SaheeliCombo_SnowSaheeli_WURG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck07_Ladon_SaheeliCombo_SnowSaheeli_WURG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(SnowSaheeli),
                null
            );
        }

        [Test]
        public void Deck08_Beicodegeia_RedDeckWins_R_Jegantha()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck08_Beicodegeia_RedDeckWins_R_Jegantha(),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(RedDeckWins),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck09_aspiringspike_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck09_aspiringspike_Rock_Jund_BRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck10_TurmolL_IzzetControl_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck10_TurmolL_IzzetControl_UR(),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_DylanMTG_IzzetFreeSpells_IzzetRestoreBalance_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck11_DylanMTG_IzzetFreeSpells_IzzetRestoreBalance_URG(),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck12_LHaxLover_Scapeshift_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck12_LHaxLover_Scapeshift_URG(),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck13_PhantasmalBear_AzoriusTempo_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck13_PhantasmalBear_AzoriusTempo_WU(),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusTempo),
                null,
                null
            );
        }

        [Test]
        public void Deck14_ContraEgo_ThopterUrza_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck14_ContraEgo_ThopterUrza_UBR(),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Nilsfit_SnowControl_SnowReclamation_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck15_Nilsfit_SnowControl_SnowReclamation_UBG(),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck16_DeadEyeEneMy_Bogles_WG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck16_DeadEyeEneMy_Bogles_WG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck17_SharkcasterMage_AdNauseam_WUB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck17_SharkcasterMage_AdNauseam_WUB(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck18_cnofafva_PrimevalTitan_KGCAmuletTitan_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck18_cnofafva_PrimevalTitan_KGCAmuletTitan_WUBRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck19_ShogunHelios_Crabvine_UBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck19_ShogunHelios_Crabvine_UBRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Automaton_Elves_GolgariElves_BG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck20_Automaton_Elves_GolgariElves_BG(),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Elves),
                typeof(GolgariElves),
                null
            );
        }

        [Test]
        public void Deck21_Lcario_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck21_Lcario_DeathsShadow_GrixisShadow_UBR(),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck22_Predicted_Yawgmoth_WBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck22_Predicted_Yawgmoth_WBG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Janh_SaheeliCombo_WUR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck23_Janh_SaheeliCombo_WUR(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(SaheeliCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Bosseidon_Burn_IncineratorBurn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck24_Bosseidon_Burn_IncineratorBurn_WR(),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck25_603Leb_PrimevalTitan_AmuletTitan_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck25_603Leb_PrimevalTitan_AmuletTitan_URG(),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck26_Albyz_SnowControl_SultaiSnow_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck26_Albyz_SnowControl_SultaiSnow_UBG(),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck27_1nfundibulum_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck27_1nfundibulum_ETron_C(),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Zebrah_DeathAndTaxes_WR_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck28_Zebrah_DeathAndTaxes_WR_Lurrus(),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(DeathAndTaxes),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_GodsShadow_GrixisControl_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck29_GodsShadow_GrixisControl_UBR(),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GrixisControl),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Baufos_SimicControl_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck30_Baufos_SimicControl_UBG(),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(SimicControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_JimmySetzer_Goblins_SnoopGoblins_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck31_JimmySetzer_Goblins_SnoopGoblins_BR(),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck32_gobboboy_ToothAndNail_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck32_gobboboy_ToothAndNail_G(),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(ToothAndNail),
                null,
                null
            );
        }

        [Test]
        public void Deck33_mwapl_Goblins_SnoopGoblins_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck33_mwapl_Goblins_SnoopGoblins_BR(),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck34_Werepigs_DeathsShadow_MarduShadow_WBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck34_Werepigs_DeathsShadow_MarduShadow_WBR(),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(DeathsShadow),
                typeof(MarduShadow),
                null
            );
        }

        [Test]
        public void Deck35_vitto_Dredge_WBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck35_vitto_Dredge_WBRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck36_junghans_Devoted_WRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck36_junghans_Devoted_WRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck37_VFS_DimirControl_UB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck37_VFS_DimirControl_UB(),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(DimirControl),
                null,
                null
            );
        }

        [Test]
        public void Deck38_katuo079595_DeathsShadow_TraverseShadow_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck38_katuo079595_DeathsShadow_TraverseShadow_BRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(DeathsShadow),
                typeof(TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck39_SebastianStueckl_Goblins_SnoopGoblins_WBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck39_SebastianStueckl_Goblins_SnoopGoblins_WBR(),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck40_Archgaze_CrematorEvolution_WRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck40_Archgaze_CrematorEvolution_WRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(CrematorEvolution),
                null,
                null
            );
        }

        [Test]
        public void Deck41_Trellon_UTron_UB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck41_Trellon_UTron_UB(),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck42_Wuhsa_BringToNiv_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck42_Wuhsa_BringToNiv_WUBRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                null
            );
        }

        [Test]
        public void Deck43_Marxelo_Tokens_WB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck43_Marxelo_Tokens_WB(),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(Tokens),
                null,
                null
            );
        }

        [Test]
        public void Deck44_esatheking_Prowess_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck44_esatheking_Prowess_WR(),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck45_DenmarkDan_PrimevalTitan_TitanShift_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck45_DenmarkDan_PrimevalTitan_TitanShift_RG(),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck46_Thrall90_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck46_Thrall90_Rock_Jund_BRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck47_HouseOfManaMTG_GTron_KGCTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck47_HouseOfManaMTG_GTron_KGCTron_G(),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck48_Polikasoll_Prowess_IzzetProwess_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck48_Polikasoll_Prowess_IzzetProwess_UR(),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck49_Chaughey_Delver_JeskaiDelver_WUR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck49_Chaughey_Delver_JeskaiDelver_WUR(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(Delver),
                typeof(JeskaiDelver),
                null
            );
        }

        [Test]
        public void Deck50_Mussie99_AzoriusControl_AzoriusStoneblade_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck50_Mussie99_AzoriusControl_AzoriusStoneblade_WU(),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(AzoriusStoneblade),
                null
            );
        }

        [Test]
        public void Deck51_Ingles_Burn_IncineratorBurn_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck51_Ingles_Burn_IncineratorBurn_R(),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck52_cws_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck52_cws_GiftsStorm_UR(),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck53_MrRaeb_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck53_MrRaeb_Ponza_RG(),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck54_BlueLips_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck54_BlueLips_SnowControl_WUG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck55_KOKI12_AzoriusTempo_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck55_KOKI12_AzoriusTempo_WU(),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusTempo),
                null,
                null
            );
        }

        [Test]
        public void Deck56_SpiderSpace_DeathAndTaxes_W()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck56_SpiderSpace_DeathAndTaxes_W(),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(DeathAndTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck57_MadRamon_WildernessReclamation_TemurReclamation_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck57_MadRamon_WildernessReclamation_TemurReclamation_URG(),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(WildernessReclamation),
                typeof(TemurReclamation),
                null
            );
        }

        [Test]
        public void Deck58_FabriceK_SnowControl_SnowReclamation_UG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck58_FabriceK_SnowControl_SnowReclamation_UG_Yorion(),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck59_DreamsOfAshiok_Prowess_RakdosProwess_WBR_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck59_DreamsOfAshiok_Prowess_RakdosProwess_WBR_Lurrus(),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck60_GulDukat_Prowess_GruulProwess_RG_Jegantha()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck60_GulDukat_Prowess_GruulProwess_RG_Jegantha(),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Prowess),
                typeof(GruulProwess),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck61_penach010_Devoted_HeliodDevoted_WRG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck61_penach010_Devoted_HeliodDevoted_WRG_Yorion(),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck62_brainstorm39_JeskaiControl_WUR_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_24.Deck62_brainstorm39_JeskaiControl_WUR_Yorion(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(JeskaiControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }


    }
}
