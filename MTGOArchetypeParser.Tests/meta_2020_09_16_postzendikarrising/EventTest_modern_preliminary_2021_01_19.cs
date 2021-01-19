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
#01 JakeHelms: WURG Control (WURG)
#02 _Tia93_: Izzet Prowess (UR)
#03 rodeo: Obosh Aggro (R, Obosh)
#04 Wuhsa: Niv To Light (WUBRG, Yorion)
#05 Magic_Dan: Shadow Prowess (BRG, Lurrus)
#06 Kazuga: WURG Control (WURG)
#07 kanister: Dimir Control (UB)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2021_01_19 : EventTest
    {
        [Test]
        public void Deck01_JakeHelms_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-19",0),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Tia93_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-19",1),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck03_rodeo_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-19",2),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck04_Wuhsa_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-19",3),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck05_MagicDan_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-19",4),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_Kazuga_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-19",5),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_kanister_DimirControl_UB()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-19",6),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
