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
#01 Oderus Urungus: Gruul Midrange (RG)
#02 PRGJJAR: Dredge (BRG)
#03 MZBlazer: Rakdos Prowess (BR, Lurrus)
#04 exoticherman: Rakdos Prowess (BR, Lurrus)
#05 McWinSauce: Bant Control (WUG)
#06 karatedom: Infect (UG)
#07 Costola91: UBRG Shadow (UBRG)
#08 sicsmoo: Green Tron (G)
#09 Nammersquats: Izzet Prowess (UR)
#10 staffmat1992: Gruul Midrange (RG)
#11 pootisgodsamongus: Crabvine (UBG)
#12 Ryan100495: Dredge (WBRG)
#13 komattaman: Gruul Midrange (RG)
#14 ConnorM426: Reclamation (UG)
#15 1plus1equals3: Green Tron (G)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_08_13 : EventTest
    {
        [Test]
        public void Deck01_OderusUrungus_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-13",0),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck02_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-13",1),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck03_MZBlazer_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-13",2),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_exoticherman_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-13",3),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-13",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_karatedom_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-13",5),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Costola91_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-13",6),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck08_sicsmoo_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-13",7),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck09_Nammersquats_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-13",8),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck10_staffmat1992_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-13",9),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck11_pootisgodsamongus_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-13",10),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Ryan100495_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-13",11),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck13_komattaman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-13",12),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck14_ConnorM426_Reclamation_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-13",13),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Reclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck15_1plus1equals3_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-13",14),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }


    }
}
