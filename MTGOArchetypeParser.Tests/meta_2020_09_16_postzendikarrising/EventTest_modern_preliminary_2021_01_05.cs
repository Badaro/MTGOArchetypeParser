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
#01 Mogged: Gruul Midrange (RG, Obosh)
#02 Kokka4887: Mardu Midrange (WBR)
#03 Masontj: Heliod Combo (WG)
#04 naddyeffintabs: Grishoalbrand (BR)
#05 Pintogeddon2: Hammer Time (W, Lurrus)
#06 Jedgi: WURG Control (WURG)
#07 Kazuga: Shadow Prowess (BR, Lurrus)
#08 patheus_84: Ad Nauseam (WUB)
#09 SIMONEFIERRO: Burn (WR)
#10 Oderus Urungus: Hammer Time (WB, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2021_01_05 : EventTest
    {
        [Test]
        public void Deck01_Mogged_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-05",0),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck02_Kokka4887_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-05",1),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Masontj_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-05",2),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck04_naddyeffintabs_Grishoalbrand_BR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-05",3),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Grishoalbrand",
                null,
                null
            );
        }

        [Test]
        public void Deck05_Pintogeddon2_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-05",4),
                "PostZendikarRising",
                ArchetypeColor.W,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_Jedgi_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-05",5),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Kazuga_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-05",6),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_patheus84_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-05",7),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck09_SIMONEFIERRO_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-05",8),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck10_OderusUrungus_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-05",9),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
