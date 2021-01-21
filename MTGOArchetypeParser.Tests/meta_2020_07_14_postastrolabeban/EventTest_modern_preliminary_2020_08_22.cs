using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 ImmanuelKantrolGod: Bant Control (WUG)
#02 McWinSauce: WURG Control (WURG)
#03 otakkun: Green Tron (G)
#04 aManatease: Izzet Prowess (UR)
#05 CrusherBotBG: Hammer Time (W)
#06 kingsmudge: Eldrazi Tron (C)
#07 JakeHelms: Rakdos Prowess (BR, Lurrus)
#08 __matsugan: Dredge (BRG)
#09 kanister: Bant Control (WUG)
#10 iL_Tedesco: Jund Midrange (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_08_22 : EventTest
    {
        [Test]
        public void Deck01_ImmanuelKantrolGod_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-22",0),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-22",1),
                "PostAstrolabeBan",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_otakkun_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-22",2),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck04_aManatease_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-22",3),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck05_CrusherBotBG_HammerTime_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-22",4),
                "PostAstrolabeBan",
                ArchetypeColor.W,
                "HammerTime",
                null,
                null
            );
        }

        [Test]
        public void Deck06_kingsmudge_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-22",5),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck07_JakeHelms_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-22",6),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_matsugan_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-22",7),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck09_kanister_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-22",8),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck10_iLTedesco_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-22",9),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }


    }
}
