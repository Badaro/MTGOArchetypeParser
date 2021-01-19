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
#01 ZYURYO: WURG Control (WURG)
#02 Oderus Urungus: Niv To Light (WUBRG)
#03 RearrangedAS: Spirits (WU)
#04 TeeCGGaming: Oops All Spells (WUBRG)
#05 Redgy819: Rakdos Midrange (BR)
#06 McWinSauce: Niv To Light (WUBRG, Jegantha)
#07 Shazzam: Mill (UB, Lurrus)
#08 Lord_of_Puntlantis: Oops All Spells (WUBRG)
#09 benchsummer: Jund Shadow (BRG)
#10 Erik157751: Shadow Prowess (BR, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_09_29 : EventTest
    {
        [Test]
        public void Deck01_ZYURYO_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-29",0),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_OderusUrungus_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-29",1),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck03_RearrangedAS_Spirits_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-29",2),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck04_TeeCGGaming_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-29",3),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Redgy819_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-29",4),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_McWinSauce_NivToLight_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-29",5),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck07_Shazzam_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-29",6),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_LordofPuntlantis_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-29",7),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck09_benchsummer_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-29",8),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Erik157751_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-29",9),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
