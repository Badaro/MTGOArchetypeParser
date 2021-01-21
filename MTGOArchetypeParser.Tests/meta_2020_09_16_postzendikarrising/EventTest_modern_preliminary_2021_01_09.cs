using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 naddyeffintabs: Hammer Time (WB, Lurrus)
#02 Capriccioso: WURG Midrange (WURG)
#03 WadapusRex: Burn (WR, Lurrus)
#04 Hampuse1: Dice Factory Tron (C)
#05 katuo079595: Rakdos Midrange (BR)
#06 SanPop: Mill (UB)
#07 otakkun: Pyro Prison (R)
#08 ArchaeusDota: Uroza (URG)
#09 shine0905: Primeval Titan (UG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2021_01_09 : EventTest
    {
        [Test]
        public void Deck01_naddyeffintabs_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-09",0),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_Capriccioso_WURGMidrange_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-09",1),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck03_WadapusRex_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-09",2),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_Hampuse1_DiceFactoryTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-09",3),
                "PostZendikarRising",
                ArchetypeColor.C,
                "Tron",
                "DiceFactoryTron",
                null
            );
        }

        [Test]
        public void Deck05_katuo079595_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-09",4),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck06_SanPop_Mill_UB()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-09",5),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "Mill",
                null,
                null
            );
        }

        [Test]
        public void Deck07_otakkun_PyroPrison_R()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-09",6),
                "PostZendikarRising",
                ArchetypeColor.R,
                "PyroPrison",
                null,
                null
            );
        }

        [Test]
        public void Deck08_ArchaeusDota_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-09",7),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck09_shine0905_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-09",8),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }


    }
}
