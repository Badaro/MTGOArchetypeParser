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
#01 Laplasjan: Devoted (WG, Lurrus)
#02 coert: Burn (WR)
#03 Rooney56: Bant Control (WUG)
#04 trader08111: Mardu Prowess (WBR, Lurrus)
#05 aManatease: Izzet Prowess (UR)
#06 Lavaridge: Reclamation (URG)
#07 JV_7777: Eldrazi Tron (C)
#08 ZYX_Jerry: Burn (WR, Lurrus)
#09 ImmanuelKantrolGod: Bant Control (WUG)
#10 McWinSauce: Bant Control (WUG)
#11 Zar0s: Reclaimer Titan (WG)
#12 otakkun: Green Tron (G)
#13 kbzx: Izzet Prowess (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_08_19 : EventTest
    {
        [Test]
        public void Deck01_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-19",0),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_coert_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-19",1),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck03_Rooney56_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-19",2),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_trader08111_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-19",3),
                "PostAstrolabeBan",
                ArchetypeColor.WBR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_aManatease_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-19",4),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck06_Lavaridge_Reclamation_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-19",5),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck07_JV7777_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-19",6),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck08_ZYXJerry_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-19",7),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_ImmanuelKantrolGod_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-19",8),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck10_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-19",9),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck11_Zar0s_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-19",10),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck12_otakkun_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-19",11),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck13_kbzx_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-19",12),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }


    }
}
