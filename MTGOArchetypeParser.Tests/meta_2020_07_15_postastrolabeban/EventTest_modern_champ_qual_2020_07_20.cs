using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_07_15_postastrolabeban
{
    public class EventTest_modern_champ_qual_2020_07_20 : EventTest
    {
        [Test]
        public void Deck01_TheTunnelingCat_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck01_TheTunnelingCat_ETron_C(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck02_HeyPharaoh_AzoriusControl_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck02_HeyPharaoh_AzoriusControl_WU(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AzoriusControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_iuriper_SnowControl_SnowBlade_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck03_iuriper_SnowControl_SnowBlade_WUG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowBlade),
                null
            );
        }

        [Test]
        public void Deck04_BMJ_DeathsShadow_TraverseShadow_UBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck04_BMJ_DeathsShadow_TraverseShadow_UBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck05_rastaf_Prowess_IzzetProwess_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck05_rastaf_Prowess_IzzetProwess_UR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck06_AnneLivleysD3ath_PrimevalTitan_KGCAmuletTitan_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck06_AnneLivleysD3ath_PrimevalTitan_KGCAmuletTitan_WUBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck07_LalauWBA_Prowess_GruulProwess_RG_Jegantha()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck07_LalauWBA_Prowess_GruulProwess_RG_Jegantha(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                typeof(MTGOArchetypeParser.Archetypes.Modern.GruulProwess),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck08_Lavaridge_WildernessReclamation_TemurReclamation_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck08_Lavaridge_WildernessReclamation_TemurReclamation_URG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.WildernessReclamation),
                typeof(MTGOArchetypeParser.Archetypes.Modern.TemurReclamation),
                null
            );
        }

        [Test]
        public void Deck09_kogamo_WildernessReclamation_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck09_kogamo_WildernessReclamation_UBG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.WildernessReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck10_danichad_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck10_danichad_Rock_Jund_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Jund),
                null
            );
        }

        [Test]
        public void Deck11_MinCash_AdNauseam_WUB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck11_MinCash_AdNauseam_WUB(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck12_BERNASTORRES_Goblins_SnoopGoblins_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck12_BERNASTORRES_Goblins_SnoopGoblins_BR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Goblins),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck13_Ryan39_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck13_Ryan39_Ponza_RG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck14_jmeyer2030_IzzetFreeSpells_ElectroBalance_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck14_jmeyer2030_IzzetFreeSpells_ElectroBalance_URG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetFreeSpells),
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck15_3HaLeX1_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck15_3HaLeX1_ETron_C(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck16_LeoFa_Scapeshift_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck16_LeoFa_Scapeshift_URG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck17_musasabi_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck17_musasabi_Rock_Jund_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Jund),
                null
            );
        }

        [Test]
        public void Deck18_acks_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck18_acks_Ponza_RG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck19_alicoco_AdNauseam_WUB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck19_alicoco_AdNauseam_WUB(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck20_zachattack23_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck20_zachattack23_SnowControl_WUG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck21_quinniac_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck21_quinniac_Ponza_RG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Tia93_Prowess_IzzetProwess_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck22_Tia93_Prowess_IzzetProwess_UR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck23_alnash_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck23_alnash_DeathsShadow_GrixisShadow_UBR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck24_HannoLee_GTron_KGCTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck24_HannoLee_GTron_KGCTron_G(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GTron),
                typeof(MTGOArchetypeParser.Archetypes.Modern.KGCTron),
                null
            );
        }

        [Test]
        public void Deck25_dormitian_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck25_dormitian_Humans_WUBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Magicofplayer1_Dredge_WBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck26_Magicofplayer1_Dredge_WBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Batutinha_Prowess_IzzetProwess_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck27_Batutinha_Prowess_IzzetProwess_UR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck28_Naisirc_HardenedScales_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck28_Naisirc_HardenedScales_G(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(MTGOArchetypeParser.Archetypes.Modern.HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Marxelo_Tokens_W()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck29_Marxelo_Tokens_W(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Tokens),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Patxi_AzoriusControl_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck30_Patxi_AzoriusControl_WU(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AzoriusControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Leviathan102_PrimevalTitan_KGCAmuletTitan_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck31_Leviathan102_PrimevalTitan_KGCAmuletTitan_URG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck32_Boland_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_champ_qual_2020_07_20.Deck32_Boland_DeathsShadow_GrixisShadow_UBR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.GrixisShadow),
                null
            );
        }


    }
}
