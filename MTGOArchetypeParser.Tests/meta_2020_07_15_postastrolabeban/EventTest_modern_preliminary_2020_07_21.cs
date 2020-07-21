using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_07_15_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_07_21 : EventTest
    {
        [Test]
        public void Deck01_J000111_Dredge_WBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_21.Deck01_J000111_Dredge_WBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck02_aarongulevich_Prowess_IzzetProwess_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_21.Deck02_aarongulevich_Prowess_IzzetProwess_UR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                typeof(MTGOArchetypeParser.Archetypes.Modern.IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck03_ManavonRX_AzoriusControl_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_21.Deck03_ManavonRX_AzoriusControl_WU(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AzoriusControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Icteridae_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_21.Deck04_Icteridae_ETron_C(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck05_yamakiller_Scapeshift_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_21.Deck05_yamakiller_Scapeshift_URG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck06_SubwayEatFlesh_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_21.Deck06_SubwayEatFlesh_ETron_C(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck07_alemilan19_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_21.Deck07_alemilan19_ETron_C(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck08_ReturnToDust_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_21.Deck08_ReturnToDust_ETron_C(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Xwhale_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_21.Deck09_Xwhale_ETron_C(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck10_karatedom_Prowess_RakdosProwess_WBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_21.Deck10_karatedom_Prowess_RakdosProwess_WBR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                typeof(MTGOArchetypeParser.Archetypes.Modern.RakdosProwess),
                null
            );
        }

        [Test]
        public void Deck11_chupon2_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_21.Deck11_chupon2_Rock_Jund_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Jund),
                null
            );
        }

        [Test]
        public void Deck12_Wizard2002_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_21.Deck12_Wizard2002_Humans_WUBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Snusnumrick_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_21.Deck13_Snusnumrick_ETron_C(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck14_RicardoMSLan_GTron_WG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_21.Deck14_RicardoMSLan_GTron_WG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GTron),
                null,
                null
            );
        }

        [Test]
        public void Deck15_PhillHellmuth_Dredge_WBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_21.Deck15_PhillHellmuth_Dredge_WBRG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck16_eclipse4343_AzoriusControl_Miracles_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_21.Deck16_eclipse4343_AzoriusControl_Miracles_WU(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(MTGOArchetypeParser.Archetypes.Modern.AzoriusControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Miracles),
                null
            );
        }

        [Test]
        public void Deck17_hcook725_Prowess_RakdosProwess_WBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_21.Deck17_hcook725_Prowess_RakdosProwess_WBR(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                typeof(MTGOArchetypeParser.Archetypes.Modern.RakdosProwess),
                null
            );
        }

        [Test]
        public void Deck18_Thrall90_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_preliminary_2020_07_21.Deck18_Thrall90_Rock_Jund_BRG(),
                new MTGOArchetypeParser.Metas.Modern.PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Rock),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Jund),
                null
            );
        }


    }
}
