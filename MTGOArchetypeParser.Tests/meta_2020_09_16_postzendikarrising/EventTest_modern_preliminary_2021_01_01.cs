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
#05 otakkun: Red Prison (R)
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
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_nsroller_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-01",1),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck03_bozokaboy_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-01",2),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Jfuiilo_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-01",3),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck05_otakkun_RedPrison_R()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-01",4),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(RedPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck06_yashimoro_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-01",5),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
