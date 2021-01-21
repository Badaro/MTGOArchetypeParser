using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 karn_90: Rakdos Prowess (BR, Lurrus)
#02 ZYX_Jerry: Boros Prowess (WR, Lurrus)
#03 fradelrock: Green Tron (G)
#04 kthanakit26: Izzet Prowess (UR)
#05 Toastxp: Obosh Aggro (R, Obosh)
#06 cftsoc3: Bant Blink (WUG)
#07 zMunkeyXz: Mill (UBG)
#08 Zar0s: Reclaimer Titan (WRG)
#09 greenboy011: Azorius Control (WU)
#10 Kazuga: Dredge (BRG)
#11 McWinSauce: Bant Control (WUG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_08_29 : EventTest
    {
        [Test]
        public void Deck01_karn90_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-29",0),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_ZYXJerry_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-29",1),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_fradelrock_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-29",2),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck04_kthanakit26_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-29",3),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck05_Toastxp_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-29",4),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck06_cftsoc3_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-29",5),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericBlink",
                null,
                null
            );
        }

        [Test]
        public void Deck07_zMunkeyXz_Mill_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-29",6),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "Mill",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Zar0s_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-29",7),
                "PostAstrolabeBan",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck09_greenboy011_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-29",8),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Kazuga_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-29",9),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck11_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-29",10),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }


    }
}
