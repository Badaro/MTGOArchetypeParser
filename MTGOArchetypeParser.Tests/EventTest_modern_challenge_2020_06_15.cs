using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests
{
    public class EventTest_modern_challenge_2020_06_15 : EventTest
    {
        [Test]
        public void Deck01_hugo87_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck01_hugo87_GiftsStorm_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck02_toondoslav_Dredge_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck02_toondoslav_Dredge_BRG(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Janh_SnowControl_SultaiSnow_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck03_Janh_SnowControl_SultaiSnow_UBG(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck04_SebastianStueckl_Dredge_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck04_SebastianStueckl_Dredge_BRG(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck05_PRGJJAR_Dredge_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck05_PRGJJAR_Dredge_BRG(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck06_ecobaronen_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck06_ecobaronen_Ponza_RG(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck07_TheSouthDakota_Dredge_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck07_TheSouthDakota_Dredge_BRG(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck08_LordBeerus_Burn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck08_LordBeerus_Burn_WR(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck09_NorrathDecay_Burn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck09_NorrathDecay_Burn_WR(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Xenowan_Inverter_UB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck10_Xenowan_Inverter_UB(),
                ArchetypeColor.UB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Inverter),
                null,
                null
            );
        }

        [Test]
        public void Deck11_signblindman_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck11_signblindman_Ponza_RG(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Walka_SnowControl_SnowBlade_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck12_Walka_SnowControl_SnowBlade_WUG(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowBlade),
                null
            );
        }

        [Test]
        public void Deck13_Diatomic_SnowControl_SultaiSnow_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck13_Diatomic_SnowControl_SultaiSnow_UBG(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck14_litianshuo670_DeathAndTaxes_EldraziTaxes_WB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck14_litianshuo670_DeathAndTaxes_EldraziTaxes_WB(),
                ArchetypeColor.WB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathAndTaxes),
                typeof(MTGOArchetypeParser.Archetypes.Modern.EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck15_SkiLwrAp_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck15_SkiLwrAp_ETron_C(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck16_ZYURYO_SnowControl_WUBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck16_ZYURYO_SnowControl_WUBG(),
                ArchetypeColor.WUBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Xwhale_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck17_Xwhale_SnowControl_WUG(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck18_JB2002_BantBlink_WUG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck18_JB2002_BantBlink_WUG_Yorion(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.BantBlink),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_swff_SnowControl_SultaiSnow_WUBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck19_swff_SnowControl_SultaiSnow_WUBG(),
                ArchetypeColor.WUBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck20_Granham_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck20_Granham_Rock_Jund_BRG(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Jund),
                null
            );
        }

        [Test]
        public void Deck21_MadMaxErnst_Uroza_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck21_MadMaxErnst_Uroza_URG(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck22_bobthedog_SnowControl_SultaiSnow_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck22_bobthedog_SnowControl_SultaiSnow_UBG(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck23_gyyby297_ThopterUrza_UB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck23_gyyby297_ThopterUrza_UB(),
                ArchetypeColor.UB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck24_coert_GTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck24_coert_GTron_G(),
                ArchetypeColor.G,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GTron),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Magicofplayer1_EsperControl_WUB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck25_Magicofplayer1_EsperControl_WUB(),
                ArchetypeColor.WUB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.EsperControl),
                null,
                null
            );
        }

        [Test]
        public void Deck26_sffmtg_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck26_sffmtg_Ponza_RG(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck27_musasabi_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck27_musasabi_Humans_WUBRG(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Batutinha_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck28_Batutinha_SnowControl_WUG(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Damgar_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck29_Damgar_ETron_C(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck30_jmoney10_SnowControl_SnowBlade_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck30_jmoney10_SnowControl_SnowBlade_WUG(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowBlade),
                null
            );
        }

        [Test]
        public void Deck31_ilsecco14_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck31_ilsecco14_Ponza_RG(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Mallik7D_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15.Deck32_Mallik7D_GiftsStorm_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GiftsStorm),
                null,
                null
            );
        }


    }
}
