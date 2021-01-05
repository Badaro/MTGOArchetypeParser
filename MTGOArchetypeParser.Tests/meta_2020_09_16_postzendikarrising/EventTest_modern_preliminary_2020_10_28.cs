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
#01 Paeng_Paeng: Gifts Storm (UR)
#02 HouseOfManaMTG: Amulet Titan (RG)
#03 Zar0s: WURG Control (WURG)
#04 Laplasjan: Devoted (WG, Lurrus)
#05 otakkun: KGC Tron (G)
#06 JakeHelms: WURG Control (WURG)
#07 Violent_Outburst: UBRG Control (UBRG)
#08 crazyklicker: Heliod Combo (WG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_10_28 : EventTest
    {
        [Test]
        public void Deck01_PaengPaeng_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-28",0),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck02_HouseOfManaMTG_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-28",1),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck03_Zar0s_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-28",2),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-28",3),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_otakkun_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-28",4),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck06_JakeHelms_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-28",5),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_ViolentOutburst_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-28",6),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_crazyklicker_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-28",7),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }


    }
}
