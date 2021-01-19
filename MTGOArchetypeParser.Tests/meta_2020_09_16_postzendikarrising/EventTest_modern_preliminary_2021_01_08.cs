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
#01 SourceOdin: Grinding Breach (URG)
#02 taruto1212: WURG Control (WURG)
#03 Rooney56: Shadow Prowess (BR, Lurrus)
#04 Gigy: Temur Midrange (URG)
#05 BSK_hercules: Temur Control (URG)
#06 Tixis: Omnath Saheeli (WURG, Yorion)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2021_01_08 : EventTest
    {
        [Test]
        public void Deck01_SourceOdin_GrindingBreach_URG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-08",0),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GrindingBreach),
                null,
                null
            );
        }

        [Test]
        public void Deck02_taruto1212_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-08",1),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Rooney56_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-08",2),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_Gigy_TemurMidrange_URG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-08",3),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_BSKhercules_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-08",4),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Tixis_OmnathSaheeli_WURG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-08",5),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Yorion
            );
        }


    }
}
