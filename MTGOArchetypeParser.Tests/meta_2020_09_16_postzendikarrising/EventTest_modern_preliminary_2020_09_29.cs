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
#01 ZYURYO: WURGControl (WURG)
#02 Oderus Urungus: BringToNiv (WUBRG)
#03 RearrangedAS: Spirits (WU)
#04 TeeCGGaming: OopsAllSpells (WUBRG)
#05 Redgy819: RakdosMidrange (BR)
#06 McWinSauce: BringToNiv (WUBRG, Jegantha)
#07 Shazzam: Mill (UB, Lurrus)
#08 Lord_of_Puntlantis: OopsAllSpells (WUBRG)
#09 benchsummer: JundShadow (BRG)
#10 Erik157751: ShadowProwess (BR, Lurrus)
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
        public void Deck02_OderusUrungus_BringToNiv_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-29",1),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
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
        public void Deck06_McWinSauce_BringToNiv_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-29",5),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
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
                typeof(GenericShadow),
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
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
