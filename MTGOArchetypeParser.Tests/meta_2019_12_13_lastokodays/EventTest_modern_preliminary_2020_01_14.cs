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
#01 Vidandric: Dredge (BRG)
#02 yamakiller: Eldrazi Tron (C)
#03 JustBurn420: Slivers (WUBRG)
#04 stonepeanut: Crabvine (UBG)
#05 rusty_gates: Jund Midrange (BRG)
#06 Hazzrd: Mono Red Prowess (R)
#07 shadow_PT: Dredge (BRG)
#08 Papelucho10: Infect (UG)
#09 McWinSauce: Bant Control (WUG)
#10 Butakov: Yawgmoth (BG)
#11 PRGJJAR: Dredge (BRG)
#12 Dreamcrusher119: Dredge (BRG)
#13 qbturtle15: Jund Midrange (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_13_lastokodays
{
    public class EventTest_modern_preliminary_2020_01_14 : EventTest
    {
        [Test]
        public void Deck01_Vidandric_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-14",0),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck02_yamakiller_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-14",1),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck03_JustBurn420_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-14",2),
                new LastOkoDays(),
                ArchetypeColor.WUBRG,
                typeof(Slivers),
                null,
                null
            );
        }

        [Test]
        public void Deck04_stonepeanut_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-14",3),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck05_rustygates_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-14",4),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Hazzrd_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-14",5),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck07_shadowPT_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-14",6),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Papelucho10_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-14",7),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck09_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-14",8),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Butakov_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-14",9),
                new LastOkoDays(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck11_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-14",10),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Dreamcrusher119_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-14",11),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck13_qbturtle15_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-14",12),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
