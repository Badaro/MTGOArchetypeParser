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
#01 Scabs: Heliod Combo (WR)
#02 pmk: Humans (WUBRG)
#03 TSPJendrek: Sultai Control (UBG)
#04 Coly2: Heliod Combo (WG)
#05 _Marian_: Rakdos Midrange (BR)
#06 Karnesis93: Reclaimer Titan (WG)
#07 eggybenny: Heliod Combo (WG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_12_09 : EventTest
    {
        [Test]
        public void Deck01_Scabs_HeliodCombo_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-09",0),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck02_pmk_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-09",1),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck03_TSPJendrek_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-09",2),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Coly2_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-09",3),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Marian_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-09",4),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Karnesis93_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-09",5),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck07_eggybenny_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-09",6),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }


    }
}
