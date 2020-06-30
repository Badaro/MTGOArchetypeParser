using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests
{
    public class EventTest_modern_league_2020_06_26 : EventTest
    {
        [Test]
        public void Deck01_nahuel10_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck01_nahuel10_SnowControl_WUG(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Ennuixd_Prowess_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck02_Ennuixd_Prowess_R(),
                ArchetypeColor.R,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Lucabireskusku_Inverter_UB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck03_Lucabireskusku_Inverter_UB(),
                ArchetypeColor.UB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Inverter),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Audemin_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck04_Audemin_Humans_WUBRG(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck05_koji1130_Prowess_WR_Jegantha()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck05_koji1130_Prowess_WR_Jegantha(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck06_StreexIT_Spirits_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck06_StreexIT_Spirits_WU(),
                ArchetypeColor.WU,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck07_rojanosa_Tokens_WB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck07_rojanosa_Tokens_WB(),
                ArchetypeColor.WB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Tokens),
                null,
                null
            );
        }

        [Test]
        public void Deck08_haubidtran_Uroza_UBG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck08_haubidtran_Uroza_UBG_Yorion(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck09_esatheking_Prowess_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck09_esatheking_Prowess_WR(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck10_yPrincipe_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck10_yPrincipe_ETron_C(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck11_magicjpg_Soulherder_WUG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck11_magicjpg_Soulherder_WUG_Yorion(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Soulherder),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck12_Psychophobic_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck12_Psychophobic_Ponza_RG(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Borjillamtg10_AdNauseam_WUB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck13_Borjillamtg10_AdNauseam_WUB(),
                ArchetypeColor.WUB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck14_603Leb_PrimevalTitan_AmuletTitan_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck14_603Leb_PrimevalTitan_AmuletTitan_WUBRG(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck15_MadRamon_SnowControl_SnowReclamation_URG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck15_MadRamon_SnowControl_SnowReclamation_URG_Yorion(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowReclamation),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck16_Mordeka1ser_BringToNiv_WUBRG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck16_Mordeka1ser_BringToNiv_WUBRG_Yorion(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck17_Zebrah_PrimevalTitan_AmuletTitan_WUBRG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck17_Zebrah_PrimevalTitan_AmuletTitan_WUBRG_Yorion(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.AmuletTitan),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck18_Shorak123_SnowControl_SnowReclamation_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck18_Shorak123_SnowControl_SnowReclamation_UBG(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck19_Beicodegeia_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck19_Beicodegeia_GiftsStorm_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck20_FantasticMrFox_Bogles_WG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck20_FantasticMrFox_Bogles_WG(),
                ArchetypeColor.WG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck21_RockStar_Prowess_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck21_RockStar_Prowess_BR(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Bunnykept_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck22_Bunnykept_Rock_Jund_BRG(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Jund),
                null
            );
        }

        [Test]
        public void Deck23_Lcario_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck23_Lcario_DeathsShadow_GrixisShadow_UBR(),
                ArchetypeColor.UBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck24_Gaffiere1903_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck24_Gaffiere1903_Ponza_RG(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Nogamblenofutur_Burn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck25_Nogamblenofutur_Burn_WR(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Justodeangelo_SnowControl_SnowReclamation_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck26_Justodeangelo_SnowControl_SnowReclamation_URG(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck27_SightWinner_HollowOne_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck27_SightWinner_HollowOne_BR(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.HollowOne),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Pirika_MarduPyromancer_WBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck28_Pirika_MarduPyromancer_WBR(),
                ArchetypeColor.WBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.MarduPyromancer),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Xorn9_Goblins_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck29_Xorn9_Goblins_WUBRG(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck30_vengevine29_HardenedScales_BG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck30_vengevine29_HardenedScales_BG(),
                ArchetypeColor.BG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck31_SebastianStueckl_Goblins_SnoopGoblins_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck31_SebastianStueckl_Goblins_SnoopGoblins_BR(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Goblins),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck32_Trellon_UTron_UB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck32_Trellon_UTron_UB(),
                ArchetypeColor.UB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Netow_Dredge_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck33_Netow_Dredge_BRG(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck34_Sonkerz_IzzetControl_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck34_Sonkerz_IzzetControl_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck35_PieGonti_KinnanUrza_URG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck35_PieGonti_KinnanUrza_URG_Yorion(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.KinnanUrza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck36_Piccio36_Winota_WRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26.Deck36_Piccio36_Winota_WRG(),
                ArchetypeColor.WRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Winota),
                null,
                null
            );
        }


    }
}
