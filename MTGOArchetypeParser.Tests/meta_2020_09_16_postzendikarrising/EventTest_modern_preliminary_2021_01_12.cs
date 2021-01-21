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
#01 Lukas261997: WURG Control (WURG)
#02 Lavaridge: Reclamation (URG)
#03 __BMJ__: Shadow Prowess (BR, Lurrus)
#04 albert62: WURG Control (WURG)
#05 naddyeffintabs: Rakdos Midrange (BR)
#06 exoticherman: Rakdos Prowess (BR, Lurrus)
#07 alemilan19: Reclamation (UBG)
#08 Capriccioso: Amulet Titan (G)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2021_01_12 : EventTest
    {
        [Test]
        public void Deck01_Lukas261997_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-12",0),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Lavaridge_Reclamation_URG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-12",1),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Reclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck03_BMJ_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-12",2),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_albert62_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-12",3),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_naddyeffintabs_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-12",4),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_exoticherman_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-12",5),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_alemilan19_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-12",6),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(Reclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Capriccioso_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-12",7),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }


    }
}
