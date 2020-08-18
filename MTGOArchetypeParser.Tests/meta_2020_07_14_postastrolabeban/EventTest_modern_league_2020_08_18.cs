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
    public class EventTest_modern_league_2020_08_18 : EventTest
    {
        [Test]
        public void Deck01_llabmonkey_SnowControl_SnowBlade_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck01_llabmonkey_SnowControl_SnowBlade_WUG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowBlade),
                null
            );
        }

        [Test]
        public void Deck02_aspiringspike_BantBlink_WUG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck02_aspiringspike_BantBlink_WUG_Yorion(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantBlink),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck03_Albyz_MarduPyromancer_WBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck03_Albyz_MarduPyromancer_WBR(),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(MarduPyromancer),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Nallemon_EightRack_B()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck04_Nallemon_EightRack_B(),
                new PostAstrolabeBan(),
                ArchetypeColor.B,
                typeof(EightRack),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Proliferate_Bogles_WG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck05_Proliferate_Bogles_WG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Parrit_DeathAndTaxes_EldraziTaxes_WG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck06_Parrit_DeathAndTaxes_EldraziTaxes_WG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(DeathAndTaxes),
                typeof(EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck07_Jiggywiggy_KinnanMentor_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck07_Jiggywiggy_KinnanMentor_WUG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(KinnanMentor),
                null,
                null
            );
        }

        [Test]
        public void Deck08_TuggaNaxos_Infect_BG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck08_TuggaNaxos_Infect_BG(),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck09_kensportsfan_Prowess_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck09_kensportsfan_Prowess_R(),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck10_sakuragi21722749_HeliodCombo_WG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck10_sakuragi21722749_HeliodCombo_WG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck11_shoiwao_Devoted_HeliodDevoted_WBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck11_shoiwao_Devoted_HeliodDevoted_WBG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                null
            );
        }

        [Test]
        public void Deck12_Azerate218_DeathsShadow_TraverseShadow_UBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck12_Azerate218_DeathsShadow_TraverseShadow_UBRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(DeathsShadow),
                typeof(TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck13_SvenSveeterSven_IzzetControl_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck13_SvenSveeterSven_IzzetControl_UR(),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Albyz_BringToNiv_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck14_Albyz_BringToNiv_WUBRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Carton_DeathsShadow_EsperShadow_WUB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck15_Carton_DeathsShadow_EsperShadow_WUB(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(DeathsShadow),
                typeof(EsperShadow),
                null
            );
        }

        [Test]
        public void Deck16_Bobthebuilder24_SoulSisters_HeliodSisters_W()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck16_Bobthebuilder24_SoulSisters_HeliodSisters_W(),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(SoulSisters),
                typeof(HeliodSisters),
                null
            );
        }

        [Test]
        public void Deck17_waffl3haos_DeathAndTaxes_EldraziTaxes_WB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck17_waffl3haos_DeathAndTaxes_EldraziTaxes_WB(),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(DeathAndTaxes),
                typeof(EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck18_harukispecial_SnowControl_SultaiSnow_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck18_harukispecial_SnowControl_SultaiSnow_UBG(),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck19_RyanWu_OrzhovMidrange_WB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck19_RyanWu_OrzhovMidrange_WB(),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(OrzhovMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck20_ben1234_WildernessReclamation_TemurReclamation_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck20_ben1234_WildernessReclamation_TemurReclamation_URG(),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(WildernessReclamation),
                typeof(TemurReclamation),
                null
            );
        }

        [Test]
        public void Deck21_CodeProvider_Grishoalbrand_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck21_CodeProvider_Grishoalbrand_BR(),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Grishoalbrand),
                null,
                null
            );
        }

        [Test]
        public void Deck22_sfitz_ThopterUrza_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck22_sfitz_ThopterUrza_UBR(),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Wuhsa_BringToNiv_WUBRG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck23_Wuhsa_BringToNiv_WUBRG_Yorion(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck24_Ghost_Burn_WRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck24_Ghost_Burn_WRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Tedpanic_AzoriusControl_Miracles_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck25_Tedpanic_AzoriusControl_Miracles_WU(),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(Miracles),
                null
            );
        }

        [Test]
        public void Deck26_Irra0770_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck26_Irra0770_Rock_Jund_BRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck27_Mulldrifter_Dredge_WBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck27_Mulldrifter_Dredge_WBRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Copilot11_IzzetControl_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck28_Copilot11_IzzetControl_UR(),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck29_hanrahandh_Elves_DevotedElves_WG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck29_hanrahandh_Elves_DevotedElves_WG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Elves),
                typeof(DevotedElves),
                null
            );
        }

        [Test]
        public void Deck30_SickWorld_Burn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck30_SickWorld_Burn_WR(),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Bryzem1_Prowess_IzzetProwess_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck31_Bryzem1_Prowess_IzzetProwess_UR(),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck32_Metcalf23_DeathAndTaxes_WR_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck32_Metcalf23_DeathAndTaxes_WR_Lurrus(),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(DeathAndTaxes),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck33_hizakura_Polymorph_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck33_hizakura_Polymorph_RG(),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Polymorph),
                null,
                null
            );
        }

        [Test]
        public void Deck34_DarkKeeper_BantControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck34_DarkKeeper_BantControl_WUG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantControl),
                null,
                null
            );
        }

        [Test]
        public void Deck35_rodebo_UTron_U()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck35_rodebo_UTron_U(),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck36_kogamo_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck36_kogamo_DeathsShadow_GrixisShadow_UBR(),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck37_Cheerios_WildernessReclamation_UG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck37_Cheerios_WildernessReclamation_UG(),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(WildernessReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck38_paynechips_GTron_KGCTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck38_paynechips_GTron_KGCTron_G(),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck39_kogamo_AzoriusControl_AzoriusStoneblade_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck39_kogamo_AzoriusControl_AzoriusStoneblade_WU(),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(AzoriusStoneblade),
                null
            );
        }

        [Test]
        public void Deck40_brainstorm39_JeskaiControl_WUR_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck40_brainstorm39_JeskaiControl_WUR_Yorion(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(JeskaiControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck41_Otmos_Prowess_WR_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck41_Otmos_Prowess_WR_Lurrus(),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Prowess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck42_Storytime_Devoted_KinnanDevoted_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck42_Storytime_Devoted_KinnanDevoted_WUG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                typeof(KinnanDevoted),
                null
            );
        }

        [Test]
        public void Deck43_122pablo_JeskaiAscendancy_WURG_Jegantha()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck43_122pablo_JeskaiAscendancy_WURG_Jegantha(),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(JeskaiAscendancy),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck44_JimmySetzer_Goblins_SnoopGoblins_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck44_JimmySetzer_Goblins_SnoopGoblins_BR(),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck45_fsst_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck45_fsst_GiftsStorm_UR(),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck46_Tarmofir3_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck46_Tarmofir3_Rock_Jund_BRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck47_Polikasoll_Burn_IncineratorBurn_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck47_Polikasoll_Burn_IncineratorBurn_R(),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck48_TheGingerBrute_Faeries_UB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck48_TheGingerBrute_Faeries_UB(),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(Faeries),
                null,
                null
            );
        }

        [Test]
        public void Deck49_dabigatran_Spirits_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck49_dabigatran_Spirits_WU(),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck50_Xenowan_HardenedScales_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck50_Xenowan_HardenedScales_G(),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck51_TheCodyHope_Elementals_WUBRG_Kaheera()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck51_TheCodyHope_Elementals_WUBRG_Kaheera(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                ArchetypeCompanion.Kaheera
            );
        }

        [Test]
        public void Deck52_Menoti_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck52_Menoti_ETron_C(),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck53_SpikeYou_IzzetFreeSpells_IzzetRestoreBalance_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck53_SpikeYou_IzzetFreeSpells_IzzetRestoreBalance_UR(),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck54_kado222_GoryoReanimator_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck54_kado222_GoryoReanimator_BRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GoryoReanimator),
                null,
                null
            );
        }

        [Test]
        public void Deck55_CaptainFarbosa_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck55_CaptainFarbosa_Ponza_RG(),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck56_cccaspar_WhiteDevotion_W()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck56_cccaspar_WhiteDevotion_W(),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(WhiteDevotion),
                null,
                null
            );
        }

        [Test]
        public void Deck57_kogamo_PrimevalTitan_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck57_kogamo_PrimevalTitan_URG(),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck58_Taragon_Devoted_WG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck58_Taragon_Devoted_WG_Lurrus(),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck59_marcosrocha_Infect_UG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck59_marcosrocha_Infect_UG(),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck60_tuhoajatane_TitanVial_WRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck60_tuhoajatane_TitanVial_WRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(TitanVial),
                null,
                null
            );
        }

        [Test]
        public void Deck61_Alzik_Prowess_RakdosProwess_BR_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck61_Alzik_Prowess_RakdosProwess_BR_Lurrus(),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck62_MartinezDP_BringToNiv_WUBRG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck62_MartinezDP_BringToNiv_WUBRG_Yorion(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck63_scipios_Crabvine_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck63_scipios_Crabvine_UBG(),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck64_SunnyOsRego_RakdosMidrange_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck64_SunnyOsRego_RakdosMidrange_BR(),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(RakdosMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck65_musasabi_PrimevalTitan_KGCAmuletTitan_UBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck65_musasabi_PrimevalTitan_KGCAmuletTitan_UBRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck66_Widok_AdNauseam_WUB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck66_Widok_AdNauseam_WUB(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck67_MHayashi_RedDeckWins_R_Jegantha()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck67_MHayashi_RedDeckWins_R_Jegantha(),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(RedDeckWins),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck68_PurpleRain_Scapeshift_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck68_PurpleRain_Scapeshift_URG(),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck69_Jidden_ThopterUrza_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck69_Jidden_ThopterUrza_WU(),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck70_tcgshin_PrimevalTitan_TitanShift_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck70_tcgshin_PrimevalTitan_TitanShift_RG(),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck71_DcNo_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck71_DcNo_Humans_WUBRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck72_FriskiFraska_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck72_FriskiFraska_Ponza_RG(),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck73_Thrall90_Rock_BG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18.Deck73_Thrall90_Rock_BG(),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Rock),
                null,
                null
            );
        }


    }
}
