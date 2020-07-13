using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_06_05_postcompanionchange
{
    public class EventTest_modern_preliminary_2020_06_20 : EventTest
    {
        [Test]
        public void Deck01_aooaaooa_Lantern_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_preliminary_2020_06_20.Deck01_aooaaooa_Lantern_UBG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Lantern),
                null,
                null
            );
        }

        [Test]
        public void Deck02_NightKnight131_Devoted_WG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_preliminary_2020_06_20.Deck02_NightKnight131_Devoted_WG_Lurrus(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_MadCowChicken_EldraziBlade_WG_Jegantha()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_preliminary_2020_06_20.Deck03_MadCowChicken_EldraziBlade_WG_Jegantha(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.EldraziBlade),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck04_FrankBonaparte_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_preliminary_2020_06_20.Deck04_FrankBonaparte_Ponza_RG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Papelucho10_Infect_UG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_preliminary_2020_06_20.Deck05_Papelucho10_Infect_UG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Mcleskey_Burn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_preliminary_2020_06_20.Deck06_Mcleskey_Burn_WR(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Boland_Dredge_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_preliminary_2020_06_20.Deck07_Boland_Dredge_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck08_ghostx02_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_preliminary_2020_06_20.Deck08_ghostx02_Ponza_RG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck09_FrancusAurelius_NayaStoneblade_WRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_preliminary_2020_06_20.Deck09_FrancusAurelius_NayaStoneblade_WRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.NayaStoneblade),
                null,
                null
            );
        }

        [Test]
        public void Deck10_otakkun_GTron_KGCTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_preliminary_2020_06_20.Deck10_otakkun_GTron_KGCTron_G(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.G,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GTron),
                typeof(MTGOArchetypeParser.Archetypes.Modern.KGCTron),
                null
            );
        }

        [Test]
        public void Deck11_Logic_DeathsShadow_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_preliminary_2020_06_20.Deck11_Logic_DeathsShadow_BR(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck12_2radMTG_Bogles_WG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_preliminary_2020_06_20.Deck12_2radMTG_Bogles_WG_Lurrus(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_lovealienzzz_SnowControl_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_preliminary_2020_06_20.Deck13_lovealienzzz_SnowControl_URG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Manacymbal_KinnanUrza_URG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_preliminary_2020_06_20.Deck14_Manacymbal_KinnanUrza_URG_Yorion(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.KinnanUrza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck15_signblindman_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_preliminary_2020_06_20.Deck15_signblindman_Ponza_RG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Nammersquats_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_preliminary_2020_06_20.Deck16_Nammersquats_Humans_WUBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Micro_AdNauseam_WUB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_preliminary_2020_06_20.Deck17_Micro_AdNauseam_WUB(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck18_joetru_BringToNiv_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_preliminary_2020_06_20.Deck18_joetru_BringToNiv_WUBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.BringToNiv),
                null,
                null
            );
        }

        [Test]
        public void Deck19_grahams_Mill_UB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_preliminary_2020_06_20.Deck19_grahams_Mill_UB(),
                new MTGOArchetypeParser.Metas.Modern.PostCompanionChange(),
                ArchetypeColor.UB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Mill),
                null,
                null
            );
        }


    }
}
