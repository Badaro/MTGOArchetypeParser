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
#01 hauterho: Obosh Aggro (BR, Obosh)
#02 _Batutinha_: WURG Control (WURG)
#03 Wizard_2002: Burn (WRG)
#04 eclipse4343: Azorius Control (WU)
#05 coLDuster: Reclaimer Titan (WRG)
#06 ice_nine_: Boros Land Destruction (WR)
#07 Blade400: E Tron (C)
#08 JUJUBEAN__2004: Heliod Combo (WG)
#09 Zar0s: WURG Control (WURG)
#10 KarnageKardsENT: WURG Control (WURG)
#11 Lordzedane: KGC Tron (G)
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
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck02_Batutinha_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-28",1),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Wizard2002_Burn_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-28",2),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck04_eclipse4343_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-28",3),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_coLDuster_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-28",4),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck06_icenine_BorosLandDestruction_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-28",5),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(BorosLandDestruction),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Blade400_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-28",6),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck08_JUJUBEAN2004_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-28",7),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Zar0s_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-28",8),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_KarnageKardsENT_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-28",9),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Lordzedane_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-28",10),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }


    }
}
