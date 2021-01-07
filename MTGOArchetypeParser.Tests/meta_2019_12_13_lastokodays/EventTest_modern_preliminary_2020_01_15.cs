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
#01 McWinSauce: Bant Control (WUG)
#02 Deathnote1999: Eldrazi Tron (C)
#03 Kazuga: Mono Red Prowess (R)
#04 jessy_samek: WURG Prowess (WURG)
#05 UBERMIKEYB: Temur Prowess (URG)
#06 Gobo2009: Green Tron (G)
#07 Bohnz: Bant Control (WUG)
#08 Erik157751: Crabvine (UBG)
#09 lSoLlAKirA: Green Tron (G)
#10 _Shatun_: Mono Red Prowess (R)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_13_lastokodays
{
    public class EventTest_modern_preliminary_2020_01_15 : EventTest
    {
        [Test]
        public void Deck01_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-15",0),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Deathnote1999_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-15",1),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck03_Kazuga_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-15",2),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck04_jessysamek_WURGProwess_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-15",3),
                new LastOkoDays(),
                ArchetypeColor.WURG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck05_UBERMIKEYB_TemurProwess_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-15",4),
                new LastOkoDays(),
                ArchetypeColor.URG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Gobo2009_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-15",5),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck07_Bohnz_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-15",6),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Erik157751_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-15",7),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck09_lSoLlAKirA_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-15",8),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck10_Shatun_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-15",9),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }


    }
}
