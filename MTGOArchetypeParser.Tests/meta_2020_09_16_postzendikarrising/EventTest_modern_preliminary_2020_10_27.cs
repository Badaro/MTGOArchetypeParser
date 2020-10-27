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
#01 Nytrox: HeliodCombo (WG)
#02 moyashi0904: WURGControl (WURG)
#03 Iziter: TakingTurns (WURG)
#04 joker10289: JundMidrange (BRG)
#05 Mazzu93: UBRGShadow (UBRG)
#06 kthanakit26: Humans (WUBRG)
#07 DrDree: ShadowProwess (BR, Lurrus)
#08 Phill_Hellmuth: TakingTurns (WURG)
#09 FreakNightmare: OopsAllSpells (WUBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_10_27 : EventTest
    {
        [Test]
        public void Deck01_Nytrox_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-27",0),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck02_moyashi0904_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-27",1),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Iziter_TakingTurns_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-27",2),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(TakingTurns),
                null,
                null
            );
        }

        [Test]
        public void Deck04_joker10289_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-27",3),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Mazzu93_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-27",4),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck06_kthanakit26_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-27",5),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck07_DrDree_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-27",6),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_PhillHellmuth_TakingTurns_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-27",7),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(TakingTurns),
                null,
                null
            );
        }

        [Test]
        public void Deck09_FreakNightmare_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-27",8),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }


    }
}
