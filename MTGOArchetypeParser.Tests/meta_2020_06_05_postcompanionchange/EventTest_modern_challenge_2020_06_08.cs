using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_06_05_postcompanionchange
{
    public class EventTest_modern_challenge_2020_06_08 : EventTest
    {
        [Test]
        public void Deck01_TSPJendrek_SnowControl_SnowBlade_WUBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck01_TSPJendrek_SnowControl_SnowBlade_WUBG(),
                new PostCompanionChange(),
                ArchetypeColor.WUBG,
                typeof(SnowControl),
                typeof(SnowBlade),
                null
            );
        }

        [Test]
        public void Deck02_ZYURYO_SnowControl_WUBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck02_ZYURYO_SnowControl_WUBG(),
                new PostCompanionChange(),
                ArchetypeColor.WUBG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_JB2002_BantBlink_WUG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck03_JB2002_BantBlink_WUG_Yorion(),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(BantBlink),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_Yanti_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck04_Yanti_Humans_WUBRG(),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Blitzlion27_Mill_UB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck05_Blitzlion27_Mill_UB(),
                new PostCompanionChange(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck06_AstralPlane_Burn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck06_AstralPlane_Burn_WR(),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck07_SvenSvenSven_IzzetControl_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck07_SvenSvenSven_IzzetControl_UR(),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_signblindman_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck08_signblindman_Ponza_RG(),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck09_hugo87_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck09_hugo87_GiftsStorm_UR(),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Tw33Ty_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck10_Tw33Ty_ETron_C(),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Cherryxman_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck11_Cherryxman_SnowControl_WUG(),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Trid0n_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck12_Trid0n_Humans_WUBRG(),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck13_Laplasjan_Devoted_WG_Lurrus(),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_Ryan100495_Dredge_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck14_Ryan100495_Dredge_BRG(),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck15_LordBeerus_Burn_WR_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck15_LordBeerus_Burn_WR_Lurrus(),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_Batutinha_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck16_Batutinha_SnowControl_WUG(),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_ScreenwriterNY_SnowControl_SultaiSnow_WUBG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck17_ScreenwriterNY_SnowControl_SultaiSnow_WUBG_Yorion(),
                new PostCompanionChange(),
                ArchetypeColor.WUBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck18_Erik157751_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck18_Erik157751_ETron_C(),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck19_sffmtg_GTron_KGCTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck19_sffmtg_GTron_KGCTron_G(),
                new PostCompanionChange(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck20_ScaccoMalto_Prowess_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck20_ScaccoMalto_Prowess_R(),
                new PostCompanionChange(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck21_mosskami_PrimevalTitan_KGCAmuletTitan_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck21_mosskami_PrimevalTitan_KGCAmuletTitan_WUBRG(),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck22_indianpancake_Devoted_WG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck22_indianpancake_Devoted_WG(),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Koso_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck23_Koso_ETron_C(),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck24_WeareVenom_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck24_WeareVenom_SnowControl_WUG(),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck25_robb93_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck25_robb93_ETron_C(),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck26_leclairandy_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck26_leclairandy_SnowControl_WUG(),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_MathGod_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck27_MathGod_GiftsStorm_UR(),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Wartico1_Devoted_WG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck28_Wartico1_Devoted_WG_Lurrus(),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_Nightblue_Burn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck29_Nightblue_Burn_WR(),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck30_ilsecco14_Neobrand_UG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck30_ilsecco14_Neobrand_UG(),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Moniz0801_PrimevalTitan_KGCAmuletTitan_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck31_Moniz0801_PrimevalTitan_KGCAmuletTitan_WUBRG(),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck32_OscarFranco_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_challenge_2020_06_08.Deck32_OscarFranco_ETron_C(),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }


    }
}
