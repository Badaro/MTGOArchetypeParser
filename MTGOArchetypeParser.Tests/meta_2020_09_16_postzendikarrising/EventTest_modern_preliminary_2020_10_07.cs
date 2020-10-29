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
#01 otakkun: WURG Control (WURG)
#02 Sam_Lewin: Boros Land Destruction (WR)
#03 tkcheungab: KGC Tron (BG)
#04 coert: Heliod Combo (WG)
#05 AstralPlane: Shadow Prowess (BR, Lurrus)
#06 stayrospet: Shadow Prowess (BR, Lurrus)
#07 Artem_Kuhtin: White Devotion (W)
#08 im2g00t4ubarn: WURG Control (WURG)
#09 sokos13: Humans (WUBRG)
#10 JakeHelms: Shadow Prowess (WBR, Lurrus)
#11 Johnny_Hobbs: WURG Control (WURG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_10_07 : EventTest
    {
        [Test]
        public void Deck01_otakkun_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-07",0),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_SamLewin_BorosLandDestruction_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-07",1),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(BorosLandDestruction),
                null,
                null
            );
        }

        [Test]
        public void Deck03_tkcheungab_KGCTron_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-07",2),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck04_coert_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-07",3),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck05_AstralPlane_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-07",4),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_stayrospet_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-07",5),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_ArtemKuhtin_WhiteDevotion_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-07",6),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(WhiteDevotion),
                null,
                null
            );
        }

        [Test]
        public void Deck08_im2g00t4ubarn_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-07",7),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_sokos13_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-07",8),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck10_JakeHelms_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-07",9),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_JohnnyHobbs_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-07",10),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
