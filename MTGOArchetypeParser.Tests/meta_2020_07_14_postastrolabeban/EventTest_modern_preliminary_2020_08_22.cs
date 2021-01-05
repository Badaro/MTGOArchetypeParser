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
#01 ImmanuelKantrolGod: Bant Control (WUG)
#02 McWinSauce: Bant Control (WUG)
#03 otakkun: KGC Tron (G)
#04 aManatease: Izzet Prowess (UR)
#05 CrusherBotBG: Hammer Time (W)
#06 kingsmudge: E Tron (C)
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
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-22",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_otakkun_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-22",2),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck04_aManatease_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-22",3),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck05_CrusherBotBG_HammerTime_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-22",4),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                null
            );
        }

        [Test]
        public void Deck06_kingsmudge_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-22",5),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck07_JakeHelms_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-22",6),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_matsugan_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-22",7),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck09_kanister_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-22",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_iLTedesco_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-22",9),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
