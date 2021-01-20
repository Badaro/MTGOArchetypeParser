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
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck02_Patxi_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-20",1),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_DDMeelow_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-20",2),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_signblindman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-20",3),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Felo_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-20",4),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck06_evange_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-20",5),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Laplasjan_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-20",6),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_Lukas261997_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-20",7),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_BMJ_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-20",8),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_taruto1212_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-20",9),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
