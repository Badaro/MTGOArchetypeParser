using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 hauterho: Obosh Aggro (BR, Obosh)
#02 _Batutinha_: WURG Control (WURG)
#03 Wizard_2002: Burn (WRG)
#04 eclipse4343: Miracles (WU)
#05 coLDuster: Reclaimer Titan (WRG)
#06 ice_nine_: Land Destruction (WR)
#07 Blade400: Eldrazi Tron (C)
#08 JUJUBEAN__2004: Heliod Combo (WG)
#09 Zar0s: WURG Control (WURG)
#10 KarnageKardsENT: WURG Control (WURG)
#11 Lordzedane: Green Tron (G)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_11_28 : EventTest
    {
        [Test]
        public void Deck01_hauterho_OboshAggro_BR_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-28",0),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck02_Batutinha_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-28",1),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Wizard2002_Burn_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-28",2),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck04_eclipse4343_Miracles_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-28",3),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Miracles",
                null,
                null
            );
        }

        [Test]
        public void Deck05_coLDuster_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-28",4),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck06_icenine_LandDestruction_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-28",5),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "LandDestruction",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Blade400_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-28",6),
                "PostZendikarRising",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck08_JUJUBEAN2004_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-28",7),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Zar0s_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-28",8),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck10_KarnageKardsENT_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-28",9),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck11_Lordzedane_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-28",10),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }


    }
}
