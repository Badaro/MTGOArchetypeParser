using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 kazu0612: Heliod Combo (WG)
#02 kanister: Mill (UB, Lurrus)
#03 SeitaSan: Heliod Combo (WG)
#04 Scabs: Heliod Combo (WR)
#05 osmanozguney: Rakdos Midrange (BR)
#06 Tiemuuu: Izzet Control (UR)
#07 Ekeross: Shadow Prowess (BR, Lurrus)
#08 mikeleee: Mill (UB, Lurrus)
#09 Laplasjan: Hammer Time (WB, Lurrus)
#10 BSK_hercules: Temur Control (URG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_12_16 : EventTest
    {
        [Test]
        public void Deck01_kazu0612_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-16",0),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck02_kanister_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-16",1),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "Mill",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_SeitaSan_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-16",2),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck04_Scabs_HeliodCombo_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-16",3),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck05_osmanozguney_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-16",4),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-16",5),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Ekeross_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-16",6),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_mikeleee_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-16",7),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "Mill",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_Laplasjan_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-16",8),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_BSKhercules_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-16",9),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }


    }
}
