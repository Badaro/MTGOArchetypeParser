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
                "LastOkoDays",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck02_WorstNewbEver_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-27",1),
                "LastOkoDays",
                ArchetypeColor.BG,
                "Yawgmoth",
                null,
                null
            );
        }

        [Test]
        public void Deck03_bobthedog_KethisCombo_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-27",2),
                "LastOkoDays",
                ArchetypeColor.WUBG,
                "KethisCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck04_SoulStrong_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-27",3),
                "LastOkoDays",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck05_TyckoD_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-27",4),
                "LastOkoDays",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck06_JoeyWheeler_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-27",5),
                "LastOkoDays",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck07_BMJ_UrzaOko_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-27",6),
                "LastOkoDays",
                ArchetypeColor.UBG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Astrandberg_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-27",7),
                "LastOkoDays",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }


    }
}
