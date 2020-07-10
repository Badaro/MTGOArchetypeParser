using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests
{
    public class EventTest_modern_league_2020_06_12 : EventTest
    {
        [Test]
        public void Deck01_in5ano_SnowControl_SnowShift_URG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck01_in5ano_SnowControl_SnowShift_URG_Yorion(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowShift),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_katobu_Merfolk_WU_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck02_katobu_Merfolk_WU_Lurrus(),
                ArchetypeColor.WU,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Merfolk),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_Blindside09_HardenedScales_BG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck03_Blindside09_HardenedScales_BG_Lurrus(),
                ArchetypeColor.BG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_CharlieStyle_Burn_WR_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck04_CharlieStyle_Burn_WR_Lurrus(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_Kurusu_KikiChord_WBRG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck05_Kurusu_KikiChord_WBRG_Yorion(),
                ArchetypeColor.WBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck06_faldon_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck06_faldon_GiftsStorm_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Urzza100_SnowControl_SnowTitan_WUG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck07_Urzza100_SnowControl_SnowTitan_WUG_Yorion(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowTitan),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck08_603Leb_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck08_603Leb_Ponza_RG(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck09_sydneydude_Prowess_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck09_sydneydude_Prowess_WR(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck10_rouleur_Prowess_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck10_rouleur_Prowess_R(),
                ArchetypeColor.R,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck11_yamayama_SnowControl_SnowReclamation_UBRG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck11_yamayama_SnowControl_SnowReclamation_UBRG_Yorion(),
                ArchetypeColor.UBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowReclamation),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck12_jimdownside_Aristocrats_WB_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck12_jimdownside_Aristocrats_WB_Lurrus(),
                ArchetypeColor.WB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Aristocrats),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_DannyBambino_Crabvine_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck13_DannyBambino_Crabvine_UBG(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck14_pbarrrgh_SnowControl_SnowReclamation_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck14_pbarrrgh_SnowControl_SnowReclamation_UBG(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck15_Zeranox_BantBlink_WUG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck15_Zeranox_BantBlink_WUG_Yorion(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.BantBlink),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck16_FlxEx_DeathsShadow_TraverseShadow_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck16_FlxEx_DeathsShadow_TraverseShadow_BRG(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck17_soba178_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck17_soba178_Humans_WUBRG(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck18_MrRaeb_Uroza_UBG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck18_MrRaeb_Uroza_UBG_Yorion(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_jessysamek_Uroza_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck19_jessysamek_Uroza_URG(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck20_B1gDan_DeathsShadow_MarduShadow_WBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck20_B1gDan_DeathsShadow_MarduShadow_WBR(),
                ArchetypeColor.WBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.MarduShadow),
                null
            );
        }

        [Test]
        public void Deck21_floatius_AzoriusControl_Miracles_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck21_floatius_AzoriusControl_Miracles_WU(),
                ArchetypeColor.WU,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AzoriusControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Miracles),
                null
            );
        }

        [Test]
        public void Deck22_osk4_BantBlink_WURG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck22_osk4_BantBlink_WURG_Yorion(),
                ArchetypeColor.WURG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.BantBlink),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck23_Lucabireskusku_Inverter_UB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck23_Lucabireskusku_Inverter_UB(),
                ArchetypeColor.UB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Inverter),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Netow_Bogles_WU_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck24_Netow_Bogles_WU_Lurrus(),
                ArchetypeColor.WU,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_lancetman2_Dredge_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck25_lancetman2_Dredge_BRG(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck26_jmoney10_SnowControl_SnowBlade_WUBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck26_jmoney10_SnowControl_SnowBlade_WUBG(),
                ArchetypeColor.WUBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowBlade),
                null
            );
        }

        [Test]
        public void Deck27_lovealienzzz_SnowControl_TemurSnow_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck27_lovealienzzz_SnowControl_TemurSnow_URG(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.TemurSnow),
                null
            );
        }

        [Test]
        public void Deck28_renatoaraujo_GTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck28_renatoaraujo_GTron_G(),
                ArchetypeColor.G,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GTron),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Traft_Goblins_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck29_Traft_Goblins_BRG(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Mordeka1ser_BringToNiv_WUBRG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck30_Mordeka1ser_BringToNiv_WUBRG_Yorion(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck31_anamika_GruulCompany_WURG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck31_anamika_GruulCompany_WURG(),
                ArchetypeColor.WURG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GruulCompany),
                null,
                null
            );
        }

        [Test]
        public void Deck32_DrD1ckForest_AdNauseam_WUB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck32_DrD1ckForest_AdNauseam_WUB(),
                ArchetypeColor.WUB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Mollok_ThaliaStompy_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck33_Mollok_ThaliaStompy_WR(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ThaliaStompy),
                null,
                null
            );
        }

        [Test]
        public void Deck34_knightmare21_IzzetControl_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck34_knightmare21_IzzetControl_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck35_albert62_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck35_albert62_Rock_Jund_BRG(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Jund),
                null
            );
        }

        [Test]
        public void Deck36_kuromatu_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck36_kuromatu_ETron_C(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck37_Nideon_DeathAndTaxes_EldraziTaxes_WB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck37_Nideon_DeathAndTaxes_EldraziTaxes_WB(),
                ArchetypeColor.WB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathAndTaxes),
                typeof(MTGOArchetypeParser.Archetypes.Modern.EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck38_nahuel10_SnowControl_WUBG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck38_nahuel10_SnowControl_WUBG_Yorion(),
                ArchetypeColor.WUBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck39_Zebrah_PrimevalTitan_AmuletTitan_WURG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck39_Zebrah_PrimevalTitan_AmuletTitan_WURG(),
                ArchetypeColor.WURG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck40_SawphtBoi_Winota_WRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck40_SawphtBoi_Winota_WRG(),
                ArchetypeColor.WRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Winota),
                null,
                null
            );
        }

        [Test]
        public void Deck41_Boland_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck41_Boland_DeathsShadow_GrixisShadow_UBR(),
                ArchetypeColor.UBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck42_marcofabrizi_SnowControl_SnowBlade_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck42_marcofabrizi_SnowControl_SnowBlade_WUG(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowBlade),
                null
            );
        }

        [Test]
        public void Deck43_robb93_UTron_U()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck43_robb93_UTron_U(),
                ArchetypeColor.U,
                typeof(MTGOArchetypeParser.Archetypes.Modern.UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck44_Misplacedginger_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12.Deck44_Misplacedginger_SnowControl_WUG(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }


    }
}
