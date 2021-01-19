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
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_JakeHelms_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-16",1),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_ghettsmart_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-16",2),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_deftjad_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-16",3),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_WadapusRex_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-16",4),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Simpleliquid_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-16",5),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Gigy_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-16",6),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_kmacy90_Mill_U()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-16",7),
                new PostZendikarRising(),
                ArchetypeColor.U,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck09_buyiedward_NivmagusCombo_UR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-16",8),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(NivmagusCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Rooney56_GrindingBreach_URG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-16",9),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GrindingBreach),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Valorj_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-16",10),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck12_WhiTeTsaR_Faeries_UB()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-16",11),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Faeries),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Stream_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-16",12),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }


    }
}
