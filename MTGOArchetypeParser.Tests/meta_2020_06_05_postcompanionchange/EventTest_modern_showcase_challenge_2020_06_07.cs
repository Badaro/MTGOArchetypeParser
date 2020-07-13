using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_06_05_postcompanionchange
{
    public class EventTest_modern_showcase_challenge_2020_06_07 : EventTest
    {
        [Test]
        public void Deck01_Do0mSwitch_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck01_Do0mSwitch_SnowControl_WUG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_hugofreitas1_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck02_hugofreitas1_GiftsStorm_UR(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck03_nathansteuer_Uroza_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck03_nathansteuer_Uroza_URG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck04_McWinSauce_SnowControl_SnowBlade_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck04_McWinSauce_SnowControl_SnowBlade_WUG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowBlade),
                null
            );
        }

        [Test]
        public void Deck05_Finalnub_Neobrand_UG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck05_Finalnub_Neobrand_UG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck06_SebastianStueckl_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck06_SebastianStueckl_Ponza_RG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck07_MatheusPonciano_Dredge_UBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck07_MatheusPonciano_Dredge_UBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck08_cftsoc3_BantBlink_WUG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck08_cftsoc3_BantBlink_WUG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.BantBlink),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck09_PietroSas_Devoted_WG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck09_PietroSas_Devoted_WG_Lurrus(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_TheTunnelingCat_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck10_TheTunnelingCat_ETron_C(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck11_SonsoJF_Devoted_HeliodDevoted_WBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck11_SonsoJF_Devoted_HeliodDevoted_WBG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Devoted),
                typeof(MTGOArchetypeParser.Archetypes.Modern.HeliodDevoted),
                null
            );
        }

        [Test]
        public void Deck12_Moniz0801_PrimevalTitan_KGCAmuletTitan_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck12_Moniz0801_PrimevalTitan_KGCAmuletTitan_WUBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck13_SpiderSpace_HardenedScales_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck13_SpiderSpace_HardenedScales_G(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.G,
                typeof(MTGOArchetypeParser.Archetypes.Modern.HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck14_patrick50_Devoted_WG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck14_patrick50_Devoted_WG_Lurrus(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_rn17_ThopterUrza_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck15_rn17_ThopterUrza_UBR(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Trellon_UTron_U()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck16_Trellon_UTron_U(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.U,
                typeof(MTGOArchetypeParser.Archetypes.Modern.UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Batutinha_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck17_Batutinha_SnowControl_WUG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck18_TSPJendrek_SnowControl_WUBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck18_TSPJendrek_SnowControl_WUBG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck19_solace_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck19_solace_Ponza_RG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Zebrah_PrimevalTitan_AmuletTitan_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck20_Zebrah_PrimevalTitan_AmuletTitan_WUBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck21_DavidDPanda_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck21_DavidDPanda_ETron_C(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck22_FreedMania_PrimevalTitan_AmuletTitan_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck22_FreedMania_PrimevalTitan_AmuletTitan_WUBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck23_BaronOfBacon_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck23_BaronOfBacon_Humans_WUBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck24_GiovaniMF_Burn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck24_GiovaniMF_Burn_WR(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Icteridae_Devoted_HeliodDevoted_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck25_Icteridae_Devoted_HeliodDevoted_WUG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Devoted),
                typeof(MTGOArchetypeParser.Archetypes.Modern.HeliodDevoted),
                null
            );
        }

        [Test]
        public void Deck26_bobjackson_GTron_KGCTron_G_Jegantha()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck26_bobjackson_GTron_KGCTron_G_Jegantha(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.G,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GTron),
                typeof(MTGOArchetypeParser.Archetypes.Modern.KGCTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck27_Ennuixd_PrimevalTitan_AmuletTitan_WURG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck27_Ennuixd_PrimevalTitan_AmuletTitan_WURG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WURG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck28_pbarrrgh_SnowControl_SnowReclamation_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck28_pbarrrgh_SnowControl_SnowReclamation_UBG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck29_Shorak123_SnowControl_SnowReclamation_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck29_Shorak123_SnowControl_SnowReclamation_UBG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck30_JMoney8771_Infect_UG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck30_JMoney8771_Infect_UG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck31_stainerson_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck31_stainerson_SnowControl_WUG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck32_sora1248_Winota_WRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_showcase_challenge_2020_06_07.Deck32_sora1248_Winota_WRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Winota),
                null,
                null
            );
        }


    }
}
