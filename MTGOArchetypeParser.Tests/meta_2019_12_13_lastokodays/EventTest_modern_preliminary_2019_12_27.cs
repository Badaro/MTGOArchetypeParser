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
#03 bobthedog: WUBG Prowess (WUBG)
#04 SoulStrong: Sultai Shadow (UBG)
#05 Tycko_D: Mono Red Prowess (R)
#06 Joey_Wheeler: Eldrazi Tron (C)
#07 __BMJ__: Sultai Control (UBG)
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
        public void Deck03_bobthedog_WUBGProwess_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-27",2),
                new LastOkoDays(),
                ArchetypeColor.WUBG,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck04_SoulStrong_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-27",3),
                new LastOkoDays(),
                ArchetypeColor.UBG,
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
        public void Deck06_JoeyWheeler_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-27",5),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck07_BMJ_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-27",6),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
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
