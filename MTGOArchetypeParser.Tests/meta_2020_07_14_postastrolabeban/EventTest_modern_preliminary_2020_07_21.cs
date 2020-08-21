using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 J000111: Dredge (WBRG)
#02 aarongulevich: IzzetProwess (UR)
#03 ManavonRX: AzoriusControl (WU)
#04 Icteridae: ETron (C)
#05 yamakiller: Scapeshift (URG)
#06 SubwayEatFlesh: ETron (C)
#07 alemilan19: ETron (C)
#08 ReturnToDust: ETron (C)
#09 Xwhale: ETron (C)
#10 karatedom: RakdosProwess (WBR, Lurrus)
#11 chupon2: Jund (BRG)
#12 Wizard_2002: Humans (WUBRG)
#13 Snusnumrick: ETron (C)
#14 RicardoMSLan: GTron (WG)
#15 Phill_Hellmuth: Dredge (WBRG)
#16 eclipse4343: Miracles (WU)
#17 hcook725: RakdosProwess (WBR, Lurrus)
#18 Thrall90: Jund (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_07_21 : EventTest
    {
        [Test]
        public void Deck01_J000111_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",0),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck02_aarongulevich_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",1),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck03_ManavonRX_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",2),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Icteridae_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",3),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck05_yamakiller_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",4),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck06_SubwayEatFlesh_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",5),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck07_alemilan19_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",6),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck08_ReturnToDust_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",7),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Xwhale_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",8),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck10_karatedom_Prowess_RakdosProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",9),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_chupon2_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",10),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck12_Wizard2002_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",11),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Snusnumrick_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",12),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck14_RicardoMSLan_GTron_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",13),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(GTron),
                null,
                null
            );
        }

        [Test]
        public void Deck15_PhillHellmuth_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",14),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck16_eclipse4343_AzoriusControl_Miracles_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",15),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(Miracles),
                null
            );
        }

        [Test]
        public void Deck17_hcook725_Prowess_RakdosProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",16),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_Thrall90_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",17),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }


    }
}
