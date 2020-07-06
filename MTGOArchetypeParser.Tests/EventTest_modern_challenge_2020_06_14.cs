using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests
{
    public class EventTest_modern_challenge_2020_06_14 : EventTest
    {
        [Test]
        public void Deck01_bobthedog_SnowControl_SultaiSnow_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck01_bobthedog_SnowControl_SultaiSnow_UBG(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck02_SvenSveeterSven_IzzetControl_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck02_SvenSveeterSven_IzzetControl_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Mcleskey_Burn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck03_Mcleskey_Burn_WR(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck04_Laplasjan_Devoted_WG_Lurrus(),
                ArchetypeColor.WG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_indianpancake_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck05_indianpancake_Ponza_RG(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck06_MadMaxErnst_Uroza_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck06_MadMaxErnst_Uroza_URG(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck07_tendercloud_HardenedScales_BG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck07_tendercloud_HardenedScales_BG_Lurrus(),
                ArchetypeColor.BG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_TSPJendrek_SnowControl_UBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck08_TSPJendrek_SnowControl_UBRG(),
                ArchetypeColor.UBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_TheTunnelingCat_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck09_TheTunnelingCat_ETron_C(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck10_GoblinK1ng_Goblins_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck10_GoblinK1ng_Goblins_WUBRG(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck11_bcs8995_SnowControl_SnowTitan_WUG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck11_bcs8995_SnowControl_SnowTitan_WUG_Yorion(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowTitan),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck12_SchulzCubed_TakingTurns_FiresTurns_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck12_SchulzCubed_TakingTurns_FiresTurns_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.TakingTurns),
                typeof(MTGOArchetypeParser.Archetypes.Modern.FiresTurns),
                null
            );
        }

        [Test]
        public void Deck13_LordBeerus_Burn_WR_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck13_LordBeerus_Burn_WR_Lurrus(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_lovealienzzz_SnowControl_TemurSnow_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck14_lovealienzzz_SnowControl_TemurSnow_URG(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.TemurSnow),
                null
            );
        }

        [Test]
        public void Deck15_sakuragi21722749_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck15_sakuragi21722749_ETron_C(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck16_staples87_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck16_staples87_ETron_C(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck17_AndyAWKWARD_Scapeshift_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck17_AndyAWKWARD_Scapeshift_URG(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck18_SonsoJF_ThopterUrza_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck18_SonsoJF_ThopterUrza_UBR(),
                ArchetypeColor.UBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck19_ConnorM426_SnowControl_SnowReclamation_UBG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck19_ConnorM426_SnowControl_SnowReclamation_UBG_Yorion(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowReclamation),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck20_headshotcatcher_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck20_headshotcatcher_Ponza_RG(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck21_ChrisConcarnage_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck21_ChrisConcarnage_ETron_C(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck22_GedionRavenor_SnowControl_SnowBlade_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck22_GedionRavenor_SnowControl_SnowBlade_WUG(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowBlade),
                null
            );
        }

        [Test]
        public void Deck23_Nyph_PrimevalTitan_AmuletTitan_UBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck23_Nyph_PrimevalTitan_AmuletTitan_UBRG(),
                ArchetypeColor.UBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck24_eminemberry_Burn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck24_eminemberry_Burn_WR(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck25_dpeliser_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck25_dpeliser_SnowControl_WUG(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck26_ContraEgo_ThopterUrza_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck26_ContraEgo_ThopterUrza_UBR(),
                ArchetypeColor.UBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck27_SebastianStueckl_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck27_SebastianStueckl_Ponza_RG(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck28_PeanutBrittle_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck28_PeanutBrittle_GiftsStorm_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Kuhb_GrindingBreach_WURG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck29_Kuhb_GrindingBreach_WURG(),
                ArchetypeColor.WURG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GrindingBreach),
                null,
                null
            );
        }

        [Test]
        public void Deck30_MathGod_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck30_MathGod_GiftsStorm_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck31_SunofNothing_Uroza_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck31_SunofNothing_Uroza_URG(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck32_exoticherman_Infect_UG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14.Deck32_exoticherman_Infect_UG(),
                ArchetypeColor.UG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Infect),
                null,
                null
            );
        }


    }
}
