using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Soondubu: Heliod Combo (WG)
#02 eclipse4343: Miracles (WU)
#03 Smdster: WURG Control (WURG)
#04 hauterho: Obosh Aggro (R, Obosh)
#05 ZYURYO: Sultai Control (UBG)
#06 Wizard_2002: Humans (WUBRG)
#07 _LSN_: Burn (WR)
#08 mario7389: Burn (WRG)
#09 Larry11: Izzet Prowess (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_10_24 : EventTest
    {
        [Test]
        public void Deck01_Soondubu_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-24",0),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck02_eclipse4343_Miracles_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-24",1),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Miracles",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Smdster_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-24",2),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_hauterho_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-24",3),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck05_ZYURYO_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-24",4),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Wizard2002_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-24",5),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck07_LSN_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-24",6),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck08_mario7389_Burn_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-24",7),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck09_Larry11_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-24",8),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }


    }
}
