using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 penips: Mono White Taxes (W)
#02 Jaberwocki: Jund Midrange (BRG)
#03 bolov0: Rakdos Midrange (BR)
#04 Tiemuuu: Izzet Control (UR)
#05 FriskiFraska: Elementals (WUBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_12_18 : EventTest
    {
        [Test]
        public void Deck01_penips_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-18",0),
                "PostZendikarRising",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Jaberwocki_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-18",1),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck03_bolov0_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-18",2),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck04_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-18",3),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_FriskiFraska_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-18",4),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Elementals",
                null,
                null
            );
        }


    }
}
