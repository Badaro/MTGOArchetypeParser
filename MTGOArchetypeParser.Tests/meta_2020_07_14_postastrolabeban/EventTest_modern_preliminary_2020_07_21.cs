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
#01 J000111: Dredge (BRG)
#02 aarongulevich: Izzet Prowess (UR)
#03 ManavonRX: Azorius Control (WU)
#04 Icteridae: Eldrazi Tron (C)
#05 yamakiller: Scapeshift (URG)
#06 SubwayEatFlesh: Eldrazi Tron (C)
#07 alemilan19: Eldrazi Tron (C)
#08 ReturnToDust: Eldrazi Tron (C)
#09 Xwhale: Eldrazi Tron (C)
#10 karatedom: Rakdos Prowess (BR, Lurrus)
#11 chupon2: Jund Midrange (BRG)
#12 Wizard_2002: Humans (WUBRG)
#13 Snusnumrick: Eldrazi Tron (C)
#14 RicardoMSLan: Green Tron (G)
#15 Phill_Hellmuth: Dredge (BRG)
#16 eclipse4343: Azorius Control (WU)
#17 hcook725: Mardu Prowess (WBR, Lurrus)
#18 Thrall90: Jund Midrange (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_07_21 : EventTest
    {
        [Test]
        public void Deck01_J000111_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",0),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck02_aarongulevich_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",1),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
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
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Icteridae_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",3),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
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
        public void Deck06_SubwayEatFlesh_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",5),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck07_alemilan19_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",6),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck08_ReturnToDust_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",7),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck09_Xwhale_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",8),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck10_karatedom_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",9),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_chupon2_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",10),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
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
        public void Deck13_Snusnumrick_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",12),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck14_RicardoMSLan_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",13),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck15_PhillHellmuth_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",14),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck16_eclipse4343_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",15),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_hcook725_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",16),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_Thrall90_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-21",17),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
