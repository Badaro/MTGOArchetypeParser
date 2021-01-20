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
#01 _Shatun_: Obosh Aggro (R, Obosh)
#02 joaoclaudioms: Hammer Time (WB, Lurrus)
#03 richardgirges: Jund Midrange (BRG)
#04 ginaep: Eldrazi Tron (C)
#05 Bohnz87: WBRG Shadow (WBRG)
#06 ElYallo: Heliod Combo (WG)
#07 naddyeffintabs: Hammer Time (WB, Lurrus)
#08 Rooney56: Shadow Prowess (BR, Lurrus)
#09 billsive: WURG Control (WURG, Lutri)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2021_01_07 : EventTest
    {
        [Test]
        public void Deck01_Shatun_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-07",0),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(OboshAggro),
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck02_joaoclaudioms_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-07",1),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_richardgirges_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-07",2),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck04_ginaep_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-07",3),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck05_Bohnz87_WBRGShadow_WBRG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-07",4),
                new PostZendikarRising(),
                ArchetypeColor.WBRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck06_ElYallo_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-07",5),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck07_naddyeffintabs_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-07",6),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_Rooney56_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-07",7),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_billsive_WURGControl_WURG_Lutri()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-07",8),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Lutri
            );
        }


    }
}
