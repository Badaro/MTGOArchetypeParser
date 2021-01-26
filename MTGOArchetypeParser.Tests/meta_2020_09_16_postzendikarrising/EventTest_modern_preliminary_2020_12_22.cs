using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 pbarrrgh: Reclamation (UBG)
#02 Tiemuuu: Izzet Control (UR)
#03 ACG88: Burn (WR)
#04 joncos: Hammer Time (WB, Lurrus)
#05 penips: Mono White Taxes (W)
#06 Jositoshekel: Heliod Combo (WG)
#07 MZBlazer: Reclaimer Titan (WRG)
#08 cicciogire: WURG Control (WURG)
#09 SoulStrong: Primeval Titan (UG)
#10 bolov0: Rakdos Midrange (BR)
#11 Fastfake: Hammer Time (WB, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_12_22 : EventTest
    {
        [Test]
        public void Deck01_pbarrrgh_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-22",0),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-22",1),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_ACG88_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-22",2),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck04_joncos_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-22",3),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_penips_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-22",4),
                "PostZendikarRising",
                ArchetypeColor.W,
                "Taxes",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Jositoshekel_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-22",5),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck07_MZBlazer_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-22",6),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck08_cicciogire_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-22",7),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck09_SoulStrong_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-22",8),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck10_bolov0_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-22",9),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck11_Fastfake_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-22",10),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
