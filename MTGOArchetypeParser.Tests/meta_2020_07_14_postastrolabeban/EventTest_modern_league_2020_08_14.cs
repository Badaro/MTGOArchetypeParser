using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_league_2020_08_14 : EventTest
    {
        [Test]
        public void Deck01_EddDeedoo_OrzhovMidrange_WB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck01_EddDeedoo_OrzhovMidrange_WB(),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(OrzhovMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck02_nahuel10_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck02_nahuel10_Ponza_RG(),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck03_ZYXJerry_RedDeckWins_R_Obosh()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck03_ZYXJerry_RedDeckWins_R_Obosh(),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(RedDeckWins),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck04_SpoonDonkey_IzzetControl_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck04_SpoonDonkey_IzzetControl_UR(),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_DoctorQueller_Spirits_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck05_DoctorQueller_Spirits_WU(),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck06_PhantasmalBear_AzoriusTempo_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck06_PhantasmalBear_AzoriusTempo_WU(),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusTempo),
                null,
                null
            );
        }

        [Test]
        public void Deck07_bobthedog_SoulSisters_HeliodSisters_W()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck07_bobthedog_SoulSisters_HeliodSisters_W(),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(SoulSisters),
                typeof(HeliodSisters),
                null
            );
        }

        [Test]
        public void Deck08_tnequipa_Bogles_WG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck08_tnequipa_Bogles_WG_Lurrus(),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_MrQ4_AdNauseam_WUB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck09_MrQ4_AdNauseam_WUB(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck10_TheDuinoElegies_Prowess_WR_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck10_TheDuinoElegies_Prowess_WR_Lurrus(),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Prowess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_IzzetSignetIsTheBest_PrimevalTitan_AmuletTitan_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck11_IzzetSignetIsTheBest_PrimevalTitan_AmuletTitan_WUBRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck12_Sprouts_Rock_WBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck12_Sprouts_Rock_WBG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(Rock),
                null,
                null
            );
        }

        [Test]
        public void Deck13_BigDadChad_GreenDevotion_UG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck13_BigDadChad_GreenDevotion_UG(),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(GreenDevotion),
                null,
                null
            );
        }

        [Test]
        public void Deck14_olea_HeliodCombo_WG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck14_olea_HeliodCombo_WG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Menoti_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck15_Menoti_ETron_C(),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Hipmon_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck16_Hipmon_DeathsShadow_GrixisShadow_UBR(),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck17_Alzik_Prowess_RakdosProwess_BR_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck17_Alzik_Prowess_RakdosProwess_BR_Lurrus(),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_rafp_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck18_rafp_Humans_WUBRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck19_TLaros_PrimevalTitan_TitanShift_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck19_TLaros_PrimevalTitan_TitanShift_RG(),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck20_ChaoticCamel_DeathsShadow_TraverseShadow_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck20_ChaoticCamel_DeathsShadow_TraverseShadow_BRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(DeathsShadow),
                typeof(TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck21_Jaberwocki_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck21_Jaberwocki_Rock_Jund_BRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck22_Bugsy69_Prowess_IzzetProwess_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck22_Bugsy69_Prowess_IzzetProwess_UR(),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck23_Predicted_Yawgmoth_WBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck23_Predicted_Yawgmoth_WBG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck24_toutoIsle_Dredge_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck24_toutoIsle_Dredge_BRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck25_JRDC14_BringToNiv_WUBRG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck25_JRDC14_BringToNiv_WUBRG_Yorion(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck26_Rebus8_DeathAndTaxes_EldraziTaxes_WB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck26_Rebus8_DeathAndTaxes_EldraziTaxes_WB(),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(DeathAndTaxes),
                typeof(EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck27_tbrantl99_TitanVial_WRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck27_tbrantl99_TitanVial_WRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(TitanVial),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Do0mSwitch_BantControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck28_Do0mSwitch_BantControl_WUG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantControl),
                null,
                null
            );
        }

        [Test]
        public void Deck29_BaDzIo_Prowess_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck29_BaDzIo_Prowess_R(),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Elibaechan_Goblins_SnoopGoblins_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck30_Elibaechan_Goblins_SnoopGoblins_BRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck31_heyakita_SaheeliCombo_SnowSaheeli_WURG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck31_heyakita_SaheeliCombo_SnowSaheeli_WURG_Yorion(),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(SnowSaheeli),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck32_Galanator_AzoriusControl_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck32_Galanator_AzoriusControl_WU(),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                null,
                null
            );
        }

        [Test]
        public void Deck33_MioCid_Scapeshift_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck33_MioCid_Scapeshift_URG(),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck34_Middeterminist_WildernessReclamation_UG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck34_Middeterminist_WildernessReclamation_UG(),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(WildernessReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck35_Thefrenchgoblin_AzoriusControl_AzoriusStoneblade_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck35_Thefrenchgoblin_AzoriusControl_AzoriusStoneblade_WU(),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(AzoriusStoneblade),
                null
            );
        }

        [Test]
        public void Deck36_ferrum0728_DeathsShadow_MarduShadow_WBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck36_ferrum0728_DeathsShadow_MarduShadow_WBR(),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(DeathsShadow),
                typeof(MarduShadow),
                null
            );
        }

        [Test]
        public void Deck37_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck37_Kurusu_KikiChord_WRG_Yorion(),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck38_Parrit_DeathAndTaxes_EldraziTaxes_WG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck38_Parrit_DeathAndTaxes_EldraziTaxes_WG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(DeathAndTaxes),
                typeof(EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck39_Ennuixd_WildernessReclamation_TemurReclamation_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck39_Ennuixd_WildernessReclamation_TemurReclamation_URG(),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(WildernessReclamation),
                typeof(TemurReclamation),
                null
            );
        }

        [Test]
        public void Deck40_kokoko098_Devoted_HeliodDevoted_WBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck40_kokoko098_Devoted_HeliodDevoted_WBG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                null
            );
        }

        [Test]
        public void Deck41_Maxtick_SnowControl_SnowBlade_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck41_Maxtick_SnowControl_SnowBlade_WUG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowBlade),
                null
            );
        }

        [Test]
        public void Deck42_gazmon48_GTron_KGCTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck42_gazmon48_GTron_KGCTron_G(),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck43_mjoe_BantBlink_WUBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck43_mjoe_BantBlink_WUBG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBG,
                typeof(BantBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck44_TuggaNaxos_WildernessReclamation_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck44_TuggaNaxos_WildernessReclamation_UBG(),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(WildernessReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck45_vasko19_IzzetFreeSpells_IzzetRestoreBalance_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck45_vasko19_IzzetFreeSpells_IzzetRestoreBalance_URG(),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck46_Flaxh_DimirControl_UB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck46_Flaxh_DimirControl_UB(),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(DimirControl),
                null,
                null
            );
        }

        [Test]
        public void Deck47_Beicodegeia_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck47_Beicodegeia_GiftsStorm_UR(),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck48_comradGT_Tokens_WB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck48_comradGT_Tokens_WB(),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(Tokens),
                null,
                null
            );
        }

        [Test]
        public void Deck49_Werebere_Burn_WRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck49_Werebere_Burn_WRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck50_Zxrogue_AzoriusControl_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck50_Zxrogue_AzoriusControl_WU(),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                null,
                null
            );
        }

        [Test]
        public void Deck51_Chaughey_Delver_JeskaiDelver_WUR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck51_Chaughey_Delver_JeskaiDelver_WUR(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(Delver),
                typeof(JeskaiDelver),
                null
            );
        }

        [Test]
        public void Deck52_Somefellow_UTron_UB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_14.Deck52_Somefellow_UTron_UB(),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(UTron),
                null,
                null
            );
        }


    }
}
