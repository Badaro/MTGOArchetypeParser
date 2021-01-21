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
#01 Violent_Outburst: Temur Control (URG)
#02 triosk: Shadow Prowess (BR, Lurrus)
#03 Rosencrantz_920: Amulet Titan (G)
#04 ziofrancone: Shadow Prowess (BRG, Lurrus)
#05 CharlesWang: Hardened Scales (G)
#06 Gerardo94: WURG Control (WURG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_12_19 : EventTest
    {
        [Test]
        public void Deck01_ViolentOutburst_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-19",0),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_triosk_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-19",1),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_Rosencrantz920_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-19",2),
                "PostZendikarRising",
                ArchetypeColor.G,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck04_ziofrancone_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-19",3),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_CharlesWang_HardenedScales_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-19",4),
                "PostZendikarRising",
                ArchetypeColor.G,
                "HardenedScales",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Gerardo94_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-19",5),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }


    }
}
