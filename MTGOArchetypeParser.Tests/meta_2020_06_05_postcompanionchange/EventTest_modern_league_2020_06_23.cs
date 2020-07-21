using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_06_05_postcompanionchange
{
    public class EventTest_modern_league_2020_06_23 : EventTest
    {
        [Test]
        public void Deck01_Erik157751_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck01_Erik157751_ETron_C(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Metcalf23_DeathAndTaxes_WG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck02_Metcalf23_DeathAndTaxes_WG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathAndTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck03_pbarrrgh_SnowControl_SnowReclamation_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck03_pbarrrgh_SnowControl_SnowReclamation_UBG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck04_AlexFromTheNorth_BushwhackerZoo_WRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck04_AlexFromTheNorth_BushwhackerZoo_WRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.BushwhackerZoo),
                null,
                null
            );
        }

        [Test]
        public void Deck05_zachattack23_SnowControl_SnowReclamation_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck05_zachattack23_SnowControl_SnowReclamation_URG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck06_Avixy_Devoted_WG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck06_Avixy_Devoted_WG_Lurrus(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_vagnermtg_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck07_vagnermtg_DeathsShadow_GrixisShadow_UBR(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck08_PietroSas_Merfolk_U()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck08_PietroSas_Merfolk_U(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.U,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Somniloquist_DeathsShadow_SuicideShadow_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck09_Somniloquist_DeathsShadow_SuicideShadow_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SuicideShadow),
                null
            );
        }

        [Test]
        public void Deck10_forenmagra_SaheeliToLight_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck10_forenmagra_SaheeliToLight_WUBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SaheeliToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Snipersarebums_BringToNiv_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck11_Snipersarebums_BringToNiv_WUBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.BringToNiv),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Ingalsarm_Uroza_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck12_Ingalsarm_Uroza_URG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck13_LordoftheLobsters_SnowControl_WURG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck13_LordoftheLobsters_SnowControl_WURG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WURG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck14_mtgmonte_DeathsShadow_TraverseShadow_UBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck14_mtgmonte_DeathsShadow_TraverseShadow_UBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck15_didoguidotti1_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck15_didoguidotti1_SnowControl_WUG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck16_robb93_AdNauseam_WUB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck16_robb93_AdNauseam_WUB(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck17_fenix4444_GTron_KGCTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck17_fenix4444_GTron_KGCTron_G(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.G,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GTron),
                typeof(MTGOArchetypeParser.Archetypes.Modern.KGCTron),
                null
            );
        }

        [Test]
        public void Deck18_YBLime_ThopterUrza_WUBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck18_YBLime_ThopterUrza_WUBR(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck19_aspiringspike_GrixisLurrus_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck19_aspiringspike_GrixisLurrus_UBR(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GrixisLurrus),
                null,
                null
            );
        }

        [Test]
        public void Deck20_shine0905_GyrudaStompy_BRG_Gyruda()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck20_shine0905_GyrudaStompy_BRG_Gyruda(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GyrudaStompy),
                null,
                ArchetypeCompanion.Gyruda
            );
        }

        [Test]
        public void Deck21_MHayashi_RedDeckWins_WR_Jegantha()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck21_MHayashi_RedDeckWins_WR_Jegantha(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.RedDeckWins),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck22_Granham_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck22_Granham_Rock_Jund_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Jund),
                null
            );
        }

        [Test]
        public void Deck23_abombdiggity_Slivers_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck23_abombdiggity_Slivers_WUBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Slivers),
                null,
                null
            );
        }

        [Test]
        public void Deck24_milikin_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck24_milikin_Ponza_RG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Jidden_ThopterUrza_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck25_Jidden_ThopterUrza_WU(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WU,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck26_saccij92_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck26_saccij92_Humans_WUBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Karstinen_Bogles_WG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck27_Karstinen_Bogles_WG_Lurrus(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_KAKOLOLO_BushwhackerZoo_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck28_KAKOLOLO_BushwhackerZoo_RG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.BushwhackerZoo),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Darthtaneon_BushwhackerZoo_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck29_Darthtaneon_BushwhackerZoo_RG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.BushwhackerZoo),
                null,
                null
            );
        }

        [Test]
        public void Deck30_edward40hands_Rock_BG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck30_edward40hands_Rock_BG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.BG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                null,
                null
            );
        }

        [Test]
        public void Deck31_GodsShadow_GrixisControl_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck31_GodsShadow_GrixisControl_UBR(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GrixisControl),
                null,
                null
            );
        }

        [Test]
        public void Deck32_thepensword_Prowess_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck32_thepensword_Prowess_R(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.R,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck33_vasko19_IzzetFreeSpells_ElectroBalance_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck33_vasko19_IzzetFreeSpells_ElectroBalance_URG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetFreeSpells),
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck34_Ftzz_WildernessReclamation_ReclamationTeachings_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck34_Ftzz_WildernessReclamation_ReclamationTeachings_UBG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.WildernessReclamation),
                typeof(MTGOArchetypeParser.Archetypes.Modern.ReclamationTeachings),
                null
            );
        }

        [Test]
        public void Deck35_Juaspas_PrimevalTitan_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck35_Juaspas_PrimevalTitan_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck36_MrRaeb_Uroza_UBG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck36_MrRaeb_Uroza_UBG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck37_jessysamek_Dredge_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck37_jessysamek_Dredge_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck38_Yumas2_PrimevalTitan_AmuletTitan_WURG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck38_Yumas2_PrimevalTitan_AmuletTitan_WURG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WURG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck39_RockStar_Prowess_RakdosProwess_BR_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck39_RockStar_Prowess_RakdosProwess_BR_Lurrus(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                typeof(MTGOArchetypeParser.Archetypes.Modern.RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck40_NorrathDecay_Burn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck40_NorrathDecay_Burn_WR(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck41_bozo2112_Crabvine_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck41_bozo2112_Crabvine_UBG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck42_yutya_SnowControl_SnowTitan_WUG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck42_yutya_SnowControl_SnowTitan_WUG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowTitan),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck43_kg_Yawgmoth_BG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck43_kg_Yawgmoth_BG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.BG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck44_Metcalf23_DeathAndTaxes_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck44_Metcalf23_DeathAndTaxes_WR(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathAndTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck45_derramedefogo_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck45_derramedefogo_GiftsStorm_UR(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck46_Zeekery_ThingAscension_WUR_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck46_Zeekery_ThingAscension_WUR_Lurrus(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ThingAscension),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck47_in5ano_SnowControl_SnowShift_URG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck47_in5ano_SnowControl_SnowShift_URG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowShift),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck48_cjucjujp_HardenedScales_BG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck48_cjucjujp_HardenedScales_BG_Lurrus(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.BG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck49_Pollu_AdNauseam_WUB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck49_Pollu_AdNauseam_WUB(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck50_Gleiciano_PrimevalTitan_TitanShift_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck50_Gleiciano_PrimevalTitan_TitanShift_RG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.TitanShift),
                null
            );
        }

        [Test]
        public void Deck51_SvenSveeterSven_IzzetControl_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck51_SvenSveeterSven_IzzetControl_UR(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck52_Papelucho10_Infect_UG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck52_Papelucho10_Infect_UG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck53_Yanti_Bogles_WU_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23.Deck53_Yanti_Bogles_WU_Lurrus(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WU,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
