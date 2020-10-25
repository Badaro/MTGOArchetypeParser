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
#01 Soondubu: HeliodCombo (WG)
#02 eclipse4343: AzoriusControl (WU)
#03 Smdster: WURGControl (WURG)
#04 hauterho: OboshAggro (R, Obosh)
#05 ZYURYO: SultaiControl (UBG)
#06 Wizard_2002: Humans (WUBRG)
#07 _LSN_: Burn (WR)
#08 mario7389: Burn (WRG)
#09 Larry11: IzzetProwess (UR)
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
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck02_eclipse4343_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-24",1),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Smdster_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-24",2),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_hauterho_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-24",3),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck05_ZYURYO_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-24",4),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Wizard2002_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-24",5),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck07_LSN_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-24",6),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck08_mario7389_Burn_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-24",7),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Larry11_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-24",8),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }


    }
}
