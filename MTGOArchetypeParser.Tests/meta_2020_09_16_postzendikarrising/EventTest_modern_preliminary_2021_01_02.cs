using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 sgkj0429: Izzet Prowess (UR)
#02 ArchaeusDota: Uroza (WUBRG)
#03 Simarisu: Shadow Prowess (BR, Lurrus)
#04 Dirk513: Oops All Spells (WUBG)
#05 katuo079595: Rakdos Midrange (BR)
#06 triosk: Hammer Time (WB, Lurrus)
#07 JV_7777: WURG Control (WURG)
#08 Gerardo94: WURG Control (WURG)
#09 Vitis_vinifera: Scapeshift (URG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2021_01_02 : EventTest
    {
        [Test]
        public void Deck01_sgkj0429_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-02",0),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck02_ArchaeusDota_Uroza_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-02",1),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Simarisu_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-02",2),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_Dirk513_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-02",3),
                "PostZendikarRising",
                ArchetypeColor.WUBG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck05_katuo079595_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-02",4),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck06_triosk_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-02",5),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_JV7777_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-02",6),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Gerardo94_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-02",7),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Vitisvinifera_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-02",8),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }


    }
}
