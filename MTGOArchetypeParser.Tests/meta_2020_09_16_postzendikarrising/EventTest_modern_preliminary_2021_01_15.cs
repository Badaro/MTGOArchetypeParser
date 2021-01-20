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
#01 Kihara_Works: WURG Control (WURG)
#02 Kadoonyec: Amulet Titan (G)
#03 Rooney56: Grinding Breach (URG)
#04 Violent_Outburst: Scapeshift (WURG)
#05 kthanakit26: Obosh Aggro (R, Obosh)
#06 moyashi0904: WURG Control (WURG)
#07 Artem_Kuhtin: Spirits (WU)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2021_01_15 : EventTest
    {
        [Test]
        public void Deck01_KiharaWorks_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-15",0),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Kadoonyec_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-15",1),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck03_Rooney56_GrindingBreach_URG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-15",2),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GrindingBreach),
                null,
                null
            );
        }

        [Test]
        public void Deck04_ViolentOutburst_Scapeshift_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-15",3),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck05_kthanakit26_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-15",4),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(OboshAggro),
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck06_moyashi0904_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-15",5),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_ArtemKuhtin_Spirits_WU()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-15",6),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }


    }
}
