using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 kthanakit26: Izzet Prowess (UR)
#02 SourceOdin: Heliod Combo (WG)
#03 Dean911: Green Tron (G)
#04 Rosencrantz_920: Amulet Titan (G)
#05 Rinko: Enduring Ideal (WR)
#06 errorman: Gyruda Reanimator (BRG, Gyruda)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2021_01_22 : EventTest
    {
        [Test]
        public void Deck01_kthanakit26_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-22",0),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck02_SourceOdin_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-22",1),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Dean911_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-22",2),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck04_Rosencrantz920_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-22",3),
                "PostZendikarRising",
                ArchetypeColor.G,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck05_Rinko_EnduringIdeal_WR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-22",4),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "EnduringIdeal",
                null,
                null
            );
        }

        [Test]
        public void Deck06_errorman_GyrudaReanimator_BRG_Gyruda()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-22",5),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GyrudaReanimator",
                null,
                ArchetypeCompanion.Gyruda
            );
        }


    }
}
