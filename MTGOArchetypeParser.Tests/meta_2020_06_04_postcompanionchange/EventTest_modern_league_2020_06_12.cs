using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_league_2020_06_12 : EventTest
    {
        [Test]
        public void Deck01_in5ano_SnowControl_SnowShift_URG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck01_in5ano_SnowControl_SnowShift_URG_Yorion(),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(SnowShift),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_katobu_Merfolk_WU_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck02_katobu_Merfolk_WU_Lurrus(),
                new PostCompanionChange(),
                ArchetypeColor.WU,
                typeof(Merfolk),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_Blindside09_HardenedScales_BG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck03_Blindside09_HardenedScales_BG_Lurrus(),
                new PostCompanionChange(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_CharlieStyle_Burn_WR_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck04_CharlieStyle_Burn_WR_Lurrus(),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_Kurusu_KikiChord_WBRG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck05_Kurusu_KikiChord_WBRG_Yorion(),
                new PostCompanionChange(),
                ArchetypeColor.WBRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck06_faldon_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck06_faldon_GiftsStorm_UR(),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Urzza100_SnowControl_SnowTitan_WUG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck07_Urzza100_SnowControl_SnowTitan_WUG_Yorion(),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowTitan),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck08_603Leb_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck08_603Leb_Ponza_RG(),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck09_sydneydude_Prowess_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck09_sydneydude_Prowess_WR(),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck10_rouleur_Prowess_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck10_rouleur_Prowess_R(),
                new PostCompanionChange(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck11_yamayama_SnowControl_SnowReclamation_UBRG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck11_yamayama_SnowControl_SnowReclamation_UBRG_Yorion(),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck12_jimdownside_Aristocrats_WB_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck12_jimdownside_Aristocrats_WB_Lurrus(),
                new PostCompanionChange(),
                ArchetypeColor.WB,
                typeof(Aristocrats),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_DannyBambino_Crabvine_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck13_DannyBambino_Crabvine_UBG(),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck14_pbarrrgh_SnowControl_SnowReclamation_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck14_pbarrrgh_SnowControl_SnowReclamation_UBG(),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck15_Zeranox_BantBlink_WUG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck15_Zeranox_BantBlink_WUG_Yorion(),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(BantBlink),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck16_FlxEx_DeathsShadow_TraverseShadow_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck16_FlxEx_DeathsShadow_TraverseShadow_BRG(),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(DeathsShadow),
                typeof(TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck17_soba178_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck17_soba178_Humans_WUBRG(),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck18_MrRaeb_Uroza_UBG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck18_MrRaeb_Uroza_UBG_Yorion(),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_jessysamek_Uroza_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck19_jessysamek_Uroza_URG(),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck20_B1gDan_DeathsShadow_MarduShadow_WBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck20_B1gDan_DeathsShadow_MarduShadow_WBR(),
                new PostCompanionChange(),
                ArchetypeColor.WBR,
                typeof(DeathsShadow),
                typeof(MarduShadow),
                null
            );
        }

        [Test]
        public void Deck21_floatius_AzoriusControl_Miracles_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck21_floatius_AzoriusControl_Miracles_WU(),
                new PostCompanionChange(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(Miracles),
                null
            );
        }

        [Test]
        public void Deck22_osk4_BantBlink_WURG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck22_osk4_BantBlink_WURG_Yorion(),
                new PostCompanionChange(),
                ArchetypeColor.WURG,
                typeof(BantBlink),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck23_Lucabireskusku_Inverter_UB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck23_Lucabireskusku_Inverter_UB(),
                new PostCompanionChange(),
                ArchetypeColor.UB,
                typeof(Inverter),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Netow_Bogles_WU_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck24_Netow_Bogles_WU_Lurrus(),
                new PostCompanionChange(),
                ArchetypeColor.WU,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_lancetman2_Dredge_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck25_lancetman2_Dredge_BRG(),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck26_jmoney10_SnowControl_SnowBlade_WUBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck26_jmoney10_SnowControl_SnowBlade_WUBG(),
                new PostCompanionChange(),
                ArchetypeColor.WUBG,
                typeof(SnowControl),
                typeof(SnowBlade),
                null
            );
        }

        [Test]
        public void Deck27_lovealienzzz_SnowControl_TemurSnow_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck27_lovealienzzz_SnowControl_TemurSnow_URG(),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(TemurSnow),
                null
            );
        }

        [Test]
        public void Deck28_renatoaraujo_GTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck28_renatoaraujo_GTron_G(),
                new PostCompanionChange(),
                ArchetypeColor.G,
                typeof(GTron),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Traft_Goblins_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck29_Traft_Goblins_BRG(),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Mordeka1ser_BringToNiv_WUBRG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck30_Mordeka1ser_BringToNiv_WUBRG_Yorion(),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck31_anamika_GruulCompany_WURG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck31_anamika_GruulCompany_WURG(),
                new PostCompanionChange(),
                ArchetypeColor.WURG,
                typeof(GruulCompany),
                null,
                null
            );
        }

        [Test]
        public void Deck32_DrD1ckForest_AdNauseam_WUB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck32_DrD1ckForest_AdNauseam_WUB(),
                new PostCompanionChange(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Mollok_DeathAndTaxes_ThaliaStompy_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck33_Mollok_DeathAndTaxes_ThaliaStompy_WR(),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(DeathAndTaxes),
                typeof(ThaliaStompy),
                null
            );
        }

        [Test]
        public void Deck34_knightmare21_IzzetControl_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck34_knightmare21_IzzetControl_UR(),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck35_albert62_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck35_albert62_Rock_Jund_BRG(),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck36_kuromatu_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck36_kuromatu_ETron_C(),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck37_Nideon_DeathAndTaxes_EldraziTaxes_WB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck37_Nideon_DeathAndTaxes_EldraziTaxes_WB(),
                new PostCompanionChange(),
                ArchetypeColor.WB,
                typeof(DeathAndTaxes),
                typeof(EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck38_nahuel10_SnowControl_WUBG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck38_nahuel10_SnowControl_WUBG_Yorion(),
                new PostCompanionChange(),
                ArchetypeColor.WUBG,
                typeof(SnowControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck39_Zebrah_PrimevalTitan_AmuletTitan_WURG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck39_Zebrah_PrimevalTitan_AmuletTitan_WURG(),
                new PostCompanionChange(),
                ArchetypeColor.WURG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck40_SawphtBoi_Winota_WRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck40_SawphtBoi_Winota_WRG(),
                new PostCompanionChange(),
                ArchetypeColor.WRG,
                typeof(Winota),
                null,
                null
            );
        }

        [Test]
        public void Deck41_Boland_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck41_Boland_DeathsShadow_GrixisShadow_UBR(),
                new PostCompanionChange(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck42_marcofabrizi_SnowControl_SnowBlade_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck42_marcofabrizi_SnowControl_SnowBlade_WUG(),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowBlade),
                null
            );
        }

        [Test]
        public void Deck43_robb93_UTron_U()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck43_robb93_UTron_U(),
                new PostCompanionChange(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck44_Misplacedginger_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12.Deck44_Misplacedginger_SnowControl_WUG(),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }


    }
}
