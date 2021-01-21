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
#01 triosk: Hammer Time (WB, Lurrus)
#02 nsroller: Heliod Combo (WG)
#03 bozokaboy: Oops All Spells (WUBG)
#04 Jfuiilo: Izzet Prowess (UR)
#05 otakkun: Pyro Prison (R)
#06 yashimoro: Temur Control (URG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2021_01_01 : EventTest
    {
        [Test]
        public void Deck01_triosk_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-01",0),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_nsroller_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-01",1),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck03_bozokaboy_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-01",2),
                "PostZendikarRising",
                ArchetypeColor.WUBG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck04_Jfuiilo_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-01",3),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck05_otakkun_PyroPrison_R()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-01",4),
                "PostZendikarRising",
                ArchetypeColor.R,
                "PyroPrison",
                null,
                null
            );
        }

        [Test]
        public void Deck06_yashimoro_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-01",5),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }


    }
}
