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
#01 Gobern: Niv To Light (WUBRG, Yorion)
#02 azatoyellow: Obosh Aggro (R, Obosh)
#03 im2g00t4ubarn: WURG Control (WURG)
#04 MyNameTidus: Heliod Combo (WG)
#05 cjucjujp: Kuldotha Red (R)
#06 Erik157751: Shadow Prowess (BR, Lurrus)
#07 medvedev: Bogles (WG, Lurrus)
#08 AstralPlane: Shadow Prowess (BR, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_10_10 : EventTest
    {
        [Test]
        public void Deck01_Gobern_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-10",0),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_azatoyellow_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-10",1),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck03_im2g00t4ubarn_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-10",2),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_MyNameTidus_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-10",3),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck05_cjucjujp_KuldothaRed_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-10",4),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(KuldothaAggro),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Erik157751_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-10",5),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_medvedev_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-10",6),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_AstralPlane_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-10",7),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
