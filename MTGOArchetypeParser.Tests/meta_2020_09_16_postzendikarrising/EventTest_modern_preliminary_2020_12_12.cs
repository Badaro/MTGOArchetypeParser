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
#01 Boucha: Belcher (URG)
#02 Laplasjan: Hammer Time (WB, Lurrus)
#03 katoriarch123: WURG Control (WURG)
#04 IntegralHDK: Jund Midrange (BRG)
#05 Searzist: Mill (UB, Lurrus)
#06 rodeo: Oops All Spells (WUBRG)
#07 TSPJendrek: Azorius Control (WU)
#08 Beenew: Reclaimer Titan (WRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_12_12 : EventTest
    {
        [Test]
        public void Deck01_Boucha_Belcher_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-12",0),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Laplasjan_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-12",1),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_katoriarch123_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-12",2),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_IntegralHDK_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-12",3),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Searzist_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-12",4),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_rodeo_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-12",5),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck07_TSPJendrek_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-12",6),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Beenew_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-12",7),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }


    }
}
