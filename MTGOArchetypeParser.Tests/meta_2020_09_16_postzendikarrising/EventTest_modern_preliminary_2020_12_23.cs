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
#01 Rosencrantz_920: KGC Amulet Titan (G)
#02 Patxi: Dimir Control (UB)
#03 DDMeelow: WURG Control (WURG)
#04 _Shatun_: Rakdos Midrange (BR)
#05 bomberboss: Rakdos Midrange (BR)
#06 maxbv: Mono White Taxes (W)
#07 aManatease: Izzet Prowess (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_12_23 : EventTest
    {
        [Test]
        public void Deck01_Rosencrantz920_KGCAmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-23",0),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck02_Patxi_DimirControl_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-23",1),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_DDMeelow_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-23",2),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Shatun_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-23",3),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_bomberboss_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-23",4),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_maxbv_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-23",5),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck07_aManatease_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-23",6),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }


    }
}
