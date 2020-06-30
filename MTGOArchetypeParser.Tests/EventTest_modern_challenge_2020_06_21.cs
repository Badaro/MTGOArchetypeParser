using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests
{
    public class EventTest_modern_challenge_2020_06_21 : EventTest
    {
        [Test]
        public void Deck01_Tiemuuu_IzzetControl_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck01_Tiemuuu_IzzetControl_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_xakx47x_Devoted_WG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck02_xakx47x_Devoted_WG_Lurrus(),
                ArchetypeColor.WG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_1yo2yo_ThopterUrza_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck03_1yo2yo_ThopterUrza_UBR(),
                ArchetypeColor.UBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck04_tuhoajatane_PrimevalTitan_AmuletTitan_UBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck04_tuhoajatane_PrimevalTitan_AmuletTitan_UBRG(),
                ArchetypeColor.UBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck05_Jiggywiggy_KinnanUrza_URG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck05_Jiggywiggy_KinnanUrza_URG_Yorion(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.KinnanUrza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck06_PaChA94s_AdNauseam_WUB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck06_PaChA94s_AdNauseam_WUB(),
                ArchetypeColor.WUB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Misplacedginger_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck07_Misplacedginger_SnowControl_WUG(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_SvenSveeterSven_IzzetControl_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck08_SvenSveeterSven_IzzetControl_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_kbr3_HardenedScales_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck09_kbr3_HardenedScales_G(),
                ArchetypeColor.G,
                typeof(MTGOArchetypeParser.Archetypes.Modern.HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck10_MikeEgan_BringToNiv_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck10_MikeEgan_BringToNiv_WUBRG(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.BringToNiv),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Yooisa_Infect_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck11_Yooisa_Infect_WUG(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck12_bntrusty14_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck12_bntrusty14_Humans_WUBRG(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck13_kanister_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck13_kanister_Humans_WUBRG(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck14_GoblinK1ng_Goblins_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck14_GoblinK1ng_Goblins_WUBRG(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck15_haruhilmi24_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck15_haruhilmi24_ETron_C(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Archgaze_Winota_WRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck16_Archgaze_Winota_WRG(),
                ArchetypeColor.WRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Winota),
                null,
                null
            );
        }

        [Test]
        public void Deck17_FranPi_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck17_FranPi_GiftsStorm_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck18_MrRaeb_Uroza_UBG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck18_MrRaeb_Uroza_UBG_Yorion(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_Erik157751_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck19_Erik157751_ETron_C(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck20_bladede_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck20_bladede_ETron_C(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Zeekery_ThingAscension_WUR_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck21_Zeekery_ThingAscension_WUR_Lurrus(),
                ArchetypeColor.WUR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ThingAscension),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_antonio13901390_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck22_antonio13901390_ETron_C(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck23_katoriarch123_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck23_katoriarch123_SnowControl_WUG(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Anicet0_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck24_Anicet0_ETron_C(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck25_MadMaxErnst_Uroza_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck25_MadMaxErnst_Uroza_URG(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Jenara19_SnowControl_SultaiSnow_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck26_Jenara19_SnowControl_SultaiSnow_UBG(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck27_Larry11_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck27_Larry11_Ponza_RG(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck28_ubercrisis_SnowControl_SultaiSnow_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck28_ubercrisis_SnowControl_SultaiSnow_UBG(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck29_remf_Spirits_BantSpirits_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck29_remf_Spirits_BantSpirits_WUG(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Spirits),
                typeof(MTGOArchetypeParser.Archetypes.Modern.BantSpirits),
                null
            );
        }

        [Test]
        public void Deck30_kalibak_Burn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck30_kalibak_Burn_WR(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck31_NewHJ_Burn_WRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck31_NewHJ_Burn_WRG(),
                ArchetypeColor.WRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Manacymbal_KinnanUrza_URG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21.Deck32_Manacymbal_KinnanUrza_URG_Yorion(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.KinnanUrza),
                null,
                ArchetypeCompanion.Yorion
            );
        }


    }
}
