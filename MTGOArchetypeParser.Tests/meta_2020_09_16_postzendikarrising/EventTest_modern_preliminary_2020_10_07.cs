using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 otakkun: WURG Control (WURG)
#02 Sam_Lewin: Land Destruction (WR)
#03 tkcheungab: Green Tron (G)
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
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_SamLewin_LandDestruction_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-07",1),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "LandDestruction",
                null,
                null
            );
        }

        [Test]
        public void Deck03_tkcheungab_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-07",2),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck04_coert_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-07",3),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck05_AstralPlane_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-07",4),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_stayrospet_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-07",5),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_ArtemKuhtin_WhiteDevotion_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-07",6),
                "PostZendikarRising",
                ArchetypeColor.W,
                "WhiteDevotion",
                null,
                null
            );
        }

        [Test]
        public void Deck08_im2g00t4ubarn_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-07",7),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck09_sokos13_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-07",8),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck10_JakeHelms_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-07",9),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_JohnnyHobbs_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-07",10),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }


    }
}
