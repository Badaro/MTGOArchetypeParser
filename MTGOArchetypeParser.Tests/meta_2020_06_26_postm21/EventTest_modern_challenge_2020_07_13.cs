using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_06_26_postm21
{
    public class EventTest_modern_challenge_2020_07_13 : EventTest
    {
        [Test]
        public void Deck01_Lavaridge_SnowControl_SultaiSnow_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck01_Lavaridge_SnowControl_SultaiSnow_UBG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck02_sfitz_ThopterUrza_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck02_sfitz_ThopterUrza_UBR(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.UBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Larry11_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck03_Larry11_Ponza_RG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Polikasoll_Burn_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck04_Polikasoll_Burn_R(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.R,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck05_ZYURYO_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck05_ZYURYO_Rock_Jund_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Jund),
                null
            );
        }

        [Test]
        public void Deck06_LordBeerus_Burn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck06_LordBeerus_Burn_WR(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck07_sffmtg_GTron_KGCTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck07_sffmtg_GTron_KGCTron_G(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.G,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GTron),
                typeof(MTGOArchetypeParser.Archetypes.Modern.KGCTron),
                null
            );
        }

        [Test]
        public void Deck08_Gigy_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck08_Gigy_Ponza_RG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck09_kiko_DeathAndTaxes_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck09_kiko_DeathAndTaxes_WR(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathAndTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck10_TennTyou_BringToNiv_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck10_TennTyou_BringToNiv_WUBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.BringToNiv),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Smosh_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck11_Smosh_ETron_C(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck12_WeareVenom_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck12_WeareVenom_SnowControl_WUG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Nekonii_Elves_GolgariElves_BG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck13_Nekonii_Elves_GolgariElves_BG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.BG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Elves),
                typeof(MTGOArchetypeParser.Archetypes.Modern.GolgariElves),
                null
            );
        }

        [Test]
        public void Deck14_Mogged_Prowess_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck14_Mogged_Prowess_R(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.R,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck15_PizzaTurtle_Bogles_WG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck15_PizzaTurtle_Bogles_WG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.WG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck16_unicornparadise_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck16_unicornparadise_ETron_C(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck17_FabriceK_SnowControl_SnowReclamation_UBG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck17_FabriceK_SnowControl_SnowReclamation_UBG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowReclamation),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck18_MrRaeb_Uroza_UBG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck18_MrRaeb_Uroza_UBG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_tuckbear_Burn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck19_tuckbear_Burn_WR(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Lopik6_PrimevalTitan_AmuletTitan_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck20_Lopik6_PrimevalTitan_AmuletTitan_URG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck21_MikeEgan_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck21_MikeEgan_Ponza_RG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck22_PvtEnormous_Prowess_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck22_PvtEnormous_Prowess_R(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.R,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck23_eXavie_SnowControl_SultaiSnow_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck23_eXavie_SnowControl_SultaiSnow_UBG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck24_Ryan100495_Dredge_WBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck24_Ryan100495_Dredge_WBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.WBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck25_destinction_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck25_destinction_Rock_Jund_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Jund),
                null
            );
        }

        [Test]
        public void Deck26_JUJUBEAN2004_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck26_JUJUBEAN2004_SnowControl_WUG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Tiemuuu_IzzetControl_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck27_Tiemuuu_IzzetControl_UR(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Venom1_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck28_Venom1_ETron_C(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck29_otakkun_GTron_KGCTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck29_otakkun_GTron_KGCTron_G(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.G,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GTron),
                typeof(MTGOArchetypeParser.Archetypes.Modern.KGCTron),
                null
            );
        }

        [Test]
        public void Deck30_JackKashtan_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck30_JackKashtan_GiftsStorm_UR(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Skrown_Dredge_WBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck31_Skrown_Dredge_WBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.WBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Erik157751_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_challenge_2020_07_13.Deck32_Erik157751_Rock_Jund_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostM21(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Jund),
                null
            );
        }


    }
}
