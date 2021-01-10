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
#01 Phill_Hellmuth: Primeval Titan (UG)
#02 WorstNewbEver: Yawgmoth (BG)
#03 bobthedog: Kethis Combo (WUBG)
#04 SoulStrong: UBRG Shadow (UBRG)
#05 Tycko_D: Mono Red Prowess (R)
#06 Joey_Wheeler: Eldrazi Tron (G)
#07 __BMJ__: Urza Oko (UBG)
#08 Astrandberg: Grixis Shadow (UBR)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_13_lastokodays
{
    public class EventTest_modern_preliminary_2019_12_27 : EventTest
    {
        [Test]
        public void Deck01_PhillHellmuth_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-27",0),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck02_WorstNewbEver_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-27",1),
                new LastOkoDays(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck03_bobthedog_KethisCombo_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-27",2),
                new LastOkoDays(),
                ArchetypeColor.WUBG,
                typeof(KethisCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck04_SoulStrong_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-27",3),
                new LastOkoDays(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck05_TyckoD_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-27",4),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck06_JoeyWheeler_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-27",5),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck07_BMJ_UrzaOko_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-27",6),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Astrandberg_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-27",7),
                new LastOkoDays(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }


    }
}
