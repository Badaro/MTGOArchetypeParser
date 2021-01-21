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
#01 ArcanisRestored: Green Tron (G, Jegantha)
#02 Patxi: WURG Control (WURG)
#03 DDMeelow: WURG Control (WURG)
#04 signblindman: Gruul Midrange (RG)
#05 Felo: Izzet Prowess (UR)
#06 evange_: WURG Control (WURG)
#07 Laplasjan: Hammer Time (WB, Lurrus)
#08 Lukas261997: UBRG Control (UBRG)
#09 __BMJ__: Shadow Prowess (BR, Lurrus)
#10 taruto1212: WURG Control (WURG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2021_01_20 : EventTest
    {
        [Test]
        public void Deck01_ArcanisRestored_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-20",0),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck02_Patxi_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-20",1),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_DDMeelow_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-20",2),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_signblindman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-20",3),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck05_Felo_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-20",4),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck06_evange_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-20",5),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Laplasjan_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-20",6),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_Lukas261997_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-20",7),
                "PostZendikarRising",
                ArchetypeColor.UBRG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck09_BMJ_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-20",8),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_taruto1212_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-20",9),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }


    }
}
