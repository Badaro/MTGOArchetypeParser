using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_06_05_postcompanionchange
{
    public class EventTest_modern_league_2020_06_16 : EventTest
    {
        [Test]
        public void Deck01_Metcalf23_DeathAndTaxes_WR_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck01_Metcalf23_DeathAndTaxes_WR_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathAndTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_Manacymbal_KinnanUrza_URG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck02_Manacymbal_KinnanUrza_URG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.KinnanUrza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck03_jessysamek_Dredge_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck03_jessysamek_Dredge_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Heisenberg666_Burn_WRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck04_Heisenberg666_Burn_WRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck05_dch97e_Spirits_BantSpirits_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck05_dch97e_Spirits_BantSpirits_WUG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Spirits),
                typeof(MTGOArchetypeParser.Archetypes.Modern.BantSpirits),
                null
            );
        }

        [Test]
        public void Deck06_3HaLeX1_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck06_3HaLeX1_DeathsShadow_GrixisShadow_UBR(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck07_Thefan_BantBlink_WUG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck07_Thefan_BantBlink_WUG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.BantBlink),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck08_camr0n1_IzzetPhoenix_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck08_camr0n1_IzzetPhoenix_UR(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetPhoenix),
                null,
                null
            );
        }

        [Test]
        public void Deck09_KowV2_Uroza_UBG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck09_KowV2_Uroza_UBG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck10_gyyby297_ThopterUrza_UB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck10_gyyby297_ThopterUrza_UB(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck11_sneakyrobot_Infect_WG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck11_sneakyrobot_Infect_WG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck12_TuggaNaxos_SnowControl_SnowTurns_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck12_TuggaNaxos_SnowControl_SnowTurns_URG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowTurns),
                null
            );
        }

        [Test]
        public void Deck13_Simarisu_DeathsShadow_MarduShadow_WB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck13_Simarisu_DeathsShadow_MarduShadow_WB(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.MarduShadow),
                null
            );
        }

        [Test]
        public void Deck14_Rossello_AdNauseam_WUB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck14_Rossello_AdNauseam_WUB(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck15_osmanozguney_SnowControl_SultaiSnow_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck15_osmanozguney_SnowControl_SultaiSnow_UBG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck16_cjucjujp_EightWhack_AtarkaWhack_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck16_cjucjujp_EightWhack_AtarkaWhack_RG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.EightWhack),
                typeof(MTGOArchetypeParser.Archetypes.Modern.AtarkaWhack),
                null
            );
        }

        [Test]
        public void Deck17_kai2000_BringToNiv_WUBRG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck17_kai2000_BringToNiv_WUBRG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck18_Praxifi_Winota_WRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck18_Praxifi_Winota_WRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Winota),
                null,
                null
            );
        }

        [Test]
        public void Deck19_miki665_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck19_miki665_Humans_WUBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Nideon_DeathAndTaxes_EldraziTaxes_WB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck20_Nideon_DeathAndTaxes_EldraziTaxes_WB(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathAndTaxes),
                typeof(MTGOArchetypeParser.Archetypes.Modern.EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck21_tuckerde_PrimevalTitan_AmuletTitan_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck21_tuckerde_PrimevalTitan_AmuletTitan_WUBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck22_Wuhsa_BringToNiv_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck22_Wuhsa_BringToNiv_WUBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.BringToNiv),
                null,
                null
            );
        }

        [Test]
        public void Deck23_iuriper_Merfolk_UB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck23_iuriper_Merfolk_UB(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck24_DemianDesposito10_Prowess_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck24_DemianDesposito10_Prowess_R(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.R,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Kurusu_KikiChord_WBRG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck25_Kurusu_KikiChord_WBRG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck26_shine0905_GyrudaStompy_BRG_Gyruda()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck26_shine0905_GyrudaStompy_BRG_Gyruda(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GyrudaStompy),
                null,
                ArchetypeCompanion.Gyruda
            );
        }

        [Test]
        public void Deck27_waru_Merfolk_WU_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck27_waru_Merfolk_WU_Lurrus(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WU,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Merfolk),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_GameNight_Winota_WRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck28_GameNight_Winota_WRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Winota),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Gabriel0288_PrimevalTitan_UBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck29_Gabriel0288_PrimevalTitan_UBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Kaipa_Burn_WR_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck30_Kaipa_Burn_WR_Lurrus(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_FatChocobo_Goblins_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck31_FatChocobo_Goblins_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck32_crexalbo_TwiddleStorm_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck32_crexalbo_TwiddleStorm_URG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.TwiddleStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck33_pbarrrgh_SnowControl_SnowReclamation_URG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck33_pbarrrgh_SnowControl_SnowReclamation_URG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowReclamation),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck34_cesar189350_JeskaiControl_JeskaiFlash_WUR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck34_cesar189350_JeskaiControl_JeskaiFlash_WUR(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.JeskaiControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.JeskaiFlash),
                null
            );
        }

        [Test]
        public void Deck35_Miqa_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck35_Miqa_ETron_C(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck36_Jidden_ThopterUrza_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck36_Jidden_ThopterUrza_WU(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WU,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck37_teagantime_SnowControl_SnowTitan_WUG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck37_teagantime_SnowControl_SnowTitan_WUG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowTitan),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck38_Tarrasque1_Elementals_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck38_Tarrasque1_Elementals_WUBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck39_FreshKale_GTron_GolosTron_G_Jegantha()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck39_FreshKale_GTron_GolosTron_G_Jegantha(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.G,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GTron),
                typeof(MTGOArchetypeParser.Archetypes.Modern.GolosTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck40_FreedMania_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck40_FreedMania_SnowControl_WUG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck41_mashmalovsky_Smallpox_WB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck41_mashmalovsky_Smallpox_WB(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Smallpox),
                null,
                null
            );
        }

        [Test]
        public void Deck42_sendoh007_Devoted_WG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck42_sendoh007_Devoted_WG_Lurrus(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck43_JRDC14_SnowControl_SnowShift_URG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck43_JRDC14_SnowControl_SnowShift_URG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowShift),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck44_ScreenwriterNY_Zoo_BushwhackerZoo_WRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck44_ScreenwriterNY_Zoo_BushwhackerZoo_WRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Zoo),
                typeof(MTGOArchetypeParser.Archetypes.Modern.BushwhackerZoo),
                null
            );
        }

        [Test]
        public void Deck45_martindoktor_AzoriusControl_Miracles_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck45_martindoktor_AzoriusControl_Miracles_WU(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WU,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AzoriusControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Miracles),
                null
            );
        }

        [Test]
        public void Deck46_bamzing_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck46_bamzing_Ponza_RG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck47_TheWonderLord_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck47_TheWonderLord_Rock_Jund_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Jund),
                null
            );
        }

        [Test]
        public void Deck48_Munin40_Rock_BG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck48_Munin40_Rock_BG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.BG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                null,
                null
            );
        }

        [Test]
        public void Deck49_qbturtle15_Ponza_RG_Obosh()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck49_qbturtle15_Ponza_RG_Obosh(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck50_fsst_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck50_fsst_GiftsStorm_UR(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck51_JMoney8771_Infect_UG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck51_JMoney8771_Infect_UG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck52_122pablo_JeskaiAscendancy_WURG_Jegantha()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck52_122pablo_JeskaiAscendancy_WURG_Jegantha(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WURG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.JeskaiAscendancy),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck53_maple049_HardenedScales_WG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck53_maple049_HardenedScales_WG_Lurrus(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck54_drRobotGranata_PrimevalTitan_TitanShift_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck54_drRobotGranata_PrimevalTitan_TitanShift_RG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.TitanShift),
                null
            );
        }

        [Test]
        public void Deck55_MHayashi_RedDeckWins_R_Jegantha()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck55_MHayashi_RedDeckWins_R_Jegantha(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.R,
                typeof(MTGOArchetypeParser.Archetypes.Modern.RedDeckWins),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck56_erose199423_ThopterUrza_WUR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck56_erose199423_ThopterUrza_WUR(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck57_daifuku_SnowControl_TemurSnow_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck57_daifuku_SnowControl_TemurSnow_URG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.TemurSnow),
                null
            );
        }

        [Test]
        public void Deck58_abijhavs_Prowess_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck58_abijhavs_Prowess_R(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.R,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck59_MlckyB_Bogles_WG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16.Deck59_MlckyB_Bogles_WG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Bogles),
                null,
                null
            );
        }


    }
}
