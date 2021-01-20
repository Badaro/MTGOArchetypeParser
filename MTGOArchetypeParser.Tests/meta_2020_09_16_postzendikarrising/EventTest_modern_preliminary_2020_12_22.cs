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
#01 pbarrrgh: Sultai Control (UBG)
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
        public void Deck01_pbarrrgh_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-22",0),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-22",1),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_ACG88_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-22",2),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck04_joncos_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-22",3),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_penips_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-22",4),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Jositoshekel_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-22",5),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck07_MZBlazer_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-22",6),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck08_cicciogire_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-22",7),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_SoulStrong_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-22",8),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck10_bolov0_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-22",9),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Fastfake_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-22",10),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
