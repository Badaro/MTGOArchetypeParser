using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_08_18 : EventTest
    {
        [Test]
        public void Deck01_Redgy819_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_18.Deck01_Redgy819_ETron_C(),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck02_1plus1equals3_RedPrison_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_18.Deck02_1plus1equals3_RedPrison_R(),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(RedPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Redgy_Burn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_18.Deck03_Redgy_Burn_WR(),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck04_mylast_Prowess_WR_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_18.Deck04_mylast_Prowess_WR_Lurrus(),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Prowess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_buddha715_Burn_WR_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_18.Deck05_buddha715_Burn_WR_Lurrus(),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_Gerschi_Prowess_RakdosProwess_WBR_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_18.Deck06_Gerschi_Prowess_RakdosProwess_WBR_Lurrus(),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_kanister_BantControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_18.Deck07_kanister_BantControl_WUG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_CReactor_GTron_KGCTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_18.Deck08_CReactor_GTron_KGCTron_G(),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck09_VampireGodric_BantControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_18.Deck09_VampireGodric_BantControl_WUG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_BERNASTORRES_BantControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_18.Deck10_BERNASTORRES_BantControl_WUG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Beekeeper_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_18.Deck11_Beekeeper_Humans_WUBRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck12_trader08111_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_18.Deck12_trader08111_ETron_C(),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck13_BasedCloy_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_18.Deck13_BasedCloy_ETron_C(),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Snusnumrick_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_18.Deck14_Snusnumrick_ETron_C(),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Curryvore_AzoriousBlink_JeskaiBlink_WUR_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_18.Deck15_Curryvore_AzoriousBlink_JeskaiBlink_WUR_Yorion(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(AzoriousBlink),
                typeof(JeskaiBlink),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck16_predje_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_18.Deck16_predje_Ponza_RG(),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck17_SIMONEFIERRO_Burn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_18.Deck17_SIMONEFIERRO_Burn_WR(),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck18_mac121711_Dredge_WBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_18.Deck18_mac121711_Dredge_WBRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck19_MagicDevil666_UTron_U()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_18.Deck19_MagicDevil666_UTron_U(),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }


    }
}
