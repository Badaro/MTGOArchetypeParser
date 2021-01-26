using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 kanister: Dimir Control (UB)
#02 JakeHelms: WURG Control (WURG)
#03 ghett_smart: WURG Control (WURG)
#04 deftjad: Rakdos Midrange (BR)
#05 WadapusRex: Burn (WR)
#06 Simpleliquid: Heliod Combo (WG)
#07 Gigy: Shadow Prowess (BR, Lurrus)
#08 kmacy90: Mill (U)
#09 buyiedward: Nivmagus Combo (UR)
#10 Rooney56: Grinding Breach (URG)
#11 Valorj: Mono White Taxes (W)
#12 WhiTe TsaR: Faeries (UB)
#13 _Stream: Izzet Prowess (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2021_01_16 : EventTest
    {
        [Test]
        public void Deck01_kanister_DimirControl_UB()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-16",0),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_JakeHelms_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-16",1),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_ghettsmart_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-16",2),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_deftjad_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-16",3),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck05_WadapusRex_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-16",4),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck06_Simpleliquid_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-16",5),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Gigy_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-16",6),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_kmacy90_Mill_U()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-16",7),
                "PostZendikarRising",
                ArchetypeColor.U,
                "Mill",
                null,
                null
            );
        }

        [Test]
        public void Deck09_buyiedward_NivmagusCombo_UR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-16",8),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "NivmagusCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Rooney56_GrindingBreach_URG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-16",9),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "GrindingBreach",
                null,
                null
            );
        }

        [Test]
        public void Deck11_Valorj_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-16",10),
                "PostZendikarRising",
                ArchetypeColor.W,
                "Taxes",
                null,
                null
            );
        }

        [Test]
        public void Deck12_WhiTeTsaR_Faeries_UB()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-16",11),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "Faeries",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Stream_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-16",12),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }


    }
}
