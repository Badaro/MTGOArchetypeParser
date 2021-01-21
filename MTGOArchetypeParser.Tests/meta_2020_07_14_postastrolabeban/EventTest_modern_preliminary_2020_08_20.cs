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
#01 Gigy: Gruul Midrange (RG)
#02 PRGJJAR: Dredge (BRG)
#03 McWinSauce: Bant Control (WUG)
#04 karatedom: Rakdos Prowess (BR, Lurrus)
#05 Icteridae: Bant Midrange (WUG)
#06 sandydogmtg: Izzet Prowess (UR)
#07 BigBaranoia: Niv To Light (WUBRG)
#08 Xuxa: Dredge (BRG)
#09 qbturtle15: Gruul Midrange (RG)
#10 tuckbear: Jund Midrange (BRG)
#11 hodortimebaby: Green Tron (G)
#12 ConnorM426: Rakdos Prowess (BR, Lurrus)
#13 CHILLEDADED: Burn (WR)
#14 PeanutBrittle: Mono Red Prowess (R, Jegantha)
#15 ht991122: Reclamation (URG)
#16 Xwhale: Bant Control (WUG)
#17 A22en: Goblins (BR)
#18 MrZarukai: Gruul Midrange (RG)
#19 bmac668: Izzet Prowess (UR)
#20 JUJUBEAN__2004: Devoted (WG, Lurrus)
#21 joetru: Niv To Light (WUBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_08_20 : EventTest
    {
        [Test]
        public void Deck01_Gigy_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-20",0),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck02_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-20",1),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck03_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-20",2),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_karatedom_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-20",3),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_Icteridae_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-20",4),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck06_sandydogmtg_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-20",5),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck07_BigBaranoia_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-20",6),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Xuxa_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-20",7),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck09_qbturtle15_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-20",8),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck10_tuckbear_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-20",9),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck11_hodortimebaby_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-20",10),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck12_ConnorM426_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-20",11),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_CHILLEDADED_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-20",12),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck14_PeanutBrittle_MonoRedProwess_R_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-20",13),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck15_ht991122_Reclamation_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-20",14),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck16_Xwhale_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-20",15),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck17_A22en_Goblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-20",16),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck18_MrZarukai_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-20",17),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck19_bmac668_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-20",18),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck20_JUJUBEAN2004_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-20",19),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_joetru_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-20",20),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }


    }
}
