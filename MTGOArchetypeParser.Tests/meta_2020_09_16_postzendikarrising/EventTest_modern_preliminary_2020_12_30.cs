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
#01 trader08111: Izzet Prowess (UR)
#02 albert62: WURG Control (WURG)
#03 Gerardo94: WURG Control (WURG)
#04 PanJ: Grixis Shadow (UBR)
#05 kanister: Izzet Living End (UR)
#06 Elninyo: Ad Nauseam (WUB)
#07 ArchaeusDota: Uroza (URG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_12_30 : EventTest
    {
        [Test]
        public void Deck01_trader08111_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-30",0),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck02_albert62_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-30",1),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Gerardo94_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-30",2),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_PanJ_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-30",3),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck05_kanister_IzzetLivingEnd_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-30",4),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroEnd),
                null
            );
        }

        [Test]
        public void Deck06_Elninyo_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-30",5),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck07_ArchaeusDota_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-30",6),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }


    }
}
