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
#01 JUJUBEAN__2004: UBRG Control (UBRG)
#02 Theo_Jung: Reclaimer Titan (WRG)
#03 Coronthemoron: Oops All Spells (WUBRG)
#04 ChironTheMage: Jeskai Control (WUR)
#05 exoticherman: Jund Shadow (BRG)
#06 polishdynamit3: Shadow Prowess (WBR, Lurrus)
#07 Bunnykept: Heliod Combo (WG)
#08 eclipse4343: Azorius Control (WU)
#09 Leviathan102: KGC Amulet Titan (URG)
#10 random_deck: Selenya Midrange (WG)
#11 ice_nine_: Boros Land Destruction (WR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_10_31 : EventTest
    {
        [Test]
        public void Deck01_JUJUBEAN2004_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-31",0),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_TheoJung_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-31",1),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck03_Coronthemoron_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-31",2),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck04_ChironTheMage_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-31",3),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_exoticherman_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-31",4),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck06_polishdynamit3_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-31",5),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_Bunnykept_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-31",6),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck08_eclipse4343_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-31",7),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Leviathan102_KGCAmuletTitan_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-31",8),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck10_randomdeck_SelenyaMidrange_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-31",9),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck11_icenine_BorosLandDestruction_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-31",10),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(BorosLandDestruction),
                null,
                null
            );
        }


    }
}
